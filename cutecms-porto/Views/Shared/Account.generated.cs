﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    
    #line 4 "..\..\Views\Shared\Account.cshtml"
    using System.Threading;
    
    #line default
    #line hidden
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using cutecms_porto;
    
    #line 1 "..\..\Views\Shared\Account.cshtml"
    using cutecms_porto.Areas.Identity.Models;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\Account.cshtml"
    using cutecms_porto.Areas.Identity.Models.DBModel;
    
    #line default
    #line hidden
    using cutecms_porto.Helpers;
    
    #line 3 "..\..\Views\Shared\Account.cshtml"
    using Microsoft.AspNet.Identity;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Account.cshtml")]
    public partial class _Views_Shared_Account_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_Account_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Shared\Account.cshtml"
 if (!Request.IsAuthenticated)
{

            
            #line default
            #line hidden
WriteLiteral("    <li");

WriteLiteral(" class=\"dropdown pull-right dropdown-mega dropdown-mega-signin signin\"");

WriteLiteral(" id=\"headerAccount\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i> ");

            
            #line 9 "..\..\Views\Shared\Account.cshtml"
                                  Write(Resources.Resources.LogIn);

            
            #line default
            #line hidden
WriteLiteral("\r\n            <i");

WriteLiteral(" class=\"fa fa-caret-down\"");

WriteLiteral("></i>\r\n        </a>\r\n        <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(">\r\n            <li>\r\n                <div");

WriteLiteral(" class=\"dropdown-mega-content\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"signin-form\"");

WriteLiteral(">\r\n");

            
            #line 18 "..\..\Views\Shared\Account.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Shared\Account.cshtml"
                                  Html.RenderPartial("~/Views/Shared/LoginAjax.cshtml", new LoginViewModel());
            
            #line default
            #line hidden
WriteLiteral("\r\n                                <p");

WriteLiteral(" class=\"sign-up-info\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Shared\Account.cshtml"
                                                   Write(Resources.Resources.RegisterNewUser);

            
            #line default
            #line hidden
WriteLiteral(" <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"headerSignUp\"");

WriteLiteral(" class=\"p-none m-none ml-xs\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Shared\Account.cshtml"
                                                                                                                                                  Write(Resources.Resources.Register);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"signup-form\"");

WriteLiteral(">\r\n");

            
            #line 22 "..\..\Views\Shared\Account.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Shared\Account.cshtml"
                                  Html.RenderPartial("~/Views/Shared/RegisterAjax.cshtml", new RegisterViewModel());
            
            #line default
            #line hidden
WriteLiteral("\r\n                                <p");

WriteLiteral(" class=\"log-in-info\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\Shared\Account.cshtml"
                                                  Write(Resources.Resources.AlreadyMember);

            
            #line default
            #line hidden
WriteLiteral(" <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"headerSignIn\"");

WriteLiteral(" class=\"p-none m-none ml-xs\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\Shared\Account.cshtml"
                                                                                                                                               Write(Resources.Resources.LogIn);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"recover-form\"");

WriteLiteral(">\r\n");

            
            #line 26 "..\..\Views\Shared\Account.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Shared\Account.cshtml"
                                  Html.RenderPartial("~/Views/Shared/ForgotPasswordAjax.cshtml", new ForgotPasswordViewModel());
            
            #line default
            #line hidden
WriteLiteral("\r\n                                <p");

WriteLiteral(" class=\"log-in-info\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Shared\Account.cshtml"
                                                  Write(Resources.Resources.AlreadyMember);

            
            #line default
            #line hidden
WriteLiteral(" <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"headerRecoverCancel\"");

WriteLiteral(" class=\"p-none m-none ml-xs\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Shared\Account.cshtml"
                                                                                                                                                      Write(Resources.Resources.LogIn);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n                            </div>\r\n                        </div>\r\n   " +
"                 </div>\r\n                </div>\r\n\r\n            </li>\r\n        </" +
"ul>\r\n    </li>\r\n");

            
            #line 36 "..\..\Views\Shared\Account.cshtml"
                                    }
                                    else
                                    {


            
            #line default
            #line hidden
WriteLiteral("                                        <li");

WriteLiteral(" class=\"dropdown active pull-right width-100\"");

WriteLiteral(">\r\n                                            <a");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 41 "..\..\Views\Shared\Account.cshtml"
                                                                           Write(Resources.Resources.Hello);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 41 "..\..\Views\Shared\Account.cshtml"
                                                                                                      Write(User.Identity.GetUserName().Substring(0, User.Identity.GetUserName().LastIndexOf("@")));

            
            #line default
            #line hidden
WriteLiteral(" !</a>\r\n                                            <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(">\r\n                                                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2531), Tuple.Create("\"", 2571)
            
            #line 43 "..\..\Views\Shared\Account.cshtml"
, Tuple.Create(Tuple.Create("", 2538), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "MyProfile")
            
            #line default
            #line hidden
, 2538), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i> ");

            
            #line 43 "..\..\Views\Shared\Account.cshtml"
                                                                                                                      Write(Resources.Resources.MyProfile);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n\r\n                                                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2697), Tuple.Create("\"", 2758)
            
            #line 45 "..\..\Views\Shared\Account.cshtml"
, Tuple.Create(Tuple.Create("", 2704), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Manage", new { area="Identity"})
            
            #line default
            #line hidden
, 2704), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i> ");

            
            #line 45 "..\..\Views\Shared\Account.cshtml"
                                                                                                                                          Write(Resources.Resources.AccountSettings);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n\r\n");

            
            #line 47 "..\..\Views\Shared\Account.cshtml"
                                                
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Shared\Account.cshtml"
                                                 if (User.IsInRole("Admin"))
                                                {

            
            #line default
            #line hidden
WriteLiteral("                                                    <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3022), Tuple.Create("\"", 3076)
            
            #line 49 "..\..\Views\Shared\Account.cshtml"
, Tuple.Create(Tuple.Create("", 3029), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Home", new { area="CMS"})
            
            #line default
            #line hidden
, 3029), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-arrow-circle-left\"");

WriteLiteral("></i> ");

            
            #line 49 "..\..\Views\Shared\Account.cshtml"
                                                                                                                                                     Write(Resources.Resources.Backend);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 50 "..\..\Views\Shared\Account.cshtml"

                                                }

            
            #line default
            #line hidden
WriteLiteral("                                                ");

            
            #line 52 "..\..\Views\Shared\Account.cshtml"
                                                 using (Html.BeginForm("LogOff", "Account", new { area = "Identity", returnUrl = "/" }, FormMethod.Post, new { id = "logoutForm" }))
                                                {
                                                    
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Shared\Account.cshtml"
                                               Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Shared\Account.cshtml"
                                                                            

            
            #line default
            #line hidden
WriteLiteral("                                                    <li><a");

WriteLiteral(" href=\"javascript:document.getElementById(\'logoutForm\').submit()\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-off\"");

WriteLiteral("></i> ");

            
            #line 55 "..\..\Views\Shared\Account.cshtml"
                                                                                                                                                               Write(Resources.Resources.LogOff);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 56 "..\..\Views\Shared\Account.cshtml"
                                                }

            
            #line default
            #line hidden
WriteLiteral("                                            </ul>\r\n\r\n                            " +
"            </li>\r\n");

            
            #line 60 "..\..\Views\Shared\Account.cshtml"
                                    }
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
