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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Identity/Views/IdentityDepartmentTerms/Edit.cshtml")]
    public partial class _Areas_Identity_Views_IdentityDepartmentTerms_Edit_cshtml : System.Web.Mvc.WebViewPage<cutecms_porto.Areas.Identity.Models.DBModel.IdentityDepartmentTerm>
    {
        public _Areas_Identity_Views_IdentityDepartmentTerms_Edit_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
  
    ViewBag.MainTitle = Resources.Resources.Term;
    ViewBag.Title = Resources.Resources.Edit;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
 using (Html.BeginForm("Edit", "IdentityDepartmentTerms", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    
            
            #line default
            #line hidden
            
            #line 8 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 8 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
Write(Html.HiddenFor(model => model.IconPath));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
                                            
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
Write(Html.HiddenFor(model => model.ImagePath));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
                                             
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
Write(Html.HiddenFor(model => model.IconName));

            
            #line default
            #line hidden
            
            #line 11 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
                                            
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
Write(Html.HiddenFor(model => model.ImageName));

            
            #line default
            #line hidden
            
            #line 12 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
                                             

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 15 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
   Write(Html.HiddenFor(model => model.DepartmentId));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 17 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
       Write(Html.LabelFor(model => model.Department.Code, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 19 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.TextBox("DepartmentCode", null, htmlAttributes: new { @class = "form-control", @disabled = "disabled" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Department.Code, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 24 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
       Write(Html.LabelFor(model => model.LanguageId, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 26 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.DropDownList("LanguageId", null, Resources.Resources.ChooseLanguage, htmlAttributes: new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 27 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.LanguageId, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
       Write(Html.LabelFor(model => model.Value, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 33 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.EditorFor(model => model.Value, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 34 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Value, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 38 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
       Write(Html.Label(Resources.Resources.UploadIcon, new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 40 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Icon, new { @class = "form-control", type = "file", multiple = "false", placeholder = "upload files" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <small");

WriteLiteral(" class=\"text-muted block\"");

WriteLiteral(">");

            
            #line 41 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
                                           Write(Resources.Resources.IconNotes);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 46 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
       Write(Html.LabelFor(model => model.Summary, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 48 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.TextAreaFor(model => model.Summary, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 49 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Summary, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 54 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 56 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.TextAreaFor(model => model.Description, new { @class = "mceEditor" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 57 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 62 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
       Write(Html.Label(Resources.Resources.UploadImage, new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 64 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Image, new { @class = "form-control", type = "file", multiple = "false", placeholder = "upload files" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <small");

WriteLiteral(" class=\"text-muted block\"");

WriteLiteral(">");

            
            #line 65 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
                                           Write(Resources.Resources.ImageNotes);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 70 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
       Write(Html.LabelFor(model => model.Visible, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 73 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
               Write(Html.CheckBoxFor(model => model.Visible, new { @class = "js-switch" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 74 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Visible, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 80 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
       Write(Html.LabelFor(model => model.HomeVisible, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 83 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
               Write(Html.CheckBoxFor(model => model.HomeVisible, new { @class = "js-switch" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 84 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.HomeVisible, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" id=\"OrdinalDiv\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 90 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.LabelFor(model => model.Ordinal, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 93 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Ordinal, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 94 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Ordinal, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n       " +
" </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=", 5480), Tuple.Create("", 5512)
            
            #line 101 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 5487), Tuple.Create<System.Object, System.Int32>(Resources.Resources.Save
            
            #line default
            #line hidden
, 5487), false)
);

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 106 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
           Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 110 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<div>\r\n");

WriteLiteral("    ");

            
            #line 112 "..\..\Areas\Identity\Views\IdentityDepartmentTerms\Edit.cshtml"
Write(Html.ActionLink(Resources.Resources.BackToList, "Index", new { id = Model.DepartmentId }));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(document).ready(function () {
            //Uncheck the CheckBox initially
            $('#HomeVisible').change(function () {
                if (this.checked) {
                    $('#OrdinalDiv').show();
                }
                else {
                    $(""#OrdinalDiv"").hide()
                    $(""#Ordinal"").val(null);
                }
            });
            if ($('#HomeVisible').is(':checked')) {
                $(""#OrdinalDiv"").show();
            }
            else {
                $(""#OrdinalDiv"").hide();
            }
        });
    </script>
");

});

        }
    }
}
#pragma warning restore 1591
