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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MyProfile/AcademicInfo.cshtml")]
    public partial class _Views_MyProfile_AcademicInfo_cshtml : System.Web.Mvc.WebViewPage<cutecms_porto.Areas.Identity.Models.DBModel.Employee>
    {
        public _Views_MyProfile_AcademicInfo_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!-- PERSONAL INFO TAB -->\r\n");

            
            #line 4 "..\..\Views\MyProfile\AcademicInfo.cshtml"
 using (Html.BeginForm("Manage", "MyProfile", FormMethod.Post))
{
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\MyProfile\AcademicInfo.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                            

    if (Model != null)
    {
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                          
        
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.LoginId));

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                               

        
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                          
        
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.LoginId));

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                               
        
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.LanguageId));

            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                  
        
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.PersonalTitleId));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                       
        
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.FirstName));

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                 
        
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.MiddleName));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                  
        
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.LastName));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                

        
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.PersonalPhotoPath));

            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                         
        
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.PersonalPhotoName));

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                         

        
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.Biography));

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                 
        
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.ResumeFilePath));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                      
        
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.ResumeFileName));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                      

        
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.OfficeNumber));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                    
        
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.Mobile));

            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                              
        
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.LandLine));

            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                
        
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.Extension));

            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                 
        
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.FacebookUrl));

            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                   
        
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.TwitterUrl));

            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                  
        
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.YouTubeUrl));

            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                  
        
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.GooglePlusUrl));

            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                     
        
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.LinkedInUrl));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                   

        
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\MyProfile\AcademicInfo.cshtml"
   Write(Html.HiddenFor(model => model.TranslationId));

            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                     
    }


            
            #line default
            #line hidden
WriteLiteral("    <form");

WriteLiteral(" role=\"form\"");

WriteLiteral(" action=\"#\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 43 "..\..\Views\MyProfile\AcademicInfo.cshtml"
       Write(Html.LabelFor(model => model.RankId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 44 "..\..\Views\MyProfile\AcademicInfo.cshtml"
       Write(Html.DropDownList("RankId", null, string.Empty, htmlAttributes: new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 45 "..\..\Views\MyProfile\AcademicInfo.cshtml"
       Write(Html.ValidationMessageFor(model => model.RankId, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 48 "..\..\Views\MyProfile\AcademicInfo.cshtml"
       Write(Html.LabelFor(model => model.DegreeId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 49 "..\..\Views\MyProfile\AcademicInfo.cshtml"
       Write(Html.DropDownList("DegreeId", null, string.Empty, htmlAttributes: new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 50 "..\..\Views\MyProfile\AcademicInfo.cshtml"
       Write(Html.ValidationMessageFor(model => model.DegreeId, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 53 "..\..\Views\MyProfile\AcademicInfo.cshtml"
       Write(Html.LabelFor(model => model.ProgramId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 54 "..\..\Views\MyProfile\AcademicInfo.cshtml"
       Write(Html.DropDownList("ProgramId", null, string.Empty, htmlAttributes: new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 55 "..\..\Views\MyProfile\AcademicInfo.cshtml"
       Write(Html.ValidationMessageFor(model => model.ProgramId, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"margiv-top10\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"submit\"");

WriteLiteral(" value=\"AcademicInfo\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 58 "..\..\Views\MyProfile\AcademicInfo.cshtml"
                                                                                        Write(Resources.Resources.Save);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <br />\r\n");

WriteLiteral("            ");

            
            #line 62 "..\..\Views\MyProfile\AcademicInfo.cshtml"
       Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </form>\r\n");

            
            #line 65 "..\..\Views\MyProfile\AcademicInfo.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
