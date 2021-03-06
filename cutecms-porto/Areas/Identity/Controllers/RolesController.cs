﻿using cutecms_porto.Areas.Identity.Models;
using cutecms_porto.Helpers;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cutecms_porto.Areas.Identity.Controllers
{
    [LocalizedAuthorize(Roles = "Admin,Identity,Roles")]
    public class RolesController : BaseController
    {
        #region Fields
        private ApplicationDbContext db = new ApplicationDbContext();
        #endregion Fields

        #region Methods
        public ActionResult Index()
        {
            var rolesList = new List<RoleViewModel>();
            var roles = db.Roles.OrderBy(r => r.Description).ThenBy(r => r.Name).ToList();
            foreach (var role in roles)
            {
                var roleModel = new RoleViewModel(role);
                rolesList.Add(roleModel);
            }
            return View(rolesList);
        }

        public ActionResult Create(string message = "")
        {
            ViewBag.Message = message;
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "RoleName,Description")]RoleViewModel model)
        {
            string message = Resources.Resources.RoleInUse;
            if (ModelState.IsValid)
            {
                var role = new ApplicationRole(model.RoleName, model.Description);
                var idManager = new IdentityManager();

                if (idManager.RoleExists(model.RoleName))
                {
                    ModelState.AddModelError("error", Resources.Resources.RoleInUse);
                }
                else
                {
                    idManager.CreateRole(model.RoleName, model.Description);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Edit(string id)
        {
            // It's actually the Role.Name tucked into the id param:
            var role = db.Roles.First(r => r.Name == id);
            var roleModel = new EditRoleViewModel(role);
            return View(roleModel);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "RoleName,OriginalRoleName,Description")] EditRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var idManager = new IdentityManager();
                if (idManager.RoleExists(model.RoleName))
                {
                    ModelState.AddModelError("error", Resources.Resources.RoleInUse);
                }
                else
                {
                    var role = db.Roles.First(r => r.Name == model.OriginalRoleName);
                    role.Name = model.RoleName;
                    role.Description = model.Description;
                    db.Entry(role).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                throw new HttpException(400, "Bad Request");
            }
            var role = db.Roles.First(r => r.Name == id);
            var model = new RoleViewModel(role);
            if (role == null)
            {
                throw new HttpException(404, "Page Not Found");
            }
            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            var role = db.Roles.First(r => r.Name == id);
            var idManager = new IdentityManager();
            idManager.DeleteRole(role.Id);
            return RedirectToAction("Index");
        }
        #endregion Methods
    }
}