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
    
    #line 4 "..\..\Views\Shared\_MyProfile.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 3 "..\..\Views\Shared\_MyProfile.cshtml"
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
    
    #line 1 "..\..\Views\Shared\_MyProfile.cshtml"
    using cutecms_porto.Areas.Identity.Models.DBModel;
    
    #line default
    #line hidden
    using cutecms_porto.Helpers;
    
    #line 2 "..\..\Views\Shared\_MyProfile.cshtml"
    using Microsoft.AspNet.Identity;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_MyProfile.cshtml")]
    public partial class _Views_Shared__MyProfile_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        
        #line 74 "..\..\Views\Shared\_MyProfile.cshtml"
           
    public int ProfileCompletion(Employee emp)
    {
        var percentage = 100;
        List<string> values = new List<string>();
        var properties = emp.GetType().GetProperties().Where(p => !p.GetGetMethod().IsVirtual && p.Name != "Id" && p.Name != "LoginId" && p.Name != "Image" && p.Name != "File" && p.Name != "Mobile" && p.Name != "MiddleName" && p.Name != "MiddleName_Ar" && p.Name != "FacebookUrl" && p.Name != "TwitterUrl" && p.Name != "YouTubeUrl" && p.Name != "GooglePlusUrl" && p.Name != "LinkedInUrl" && p.Name != "Ordinal");
        foreach (PropertyInfo propInfo in properties)
        {
            if (propInfo.GetValue(emp, null) == null)
            {
                values.Add("NULL");
            }
            else
            {
                values.Add(propInfo.GetValue(emp, null).ToString());
            }
        }
        var nullValues = values.Where(nv => nv.Contains("NULL")).Count();
        var realValues = values.Where(rv => !rv.Contains("NULL")).Count();
        var allValues = values.Count();
        percentage = (realValues * 100) / allValues;
        return percentage;
    }

        #line default
        #line hidden
        
        public _Views_Shared__MyProfile_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Shared\_MyProfile.cshtml"
  
    var loginId = User.Identity.GetUserId();
    IdentityEntities db = new IdentityEntities();
    var employee = db.Employees.Where(e => e.LoginId.Equals(loginId) && e.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).FirstOrDefault();

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\Shared\_MyProfile.cshtml"
 if (employee != null)
{
    var percentage = ProfileCompletion(employee);

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"col-lg-3 col-md-3 col-sm-4 col-lg-pull-9 col-md-pull-9 col-sm-pull-8\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"thumbnail text-center\"");

WriteLiteral(">\r\n");

            
            #line 15 "..\..\Views\Shared\_MyProfile.cshtml"
            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Shared\_MyProfile.cshtml"
             if (employee != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <img");

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral(" alt=\"\"");

WriteAttribute("src", Tuple.Create(" src=\"", 726), Tuple.Create("\"", 874)
            
            #line 17 "..\..\Views\Shared\_MyProfile.cshtml"
, Tuple.Create(Tuple.Create("", 732), Tuple.Create<System.Object, System.Int32>(!File.Exists(Server.MapPath(employee?.PersonalPhotoPath)) ? "/assets/admin/plugins/images/users/user-icon.png" : employee.PersonalPhotoPath
            
            #line default
            #line hidden
, 732), false)
);

WriteLiteral(">\r\n");

            
            #line 18 "..\..\Views\Shared\_MyProfile.cshtml"
                string personalTitle = (employee.PersonalTitle.PersonalTitleTerms.Where(p => p.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).FirstOrDefault() != null) ? employee.PersonalTitle.PersonalTitleTerms.Where(p => p.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).FirstOrDefault().Value : employee.PersonalTitle.Code;

            
            #line default
            #line hidden
WriteLiteral("                <h4>");

            
            #line 19 "..\..\Views\Shared\_MyProfile.cshtml"
               Write(personalTitle);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 19 "..\..\Views\Shared\_MyProfile.cshtml"
                              Write(employee.FullName);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");

            
            #line 20 "..\..\Views\Shared\_MyProfile.cshtml"
                foreach (var item in employee.EmpInDepts)
                {
                    string occupation = item.Occupation.OccupationTerms.Where(p => p.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).FirstOrDefault()?.Value ?? item.Occupation.Code;
                    string department = item.Department.DepartmentTerms.Where(p => p.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).FirstOrDefault()?.Value ?? item.Department.Code;

            
            #line default
            #line hidden
WriteLiteral("                    <h5");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\Shared\_MyProfile.cshtml"
                                      Write(occupation);

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n");

WriteLiteral("                    <h6");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Shared\_MyProfile.cshtml"
                                      Write(department);

            
            #line default
            #line hidden
WriteLiteral("</h6>\r\n");

WriteLiteral("                    <hr />\r\n");

            
            #line 27 "..\..\Views\Shared\_MyProfile.cshtml"
                }
                if (employee.Publications.Count() != 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"counters\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"counter\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" style=\"font-weight:600\"");

WriteLiteral(" data-to=\"");

            
            #line 32 "..\..\Views\Shared\_MyProfile.cshtml"
                                                               Write(employee.Publications.Count());

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-append=\"+\"");

