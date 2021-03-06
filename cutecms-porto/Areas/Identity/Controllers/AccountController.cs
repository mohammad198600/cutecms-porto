﻿using cutecms_porto.Areas.Identity.Models;
using cutecms_porto.Areas.Identity.Models.DBModel;
using cutecms_porto.Helpers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Security;
using System.Data.Entity;

namespace cutecms_porto.Areas.Identity.Controllers
{
    public enum ManageMessageId
    {
        ChangePasswordSuccess,
        SetPasswordSuccess,
        RemoveLoginSuccess,
        Error
    }
    public class AccountController : BaseController
    {
        #region Fields
        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";

        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationDbContext _db = new ApplicationDbContext();
        private IdentityDbContext db = new IdentityDbContext();
        #endregion Fields

        #region Constructors
        public AccountController()
        {
        }

        public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        #endregion Constructors

        #region Properties
        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        #endregion Properties

        #region Methods
        public ActionResult Welcome()
        {
            return View();
        }
        [LocalizedAuthorize(Roles = "Admin")]
        public ActionResult Index(int? page, string userNameFilter, string emailFilter, string roleIdFilter, bool isEmailConfirmedFilter = true)
        {
            var pageNumber = page ?? 1;
            ViewBag.UserNameFilter = userNameFilter;
            ViewBag.EmailFilter = emailFilter;
            ViewBag.RoleIdFilter = new SelectList(_db.Roles, "Id", "Name", roleIdFilter);
            ViewBag.RoleId = roleIdFilter;
            ViewBag.IsEmailConfirmedFilter = isEmailConfirmedFilter;
            ViewBag.IsEmailConfirmed = isEmailConfirmedFilter;
            List<ApplicationUser> users = (from u in db.Users.Where(u => (u.UserName.Contains(userNameFilter) || string.IsNullOrEmpty(userNameFilter)) && (u.Email.Contains(emailFilter) || string.IsNullOrEmpty(emailFilter)) && u.EmailConfirmed == isEmailConfirmedFilter)
                                           where (u.Roles.Any(r => r.RoleId == roleIdFilter) || string.IsNullOrEmpty(roleIdFilter))
                                           select new ApplicationUser { Id = u.Id, Email = u.Email }).ToList();
            return View(users.ToPagedList(pageNumber, 10));
        }

        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            OutputCacheAttribute.ChildActionCache = new MemoryCache("NewDefault");
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            if (!ModelState.IsValid)
                return View(model);
            // This doesn't count login failures towards account lockout To enable password failures
            // to trigger account lockout, change to shouldLockout: true
            var result = await SignInManager.PasswordSignInAsync(model.Email.ToLower().Trim(), model.Password, model.RememberMe, shouldLockout: true);
            var user = await UserManager.FindByNameAsync(model.Email.ToLower().Trim());
            switch (result)
            {
                case SignInStatus.Success:
                    if (!await UserManager.IsEmailConfirmedAsync(user.Id))
                    {
                        ViewBag.ReturnUrl = returnUrl;
                        ModelState.AddModelError("", Resources.Resources.EmailConfirmationCheck);
                        return View(model);
                    }
                    return RedirectToLocal(returnUrl, user.Id);
                case SignInStatus.LockedOut:
                    return View("Lockout");

                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                case SignInStatus.Failure:
                default:
                    ViewBag.ReturnUrl = returnUrl;
                    ModelState.AddModelError("", Resources.Resources.InvalidLoginAttempt);
                    return View(model);
            }
        }

        // GET: /Account/VerifyCode
        [AllowAnonymous]
        public async Task<ActionResult> VerifyCode(string provider, string returnUrl, bool rememberMe)
        {
            // Require that the user has already logged in via username/password or external login
            if (!await SignInManager.HasBeenVerifiedAsync())
            {
                return View("Error");
            }
            return View(new VerifyCodeViewModel { Provider = provider, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        // POST: /Account/VerifyCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> VerifyCode(VerifyCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // The following code protects for brute force attacks against the two factor codes. If a
            // user enters incorrect codes for a specified amount of time then the user account will
            // be locked out for a specified amount of time. You can configure the account lockout
            // settings in IdentityConfig
            var result = await SignInManager.TwoFactorSignInAsync(model.Provider, model.Code, isPersistent: model.RememberMe, rememberBrowser: model.RememberBrowser);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(model.ReturnUrl, null);

                case SignInStatus.LockedOut:
                    return View("Lockout");

                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("",Resources.Resources.InvalidCode);
                    return View(model);
            }
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            OutputCacheAttribute.ChildActionCache = new MemoryCache("NewDefault");
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email.Trim().ToLower(), Email = model.Email.Trim().ToLower() };
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                    // For more information on how to enable account confirmation and password reset
                    // please visit http://go.microsoft.com/fwlink/?LinkID=320771 Send an email with
                    // this link
                    string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    var callbackUrl = Url.Action("ConfirmEmail", "Account", new { area = "Identity", userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");
                    return RedirectToAction("Welcome", "Home", new { area = "" });
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            if (RouteData.DataTokens["area"] == null)
                return View("~/Views/Shared/RegisterAjax.cshtml", model);
            return View(model);

        }

        // GET: /Account/ConfirmEmail
        [AllowAnonymous]
        public async Task<ActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                throw new HttpException(400, "Bad Request");
            }
            var result = await UserManager.ConfirmEmailAsync(userId, code);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }

