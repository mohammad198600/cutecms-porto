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
    using cutecms_porto.Helpers;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Login.cshtml")]
    public partial class _Views_Shared_Login_cshtml : System.Web.Mvc.WebViewPage<cutecms_porto.Areas.Identity.Models.LoginViewModel>
    {
        public _Views_Shared_Login_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-lg-4\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Views\Shared\Login.cshtml"
            
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Shared\Login.cshtml"
             using (Html.BeginForm("Login", "Account", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {
                
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Shared\Login.cshtml"
           Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Shared\Login.cshtml"
                                        

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" id=\"LoginAjax\"");

WriteLiteral(">\r\n                    <h4");

WriteLiteral(" class=\"dropdown-mega-sub-title\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\Shared\Login.cshtml"
                                                   Write(Resources.Resources.LoginToSite);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-12 p-none\"");

WriteLiteral(">\r\n                                ");

WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 16 "..\..\Views\Shared\Login.cshtml"
                           Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control input-lg", @placeholder = @Resources.Resources.Email + "..." }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 17 "..\..\Views\Shared\Login.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"         </div>\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-12 p-none\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"mt-none p-none\"");

WriteLiteral(" id=\"headerRecover\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1228), Tuple.Create("\"", 1297)
            
            #line 24 "..\..\Views\Shared\Login.cshtml"
   , Tuple.Create(Tuple.Create("", 1235), Tuple.Create<System.Object, System.Int32>(Url.Action("ForgotPassword","Account",new { area="Identity"})
            
            #line default
            #line hidden
, 1235), false)
);

WriteLiteral(">(");

            
            #line 24 "..\..\Views\Shared\Login.cshtml"
                                                                                                                                               Write(Resources.Resources.ForgetPassword);

            
            #line default
            #line hidden
WriteLiteral(")</a>\r\n");

WriteLiteral("                                ");

            
            #line 25 "..\..\Views\Shared\Login.cshtml"
                           Write(Html.PasswordFor(m => m.Password, new { @class = "form-control input-lg", @placeholder = @Resources.Resources.Password + "..." }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 26 "..\..\Views\Shared\Login.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"         </div>\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-6 p-none\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"remember-box checkbox\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" for=\"rememberme\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 34 "..\..\Views\Shared\Login.cshtml"
                               Write(Html.CheckBoxFor(m => m.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 35 "..\..\Views\Shared\Login.cshtml"
                               Write(Html.LabelFor(m => m.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </label>\r\n                            </span>\r\n" +
"                        </div>\r\n                    </div>\r\n\r\n                  " +
"  <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-12 p-none\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2326), Tuple.Create("\"", 2360)
            
            #line 43 "..\..\Views\Shared\Login.cshtml"
, Tuple.Create(Tuple.Create("", 2334), Tuple.Create<System.Object, System.Int32>(Resources.Resources.LogIn
            
            #line default
            #line hidden
, 2334), false)
);

WriteLiteral(" class=\"btn btn-primary mb-xl\"");

WriteLiteral(" data-loading-text=\"Loading...\"");

WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                  " +
"  <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-12 p-none\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 48 "..\..\Views\Shared\Login.cshtml"
                       Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n");

            
            #line 52 "..\..\Views\Shared\Login.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
