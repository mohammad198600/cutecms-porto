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
    
    #line 2 "..\..\Views\Staff\Biography.cshtml"
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
    using cutecms_porto.Helpers;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Staff/Biography.cshtml")]
    public partial class _Views_Staff_Biography_cshtml : System.Web.Mvc.WebViewPage<cutecms_porto.Areas.Identity.Models.DBModel.Employee>
    {
        public _Views_Staff_Biography_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<form");

WriteLiteral(" role=\"form\"");

WriteLiteral(" action=\"#\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 5 "..\..\Views\Staff\Biography.cshtml"
   Write(Html.ActionLink(Resources.Resources.ViewCV, "Download", new { FilePath = Model.ResumeFilePath, FileName = Model.ResumeFileName }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 8 "..\..\Views\Staff\Biography.cshtml"
   Write(Html.Label(Resources.Resources.Biography));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 9 "..\..\Views\Staff\Biography.cshtml"
   Write(Html.Raw(Model.Biography));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</form>");

        }
    }
}
#pragma warning restore 1591
