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
    
    #line 3 "..\..\Views\Staff\Search.cshtml"
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
    
    #line 2 "..\..\Views\Staff\Search.cshtml"
    using cutecms_porto.Areas.Identity.Models.DBModel;
    
    #line default
    #line hidden
    using cutecms_porto.Helpers;
    
    #line 5 "..\..\Views\Staff\Search.cshtml"
    using PagedList;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Staff\Search.cshtml"
    using PagedList.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Staff/Search.cshtml")]
    public partial class _Views_Staff_Search_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<Employee>>
    {
        public _Views_Staff_Search_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\Staff\Search.cshtml"
  
    ViewBag.Title = Resources.Resources.SearchResult;
    IdentityEntities db = new IdentityEntities();

            
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

            
            #line 16 "..\..\Views\Staff\Search.cshtml"
                   Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>" +
"\r\n");

});

WriteLiteral("<section>\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n");

            
            #line 24 "..\..\Views\Staff\Search.cshtml"
        
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Staff\Search.cshtml"
         if (Model.Count() > 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"team-list sort-destination\"");

WriteLiteral(">\r\n");

            
            #line 28 "..\..\Views\Staff\Search.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Staff\Search.cshtml"
                     foreach (var item in Model)
                    {
                        var empInDepts = db.EmpInDepts.Where(e => e.Department.TenantId.Equals(Tenant.TenantId) && e.EmpId == item.TranslationId);
                        string personalTitle = item.PersonalTitle.PersonalTitleTerms.Where(p => p.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).FirstOrDefault()?.Value ?? item.PersonalTitle.Code;

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" class=\"col-md-3 col-sm-6 isotope-item\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"thumb-info thumb-info-hide-wrapper-bg mb-xlg\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"thumb-info-wrapper\"");

WriteLiteral(">\r\n                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1420), Tuple.Create("\"", 1477)
            
            #line 35 "..\..\Views\Staff\Search.cshtml"
, Tuple.Create(Tuple.Create("", 1427), Tuple.Create<System.Object, System.Int32>(Url.Action("MemberProfile", new { id = item.Id })
            
            #line default
            #line hidden
, 1427), false)
);

WriteLiteral(">\r\n                                    <img");

WriteAttribute("alt", Tuple.Create(" alt=\"", 1521), Tuple.Create("\"", 1550)
            
            #line 36 "..\..\Views\Staff\Search.cshtml"
, Tuple.Create(Tuple.Create("", 1527), Tuple.Create<System.Object, System.Int32>(item.PersonalPhotoName
            
            #line default
            #line hidden
, 1527), false)
);

WriteAttribute("src", Tuple.Create(" src=\"", 1551), Tuple.Create("\"", 1690)
            
            #line 36 "..\..\Views\Staff\Search.cshtml"
, Tuple.Create(Tuple.Create("", 1557), Tuple.Create<System.Object, System.Int32>(!File.Exists(Server.MapPath(item.PersonalPhotoPath)) ? "/assets/admin/plugins/images/users/user-icon.png" : item.PersonalPhotoPath
            
            #line default
            #line hidden
, 1557), false)
);

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"thumb-info-title\"");

WriteLiteral(">\r\n                                        <span");

