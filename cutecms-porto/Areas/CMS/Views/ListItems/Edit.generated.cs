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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/CMS/Views/ListItems/Edit.cshtml")]
    public partial class _Areas_CMS_Views_ListItems_Edit_cshtml : System.Web.Mvc.WebViewPage<cutecms_porto.Areas.CMS.Models.DBModel.ListItem>
    {
        public _Areas_CMS_Views_ListItems_Edit_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
  
    ViewBag.MainTitle = Resources.Resources.ListItem;
    ViewBag.Title = Resources.Resources.Edit;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
 using (Html.BeginForm("Edit", "ListItems", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    
            
            #line default
            #line hidden
            
            #line 8 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 8 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                                      
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
Write(Html.HiddenFor(model => model.FilePath));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                                            
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
Write(Html.HiddenFor(model => model.ThumbPath));

            
            #line default
            #line hidden
            
            #line 11 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                                             
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
Write(Html.HiddenFor(model => model.FileName));

            
            #line default
            #line hidden
            
            #line 12 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                                            
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
Write(Html.HiddenFor(model => model.ThumbName));

            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                                             
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
Write(Html.HiddenFor(model => model.ContentListId));

            
            #line default
            #line hidden
            
            #line 14 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                                                 

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 17 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
       Write(Html.LabelFor(model => model.ContentListId, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 19 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.TextBox("ContentListCode", null, htmlAttributes: new { @class = "form-control", @disabled = "disabled" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 23 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
       Write(Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 25 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 26 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
       Write(Html.LabelFor(model => model.Subtitle, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 32 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.EditorFor(model => model.Subtitle, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 33 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Subtitle, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 37 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
       Write(Html.LabelFor(model => model.Body, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 39 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.TextAreaFor(model => model.Body, new { @class = "mceEditor" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 40 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Body, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 44 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
       Write(Html.LabelFor(model => model.Url, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 46 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.EditorFor(model => model.Url, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 47 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Url, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
       Write(Html.LabelFor(model => model.Class, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 53 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.EditorFor(model => model.Class, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 54 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Class, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 58 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
       Write(Html.LabelFor(model => model.Visible, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 60 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.CheckBoxFor(model => model.Visible, new { @class = "js-switch" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 61 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Visible, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 65 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
       Write(Html.LabelFor(model => model.Ordinal, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 67 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.EditorFor(model => model.Ordinal, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 68 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Ordinal, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 72 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
       Write(Html.LabelFor(model => model.File, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 74 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.File, new { @class = "form-control", type = "file", multiple = "false", placeholder = "upload files" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 75 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 75 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                 if (Model.FilePath != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4363), Tuple.Create("\"", 4398)
            
            #line 77 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 4370), Tuple.Create<System.Object, System.Int32>(Url.Content(Model.FilePath)
            
            #line default
            #line hidden
, 4370), false)
);

WriteLiteral(" style=\"color:dodgerblue\"");

WriteLiteral(">");

            
            #line 77 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                                                                               Write(Resources.Resources.View);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 78 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 79 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.File, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 83 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
       Write(Html.LabelFor(model => model.Thumb, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 85 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Thumb, new { @class = "form-control", type = "file", multiple = "false", placeholder = "upload files" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 86 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 86 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                 if (Model.ThumbPath != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5034), Tuple.Create("\"", 5070)
            
            #line 88 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 5041), Tuple.Create<System.Object, System.Int32>(Url.Content(Model.ThumbPath)
            
            #line default
            #line hidden
, 5041), false)
);

WriteLiteral(">");

            
            #line 88 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                                                       Write(Resources.Resources.View);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 89 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 90 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Thumb, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 94 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
       Write(Html.Label(Resources.Resources.Dimensions, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 96 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.TextBox("width", null, new { @placeholder = @Resources.Resources.Width }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 97 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.TextBox("height", null, new { @placeholder = @Resources.Resources.Height }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5802), Tuple.Create("\"", 5835)
            
            #line 102 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 5810), Tuple.Create<System.Object, System.Int32>(Resources.Resources.Save
            
            #line default
            #line hidden
, 5810), false)
);

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 107 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
           Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 111 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<div>\r\n");

WriteLiteral("    ");

            
            #line 113 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
Write(Html.ActionLink(Resources.Resources.BackToList, "Index", new { id = Model.ContentListId }));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 116 "..\..\Areas\CMS\Views\ListItems\Edit.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
