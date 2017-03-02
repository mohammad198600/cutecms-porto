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
    
    #line 2 "..\..\Views\Error\NotFound.cshtml"
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
    
    #line 1 "..\..\Views\Error\NotFound.cshtml"
    using cutecms_porto.Areas.CMS.Models.DBModel;
    
    #line default
    #line hidden
    using cutecms_porto.Helpers;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Error/NotFound.cshtml")]
    public partial class _Views_Error_NotFound_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Error_NotFound_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Error\NotFound.cshtml"
  
    ViewBag.Title = Resources.Resources.PageNotFound;
    CMSEntities db = new CMSEntities();
    IEnumerable<MenuItem> usefulLinks = db.MenuItems.Include("Status").Include("Menu").Include("Language").Where(m => m.Menu.TenantId.Trim().Equals(Tenant.TenantId) && m.Menu.Code.Trim().Equals("useful-links") && m.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).OrderBy(o => o.Ordinal);


            
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

WriteLiteral(">\r\n                    <h1>404 - ");

            
            #line 15 "..\..\Views\Error\NotFound.cshtml"
                         Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>" +
"\r\n");

});

WriteLiteral("<section");

WriteLiteral(" class=\"page-not-found\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-6 col-md-offset-1\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"page-not-found-main\"");

WriteLiteral(">\r\n                <h2>404 <i");

WriteLiteral(" class=\"fa fa-file\"");

WriteLiteral("></i></h2>\r\n                <p>");

            
            #line 26 "..\..\Views\Error\NotFound.cshtml"
              Write(Resources.Resources.NotFound);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <a");

WriteLiteral(" class=\"size-20\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1087), Tuple.Create("\"", 1137)
, Tuple.Create(Tuple.Create("", 1094), Tuple.Create<System.Object, System.Int32>(Href("~/")
, 1094), false)
            
            #line 27 "..\..\Views\Error\NotFound.cshtml"
, Tuple.Create(Tuple.Create("", 1096), Tuple.Create<System.Object, System.Int32>(Thread.CurrentThread.CurrentCulture.Name
            
            #line default
            #line hidden
, 1096), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-menu-left\"");

WriteLiteral("></i>");

            
            #line 27 "..\..\Views\Error\NotFound.cshtml"
                                                                                                                              Write(Resources.Resources.BackToHome);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n            <h4");

WriteLiteral(" class=\"heading-primary\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Error\NotFound.cshtml"
                                   Write(Resources.Resources.UsefulLinks);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n            <ul");

WriteLiteral(" class=\"nav nav-list\"");

WriteLiteral(">\r\n");

            
            #line 33 "..\..\Views\Error\NotFound.cshtml"
                
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Error\NotFound.cshtml"
                 foreach (var item in usefulLinks)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1504), Tuple.Create("\"", 1521)
            
            #line 35 "..\..\Views\Error\NotFound.cshtml"
, Tuple.Create(Tuple.Create("", 1511), Tuple.Create<System.Object, System.Int32>(item.Path
            
            #line default
            #line hidden
, 1511), false)
);

WriteLiteral(">");

            
            #line 35 "..\..\Views\Error\NotFound.cshtml"
                                        Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 36 "..\..\Views\Error\NotFound.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