WriteLiteral(" class=\"thumb-info-inner\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Staff\Search.cshtml"
                                                                  Write(personalTitle);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 38 "..\..\Views\Staff\Search.cshtml"
                                                                                 Write(item.FullName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 39 "..\..\Views\Staff\Search.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Staff\Search.cshtml"
                                         foreach (var empInDept1 in empInDepts)
                                            {
                                                string occupation = empInDept1.Occupation.OccupationTerms.Where(p => p.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).FirstOrDefault()?.Value ?? empInDept1.Occupation.Code;
                                                string department = empInDept1.Department.DepartmentTerms.Where(p => p.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).FirstOrDefault()?.Value ?? empInDept1.Department.Code;

            
            #line default
            #line hidden
WriteLiteral("                                            <span");

WriteLiteral(" class=\"thumb-info-type\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Staff\Search.cshtml"
                                                                     Write(occupation);

            
            #line default
            #line hidden
WriteLiteral(" &#64; ");

            
            #line 43 "..\..\Views\Staff\Search.cshtml"
                                                                                       Write(department);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 44 "..\..\Views\Staff\Search.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                    </span>\r\n                                </a>" +
"\r\n                            </span>\r\n                            <span");

WriteLiteral(" class=\"thumb-info-caption\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"thumb-info-caption-text text-justify\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 50 "..\..\Views\Staff\Search.cshtml"
                               Write(Html.Raw(item.Biography.StripHtml().Chop(100)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <a");

WriteLiteral(" class=\"btn btn-xs\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3075), Tuple.Create("\"", 3132)
            
            #line 51 "..\..\Views\Staff\Search.cshtml"
, Tuple.Create(Tuple.Create("", 3082), Tuple.Create<System.Object, System.Int32>(Url.Action("MemberProfile", new { id = item.Id })
            
            #line default
            #line hidden
, 3082), false)
);

WriteLiteral(">");

            
            #line 51 "..\..\Views\Staff\Search.cshtml"
                                                                                                               Write(Resources.Resources.ReadMore);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                                </span>\r\n                                <s" +
"pan");

WriteLiteral(" class=\"thumb-info-social-icons center\"");

WriteLiteral(">\r\n");

            
            #line 54 "..\..\Views\Staff\Search.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Staff\Search.cshtml"
                                     if (!string.IsNullOrEmpty(item.FacebookUrl))
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        <a");

WriteLiteral(" target=\"_blank\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3473), Tuple.Create("\"", 3497)
            
            #line 56 "..\..\Views\Staff\Search.cshtml"
, Tuple.Create(Tuple.Create("", 3480), Tuple.Create<System.Object, System.Int32>(item.FacebookUrl
            
            #line default
            #line hidden
, 3480), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-facebook\"");

WriteLiteral("></i><span>Facebook</span></a>\r\n");

            
            #line 57 "..\..\Views\Staff\Search.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 59 "..\..\Views\Staff\Search.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Staff\Search.cshtml"
                                     if (!string.IsNullOrEmpty(item.TwitterUrl))
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        <a");

WriteLiteral(" target=\"_blank\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3784), Tuple.Create("\"", 3807)
            
            #line 61 "..\..\Views\Staff\Search.cshtml"
, Tuple.Create(Tuple.Create("", 3791), Tuple.Create<System.Object, System.Int32>(item.TwitterUrl
            
            #line default
            #line hidden
, 3791), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-twitter\"");

WriteLiteral("></i><span>Twitter</span></a>\r\n");

            
            #line 62 "..\..\Views\Staff\Search.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    ");

            
            #line 63 "..\..\Views\Staff\Search.cshtml"
                                     if (!string.IsNullOrEmpty(@item.LinkedInUrl))
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        <a");

WriteLiteral(" target=\"_blank\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4092), Tuple.Create("\"", 4116)
            
            #line 65 "..\..\Views\Staff\Search.cshtml"
, Tuple.Create(Tuple.Create("", 4099), Tuple.Create<System.Object, System.Int32>(item.LinkedInUrl
            
            #line default
            #line hidden
, 4099), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-linkedin\"");

WriteLiteral("></i><span>Linkedin</span></a>\r\n");

            
            #line 66 "..\..\Views\Staff\Search.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    ");

            
            #line 67 "..\..\Views\Staff\Search.cshtml"
                                     if (!string.IsNullOrEmpty(@item.GooglePlusUrl))
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        <a");

WriteLiteral(" target=\"_blank\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4405), Tuple.Create("\"", 4431)
            
            #line 69 "..\..\Views\Staff\Search.cshtml"
, Tuple.Create(Tuple.Create("", 4412), Tuple.Create<System.Object, System.Int32>(item.GooglePlusUrl
            
            #line default
            #line hidden
, 4412), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-google-plus\"");

WriteLiteral("></i><span>Google Plus</span></a>\r\n");

            
            #line 70 "..\..\Views\Staff\Search.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    ");

            
            #line 71 "..\..\Views\Staff\Search.cshtml"
                                     if (!string.IsNullOrEmpty(@item.YouTubeUrl))
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        <a");

WriteLiteral(" target=\"_blank\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4723), Tuple.Create("\"", 4746)
            
            #line 73 "..\..\Views\Staff\Search.cshtml"
, Tuple.Create(Tuple.Create("", 4730), Tuple.Create<System.Object, System.Int32>(item.YouTubeUrl
            
            #line default
            #line hidden
, 4730), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-youtube\"");

WriteLiteral("></i><span>YouTube</span></a>\r\n");

            
            #line 74 "..\..\Views\Staff\Search.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                </span>\r\n                            </span>\r\n   " +
"                     </span>\r\n                    </li>\r\n");

            
            #line 79 "..\..\Views\Staff\Search.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </ul>\r\n\r\n            </div>\r\n");

            
            #line 83 "..\..\Views\Staff\Search.cshtml"
            
            
            #line default
            #line hidden
            
            #line 83 "..\..\Views\Staff\Search.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Search", new { page, empName = ViewBag.EmpName, empTypeId = ViewBag.EmpTypeId })));

            
            #line default
            #line hidden
            
            #line 83 "..\..\Views\Staff\Search.cshtml"
                                                                                                                                                         
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                <p");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(">");

            
            #line 88 "..\..\Views\Staff\Search.cshtml"
                                  Write(Resources.Resources.NoResult);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <br />\r\n            </div>\r\n");

            
            #line 91 "..\..\Views\Staff\Search.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div>\r\n            <a");

WriteLiteral(" class=\"text-blue\"");

WriteAttribute("href", Tuple.Create(" href=", 5458), Tuple.Create("", 5484)
            
            #line 93 "..\..\Views\Staff\Search.cshtml"
, Tuple.Create(Tuple.Create("", 5464), Tuple.Create<System.Object, System.Int32>(Url.Action("Index")
            
            #line default
            #line hidden
, 5464), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-menu-left margin-right-10 size-16\"");

WriteLiteral("></i>");

            
            #line 93 "..\..\Views\Staff\Search.cshtml"
                                                                                                                           Write(Resources.Resources.Back);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n</section>");

        }
    }
}
#pragma warning restore 1591
