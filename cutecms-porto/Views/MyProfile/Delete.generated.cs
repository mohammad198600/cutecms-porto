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
    
    #line 3 "..\..\Views\MyProfile\Delete.cshtml"
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
    
    #line 2 "..\..\Views\MyProfile\Delete.cshtml"
    using cutecms_porto.Areas.Identity.Models;
    
    #line default
    #line hidden
    using cutecms_porto.Helpers;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MyProfile/Delete.cshtml")]
    public partial class _Views_MyProfile_Delete_cshtml : System.Web.Mvc.WebViewPage<cutecms_porto.Areas.Identity.Models.DBModel.Employee>
    {
        public _Views_MyProfile_Delete_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\MyProfile\Delete.cshtml"
  
    ViewBag.Title = Resources.Resources.Delete;
    ApplicationDbContext dbIdentity = new ApplicationDbContext();

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("PageHeader", () => {

WriteLiteral("\r\n    <section");

WriteLiteral(" class=\"page-header\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                    <h1>");

            
            #line 14 "..\..\Views\MyProfile\Delete.cshtml"
                   Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>" +
"\r\n");

});

WriteLiteral("<section>\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <!-- RIGHT -->\r\n        <div");

WriteLiteral(" class=\"col-lg-9 col-md-9 col-sm-8 col-lg-push-3 col-md-push-3 col-sm-push-4 marg" +
"in-bottom-80\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" id=\"tabbed-list\"");

WriteLiteral(" class=\"nav nav-tabs nav-top-border\"");

WriteLiteral(">\r\n                <li");

WriteLiteral(" class=\"active\"");

WriteLiteral("><a");

WriteLiteral(" data-toggle=\"tab\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\MyProfile\Delete.cshtml"
                                                   Write(Resources.Resources.Translations);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            </ul>\r\n            <div");

WriteLiteral(" class=\"tab-content margin-top-20\"");

WriteLiteral(">\r\n                <h3>");

            
            #line 28 "..\..\Views\MyProfile\Delete.cshtml"
               Write(Resources.Resources.DeleteConfirmation);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                <div>\r\n                    <h4>");

            
            #line 30 "..\..\Views\MyProfile\Delete.cshtml"
                   Write(Resources.Resources.Employee);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                    <hr />\r\n                    <div>\r\n                   " +
"     <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n                            <dt>\r\n");

WriteLiteral("                                ");

            
            #line 35 "..\..\Views\MyProfile\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.LanguageId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n");

WriteLiteral("                                ");

            
            #line 38 "..\..\Views\MyProfile\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Language.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n");

WriteLiteral("                                ");

            
            #line 41 "..\..\Views\MyProfile\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.LoginId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n");

            
            #line 44 "..\..\Views\MyProfile\Delete.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\MyProfile\Delete.cshtml"
                                 if (@dbIdentity.Users.Find(Model.LoginId) != null)
                                {
                                    
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\MyProfile\Delete.cshtml"
                               Write(dbIdentity.Users.Find(Model.LoginId).UserName);

            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\MyProfile\Delete.cshtml"
                                                                                  
                                }
                                else
                                {
                                    
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\MyProfile\Delete.cshtml"
                               Write(Resources.Resources.NotAvailable);

            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\MyProfile\Delete.cshtml"
                                                                     
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </dd>\r\n                            <dt>\r\n");

WriteLiteral("                                ");

            
            #line 54 "..\..\Views\MyProfile\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.FullName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n");

WriteLiteral("                                ");

            
            #line 57 "..\..\Views\MyProfile\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.FullName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </dd>\r\n                        </dl>\r\n             " +
"       </div>\r\n");

            
            #line 61 "..\..\Views\MyProfile\Delete.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\MyProfile\Delete.cshtml"
                     using (Html.BeginForm())
                    {
                        
            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\MyProfile\Delete.cshtml"
                   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\MyProfile\Delete.cshtml"
                                                

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"form-actions no-color\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=", 2727), Tuple.Create("", 2761)
            
            #line 65 "..\..\Views\MyProfile\Delete.cshtml"
, Tuple.Create(Tuple.Create("", 2734), Tuple.Create<System.Object, System.Int32>(Resources.Resources.Delete
            
            #line default
            #line hidden
, 2734), false)
);

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" /> |\r\n");

WriteLiteral("                            ");

            
            #line 66 "..\..\Views\MyProfile\Delete.cshtml"
                       Write(Html.ActionLink(Resources.Resources.BackToList, "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

WriteLiteral("                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 70 "..\..\Views\MyProfile\Delete.cshtml"
                           Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");

            
            #line 73 "..\..\Views\MyProfile\Delete.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <!-- LEFT -->" +
"\r\n");

WriteLiteral("        ");

            
            #line 78 "..\..\Views\MyProfile\Delete.cshtml"
   Write(Html.Partial("_MyProfile"));

            
            #line default
            #line hidden
WriteLiteral(";\r\n    </div>\r\n</section>");

        }
    }
}
#pragma warning restore 1591