        // GET: /Account/ForgotPassword
        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        // POST: /Account/ForgotPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByNameAsync(model.Email);
                if (user == null || !(await UserManager.IsEmailConfirmedAsync(user.Id)))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    return RedirectToAction("ForgotPasswordConfirmation", "Account", new { area = "Identity" });
                }
                // For more information on how to enable account confirmation and password reset
                // please visit http://go.microsoft.com/fwlink/?LinkID=320771 Send an email with this link

                string code = await UserManager.GeneratePasswordResetTokenAsync(user.Id);
                var callbackUrl = Url.Action("ResetPassword", "Account", new { area = "Identity", userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                await UserManager.SendEmailAsync(user.Id, "Reset Password", "Please reset your password by clicking <a href=\"" + callbackUrl + "\">here</a>");
                return RedirectToAction("ForgotPasswordConfirmation", "Account", new { area = "Identity" });
            }
            // If we got this far, something failed, redisplay form
            //if (RouteData.DataTokens["area"] == null)
            //    return RedirectToAction("ForgotPasswordConfirmation", "Account", new { area = "Identity" });
            return View(model);
        }

        // GET: /Account/ForgotPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        // GET: /Account/ResetPassword
        [AllowAnonymous]
        public ActionResult ResetPassword(string code)
        {

            return code == null ? View("InvalidToken") : View();
        }

        // POST: /Account/ResetPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await UserManager.FindByNameAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return View("ResetPasswordConfirmation");
            }
            var result = await UserManager.ResetPasswordAsync(user.Id, model.Code, model.Password);
            if (result.Succeeded)
            {
                return View("ResetPasswordConfirmation");
            }
            ModelState.AddModelError("InvalidToken", Resources.Resources.InvalidToken);
            return View(model);
        }

        // GET: /Account/ResetPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        // POST: /Account/ExternalLogin
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalLogin(string provider, string returnUrl)
        {
            // Request a redirect to the external login provider
            return new ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl }));
        }

        // GET: /Account/SendCode
        [AllowAnonymous]
        public async Task<ActionResult> SendCode(string returnUrl, bool rememberMe)
        {
            var userId = await SignInManager.GetVerifiedUserIdAsync();
            if (userId == null)
            {
                return View("Error");
            }
            var userFactors = await UserManager.GetValidTwoFactorProvidersAsync(userId);
            var factorOptions = userFactors.Select(purpose => new SelectListItem { Text = purpose, Value = purpose }).ToList();
            return View(new SendCodeViewModel { Providers = factorOptions, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        // POST: /Account/SendCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SendCode(SendCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            // Generate the token and send it
            if (!await SignInManager.SendTwoFactorCodeAsync(model.SelectedProvider))
            {
                return View("Error");
            }
            return RedirectToAction("VerifyCode", new { Provider = model.SelectedProvider, ReturnUrl = model.ReturnUrl, RememberMe = model.RememberMe });
        }

        // GET: /Account/ExternalLoginCallback
        [AllowAnonymous]
        public async Task<ActionResult> ExternalLoginCallback(string returnUrl)
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                return RedirectToAction("Login");
            }

            // Sign in the user with this external login provider if the user already has a login
            var result = await SignInManager.ExternalSignInAsync(loginInfo, isPersistent: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(returnUrl, null);

                case SignInStatus.LockedOut:
                    return View("Lockout");

                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = false });

                case SignInStatus.Failure:
                default:
                    // If the user does not have an account, then prompt the user to create an account
                    ViewBag.ReturnUrl = returnUrl;
                    ViewBag.LoginProvider = loginInfo.Login.LoginProvider;
                    return View("ExternalLoginConfirmation", new ExternalLoginConfirmationViewModel { Email = loginInfo.Email });
            }
        }

        // POST: /Account/ExternalLoginConfirmation
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ExternalLoginConfirmation(ExternalLoginConfirmationViewModel model, string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Manage");
            }

            if (ModelState.IsValid)
            {
                // Get the information about the user from the external login provider
                var info = await AuthenticationManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    return View("ExternalLoginFailure");
                }
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await UserManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await UserManager.AddLoginAsync(user.Id, info.Login);
                    if (result.Succeeded)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                        return RedirectToLocal(returnUrl, null);
                    }
                }
                AddErrors(result);
            }

            ViewBag.ReturnUrl = returnUrl;
            return View(model);
        }

        // POST: /Account/LogOff
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff(string returnUrl)
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            OutputCacheAttribute.ChildActionCache = new MemoryCache("NewDefault");
            returnUrl = HttpUtility.UrlDecode(returnUrl);

            if (returnUrl.Equals("/"))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            else if ((returnUrl != null) && Url.IsLocalUrl(returnUrl) && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
            {
                return RedirectToAction("Login", new { returnUrl = returnUrl });
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: /Account/ExternalLoginFailure
        [AllowAnonymous]
        public ActionResult ExternalLoginFailure()
        {
            return View();
        }
        [LocalizedAuthorize(Roles = "Admin")]
        public ActionResult UserGroups(string id)
        {
            var user = _db.Users.Find(id);
            var model = new SelectUserGroupsViewModel(user);
            return View(model);
        }

        [HttpPost]
        [LocalizedAuthorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult UserGroups(SelectUserGroupsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var idManager = new IdentityManager();
                var user = _db.Users.First(u => u.UserName == model.UserName);
                idManager.ClearUserGroups(user.Id);
                foreach (var group in model.Groups.Where(g => g.Selected))
                {
                    idManager.AddUserToGroup(user.Id, group.GroupId);
                }
                return RedirectToAction("index");
            }
            return View();
        }
        [LocalizedAuthorize(Roles = "Admin")]
        public ActionResult UserRoles(string id)
        {
            var user = _db.Users.Find(id);
            var model = new SelectUserRolesViewModel(user);
            return View(model);
        }
        [HttpPost]
        [LocalizedAuthorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult UserRoles(SelectUserRolesViewModel model)
        {
            if (ModelState.IsValid)
            {
                var idManager = new IdentityManager();
                var user = _db.Users.First(u => u.Id == model.Id);
                idManager.ClearUserRoles(user.Id);
                foreach (var role in model.Roles.Where(r => r.Selected))
                {
                        idManager.AddUserToRole(user.Id, role.RoleName);
                }
            }
            return View(model);
        }
        [LocalizedAuthorize(Roles = "Admin")]
        public ActionResult Edit(string id, ManageMessageId? Message = null)
        {
            var user = _db.Users.Find(id);
            var model = new UserViewModel(user);
            ViewBag.MessageId = Message;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _db.Users.First(u => u.UserName == model.UserName);
                //user.FirstName = model.FirstName;
                //user.LastName = model.LastName;
                user.Email = model.Email;
                user.UserName = user.Email;
                _db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            // If we got this far, something failed, redisplay form
            return View(model);
        }
        [LocalizedAuthorize(Roles = "Admin")]
        public ActionResult Delete(string id = null)
        {
            var user = _db.Users.Find(id);
            var model = new UserViewModel(user);
            if (user == null)
            {
                throw new HttpException(404, "Page Not Found");
            }
            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        [LocalizedAuthorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            var user = _db.Users.Find(id);
            _db.Users.Remove(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_userManager != null)
                {
                    _userManager.Dispose();
                    _userManager = null;
                }

                if (_signInManager != null)
                {
                    _signInManager.Dispose();
                    _signInManager = null;
                }
            }

            base.Dispose(disposing);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private ActionResult RedirectToLocal(string returnUrl, string currentUserId)
        {
            //if (!string.IsNullOrEmpty(currentUserId))
            //{
            //    IdentityEntities identityDB = new IdentityEntities();
            //    var hasProfile = identityDB.Employees.Where(e => e.LoginId.Equals(currentUserId) && e.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).SingleOrDefault();
            //    if (hasProfile == null)
            //    {
            //        return RedirectToAction("Index", "MyProfile", new { area = "" });
            //    }
            //}
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            return RedirectToAction("Index", "Home");
        }
        #endregion Methods

        #region Classes
        internal class ChallengeResult : HttpUnauthorizedResult
        {
            #region Constructors
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }
            #endregion Constructors

            #region Properties
            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }
            #endregion Properties

            #region Methods
            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new AuthenticationProperties { RedirectUri = RedirectUri };
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }
            #endregion Methods
        }
        #endregion Classes
    }
}