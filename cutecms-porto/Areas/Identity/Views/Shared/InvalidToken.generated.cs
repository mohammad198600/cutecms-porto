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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Identity/Views/Shared/InvalidToken.cshtml")]
    public partial class _Areas_Identity_Views_Shared_InvalidToken_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Identity_Views_Shared_InvalidToken_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Identity\Views\Shared\InvalidToken.cshtml"
  
    ViewBag.Title = Resources.Resources.InvalidToken;
    Layout = "~/Areas/Identity/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n<h1");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(">");

            
            #line 5 "..\..\Areas\Identity\Views\Shared\InvalidToken.cshtml"
                   Write(Resources.Resources.Oops);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n<h2");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(">");

            
            #line 6 "..\..\Areas\Identity\Views\Shared\InvalidToken.cshtml"
                   Write(Resources.Resources.InvalidToken);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

        }
    }
}
#pragma warning restore 1591