WriteLiteral(">0</label>\r\n                            <label>");

            
            #line 33 "..\..\Views\Shared\_MyProfile.cshtml"
                              Write(Resources.Resources.RnC);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 36 "..\..\Views\Shared\_MyProfile.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                            <!-- completed -->\r\n");

WriteLiteral("                <div>\r\n\r\n                    <label>");

            
            #line 40 "..\..\Views\Shared\_MyProfile.cshtml"
                      Write(percentage);

            
            #line default
            #line hidden
WriteLiteral("% ");

            
            #line 40 "..\..\Views\Shared\_MyProfile.cshtml"
                                   Write(Resources.Resources.CompletedProfile);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <div");

WriteLiteral(" class=\"progress\"");

WriteLiteral(">\r\n");

            
            #line 42 "..\..\Views\Shared\_MyProfile.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\Shared\_MyProfile.cshtml"
                         if (percentage <= 50)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"progress-bar progress-bar-danger\"");

WriteLiteral(" role=\"progressbar\"");

WriteAttribute("aria-valuenow", Tuple.Create(" aria-valuenow=\"", 2813), Tuple.Create("\"", 2840)
            
            #line 44 "..\..\Views\Shared\_MyProfile.cshtml"
                            , Tuple.Create(Tuple.Create("", 2829), Tuple.Create<System.Object, System.Int32>(percentage
            
            #line default
            #line hidden
, 2829), false)
);

WriteLiteral(" aria-valuemin=\"0\"");

WriteLiteral(" aria-valuemax=\"100\"");

WriteAttribute("style", Tuple.Create(" style=\"", 2879), Tuple.Create("\"", 2908)
, Tuple.Create(Tuple.Create("", 2887), Tuple.Create("width:", 2887), true)
            
            #line 44 "..\..\Views\Shared\_MyProfile.cshtml"
                                                                                            , Tuple.Create(Tuple.Create(" ", 2893), Tuple.Create<System.Object, System.Int32>(percentage
            
            #line default
            #line hidden
, 2894), false)
, Tuple.Create(Tuple.Create("", 2905), Tuple.Create("%;", 2905), true)
, Tuple.Create(Tuple.Create(" ", 2907), Tuple.Create("", 2907), true)
);

WriteLiteral("></div>\r\n");

            
            #line 45 "..\..\Views\Shared\_MyProfile.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 46 "..\..\Views\Shared\_MyProfile.cshtml"
                         if (percentage > 50 && percentage < 75)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"progress-bar progress-bar-warning\"");

WriteLiteral(" role=\"progressbar\"");

WriteAttribute("aria-valuenow", Tuple.Create(" aria-valuenow=\"", 3131), Tuple.Create("\"", 3158)
            
            #line 48 "..\..\Views\Shared\_MyProfile.cshtml"
                             , Tuple.Create(Tuple.Create("", 3147), Tuple.Create<System.Object, System.Int32>(percentage
            
            #line default
            #line hidden
, 3147), false)
);

WriteLiteral(" aria-valuemin=\"0\"");

WriteLiteral(" aria-valuemax=\"100\"");

WriteAttribute("style", Tuple.Create(" style=\"", 3197), Tuple.Create("\"", 3226)
, Tuple.Create(Tuple.Create("", 3205), Tuple.Create("width:", 3205), true)
            
            #line 48 "..\..\Views\Shared\_MyProfile.cshtml"
                                                                                             , Tuple.Create(Tuple.Create(" ", 3211), Tuple.Create<System.Object, System.Int32>(percentage
            
            #line default
            #line hidden
, 3212), false)
, Tuple.Create(Tuple.Create("", 3223), Tuple.Create("%;", 3223), true)
, Tuple.Create(Tuple.Create(" ", 3225), Tuple.Create("", 3225), true)
);

WriteLiteral("></div>\r\n");

            
            #line 49 "..\..\Views\Shared\_MyProfile.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 50 "..\..\Views\Shared\_MyProfile.cshtml"
                         if (percentage >= 75)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"progress-bar progress-bar-success\"");

WriteLiteral(" role=\"progressbar\"");

WriteAttribute("aria-valuenow", Tuple.Create(" aria-valuenow=\"", 3431), Tuple.Create("\"", 3458)
            
            #line 52 "..\..\Views\Shared\_MyProfile.cshtml"
                             , Tuple.Create(Tuple.Create("", 3447), Tuple.Create<System.Object, System.Int32>(percentage
            
            #line default
            #line hidden
, 3447), false)
);

WriteLiteral(" aria-valuemin=\"0\"");

