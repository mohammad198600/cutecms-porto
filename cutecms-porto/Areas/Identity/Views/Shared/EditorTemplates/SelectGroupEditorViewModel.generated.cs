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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Identity/Views/Shared/EditorTemplates/SelectGroupEditorViewModel.cshtml")]
    public partial class _Areas_Identity_Views_Shared_EditorTemplates_SelectGroupEditorViewModel_cshtml_ : System.Web.Mvc.WebViewPage<cutecms_porto.Areas.Identity.Models.SelectGroupEditorViewModel>
    {
        public _Areas_Identity_Views_Shared_EditorTemplates_SelectGroupEditorViewModel_cshtml_()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Identity\Views\Shared\EditorTemplates\SelectGroupEditorViewModel.cshtml"
Write(Html.HiddenFor(model => model.GroupId));

            
            #line default
            #line hidden
WriteLiteral("\r\n<tr>\r\n    <td>\r\n");

WriteLiteral("        ");

            
            #line 5 "..\..\Areas\Identity\Views\Shared\EditorTemplates\SelectGroupEditorViewModel.cshtml"
   Write(Html.CheckBoxFor(model => model.Selected, new { @class = "js-switch" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        &nbsp;\r\n    </td>\r\n    <td>\r\n");

WriteLiteral("        ");

            
            #line 9 "..\..\Areas\Identity\Views\Shared\EditorTemplates\SelectGroupEditorViewModel.cshtml"
   Write(Html.DisplayFor(model => model.GroupName));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n</tr>\r\n");

        }
    }
}
#pragma warning restore 1591