WriteLiteral(" aria-valuemax=\"100\"");

WriteAttribute("style", Tuple.Create(" style=\"", 3497), Tuple.Create("\"", 3526)
, Tuple.Create(Tuple.Create("", 3505), Tuple.Create("width:", 3505), true)
            
            #line 52 "..\..\Views\Shared\_MyProfile.cshtml"
                                                                                             , Tuple.Create(Tuple.Create(" ", 3511), Tuple.Create<System.Object, System.Int32>(percentage
            
            #line default
            #line hidden
, 3512), false)
, Tuple.Create(Tuple.Create("", 3523), Tuple.Create("%;", 3523), true)
, Tuple.Create(Tuple.Create(" ", 3525), Tuple.Create("", 3525), true)
);

WriteLiteral("></div>\r\n");

            
            #line 53 "..\..\Views\Shared\_MyProfile.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                </div>\r\n");

WriteLiteral("        <!-- /completed -->\r\n");

            
            #line 57 "..\..\Views\Shared\_MyProfile.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <img");

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" src=\"/assets/admin/plugins/images/users/user-icon.png\"");

WriteLiteral(">\r\n");

            
            #line 61 "..\..\Views\Shared\_MyProfile.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <!-- SIDE NAV -->\r\n        <ul");

WriteLiteral(" class=\"list list-icons list-icons-style-3 mt-xlg\"");

WriteLiteral(" id=\"sidebar-nav\"");

WriteLiteral(">\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=", 3957), Tuple.Create("", 3996)
            
            #line 65 "..\..\Views\Shared\_MyProfile.cshtml"
, Tuple.Create(Tuple.Create("", 3963), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "MyProfile")
            
            #line default
            #line hidden
, 3963), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i><span");

WriteLiteral(" class=\"uppercase\"");

WriteLiteral(">");

            
            #line 65 "..\..\Views\Shared\_MyProfile.cshtml"
                                                                                                       Write(Resources.Resources.MyProfile);

            
            #line default
            #line hidden
WriteLiteral("</span></a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=", 4113), Tuple.Create("", 4192)
            
            #line 66 "..\..\Views\Shared\_MyProfile.cshtml"
, Tuple.Create(Tuple.Create("", 4119), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Publications", new { id = employee.TranslationId })
            
            #line default
            #line hidden
, 4119), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-file-text\"");

WriteLiteral("></i><span");

WriteLiteral(" class=\"uppercase\"");

WriteLiteral(">");

            
            #line 66 "..\..\Views\Shared\_MyProfile.cshtml"
                                                                                                                                                    Write(Resources.Resources.Publications);

            
            #line default
            #line hidden
WriteLiteral("</span></a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=", 4317), Tuple.Create("", 4394)
            
            #line 67 "..\..\Views\Shared\_MyProfile.cshtml"
, Tuple.Create(Tuple.Create("", 4323), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "EmpInDepts", new { id = employee.TranslationId })
            
            #line default
            #line hidden
, 4323), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-building\"");

WriteLiteral("></i><span");

WriteLiteral(" class=\"uppercase\"");

WriteLiteral(">");

            
            #line 67 "..\..\Views\Shared\_MyProfile.cshtml"
                                                                                                                                                 Write(Resources.Resources.Departments);

            
            #line default
            #line hidden
WriteLiteral("</span></a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=", 4517), Tuple.Create("", 4599)
            
            #line 68 "..\..\Views\Shared\_MyProfile.cshtml"
, Tuple.Create(Tuple.Create("", 4523), Tuple.Create<System.Object, System.Int32>(Url.Action("Translations", "MyProfile", new { id = employee.TranslationId})
            
            #line default
            #line hidden
, 4523), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-globe\"");

WriteLiteral("></i><span");

WriteLiteral(" class=\"uppercase\"");

WriteLiteral(">");

            
            #line 68 "..\..\Views\Shared\_MyProfile.cshtml"
                                                                                                                                                   Write(Resources.Resources.Translations);

            
            #line default
            #line hidden
WriteLiteral("</span></a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=", 4720), Tuple.Create("", 4783)
            
            #line 69 "..\..\Views\Shared\_MyProfile.cshtml"
, Tuple.Create(Tuple.Create("", 4726), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Manage", new { area = "Identity" })
            
            #line default
            #line hidden
, 4726), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-gears\"");

WriteLiteral("></i><span");

WriteLiteral(" class=\"uppercase\"");

WriteLiteral(">");

            
            #line 69 "..\..\Views\Shared\_MyProfile.cshtml"
                                                                                                                                Write(Resources.Resources.AccountSettings);

            
            #line default
            #line hidden
WriteLiteral("</span></a></li>\r\n        </ul>\r\n\r\n    </div>\r\n");

            
            #line 73 "..\..\Views\Shared\_MyProfile.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
