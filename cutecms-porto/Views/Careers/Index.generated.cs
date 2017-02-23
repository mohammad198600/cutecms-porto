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
    
    #line 3 "..\..\Views\Careers\Index.cshtml"
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
    
    #line 2 "..\..\Views\Careers\Index.cshtml"
    using cutecms_porto.Areas.RMS.Models.DBModel;
    
    #line default
    #line hidden
    using cutecms_porto.Helpers;
    
    #line 5 "..\..\Views\Careers\Index.cshtml"
    using PagedList;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Careers\Index.cshtml"
    using PagedList.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Careers/Index.cshtml")]
    public partial class _Views_Careers_Index_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<Vacancy>>
    {
        public _Views_Careers_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\Careers\Index.cshtml"
  
    ViewBag.Title = Resources.Resources.Careers;
    RMSEntities db = new RMSEntities();

            
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

            
            #line 16 "..\..\Views\Careers\Index.cshtml"
                   Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>" +
"\r\n");

});

WriteLiteral("<section");

WriteLiteral(" class=\"justify\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <!-- LEFT COLUMNS -->\r\n            <div");

WriteLiteral(" class=\"col-md-9 col-sm-9 col-md-push-3 col-sm-push-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"toggle toggle-primary\"");

WriteLiteral(" data-plugin-toggle");

WriteLiteral(" data-plugin-options=\"{ \'isAccordion\': true }\"");

WriteLiteral(">\r\n");

            
            #line 28 "..\..\Views\Careers\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Careers\Index.cshtml"
                     foreach (var item in Model)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <section");

WriteLiteral(" class=\"toggle\"");

WriteLiteral(">\r\n                            <label>");

            
            #line 31 "..\..\Views\Careers\Index.cshtml"
                              Write(item.Title.Trim());

            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"pull-right mr-md\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Careers\Index.cshtml"
                                                                                Write(item.Available);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 31 "..\..\Views\Careers\Index.cshtml"
                                                                                                Write(Resources.Resources.Available);

            
            #line default
            #line hidden
WriteLiteral("</span> </label>\r\n                            <div");

WriteLiteral(" class=\"toggle-content\"");

WriteLiteral(">\r\n                                <p><strong>");

            
            #line 33 "..\..\Views\Careers\Index.cshtml"
                                      Write(Resources.Resources.Code);

            
            #line default
            #line hidden
WriteLiteral(":</strong> ");

            
            #line 33 "..\..\Views\Careers\Index.cshtml"
                                                                          Write(item.Code);

            
            #line default
            #line hidden
WriteLiteral(" - <strong>");

            
            #line 33 "..\..\Views\Careers\Index.cshtml"
                                                                                               Write(Resources.Resources.Department);

            
            #line default
            #line hidden
WriteLiteral(":</strong> ");

            
            #line 33 "..\..\Views\Careers\Index.cshtml"
                                                                                                                                          Write(item.Department.DepartmentTerms.Where(p => p.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).FirstOrDefault()?.Value ?? item.Code);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <p>");

            
            #line 34 "..\..\Views\Careers\Index.cshtml"
                              Write(Html.Raw(HttpUtility.HtmlDecode(item.Description.StripHtml())));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <p><a");

WriteLiteral(" class=\"btn btn-primary mb-xl\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1649), Tuple.Create("\"", 1711)
            
            #line 35 "..\..\Views\Careers\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1656), Tuple.Create<System.Object, System.Int32>(Url.Action("Details", "Careers", new { id = item.Id })
            
            #line default
            #line hidden
, 1656), false)
);

WriteLiteral(">");

            
            #line 35 "..\..\Views\Careers\Index.cshtml"
                                                                                                                              Write(Resources.Resources.Apply);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n                            </div>\r\n                        </section>\r" +
"\n");

            
            #line 38 "..\..\Views\Careers\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n");

WriteLiteral("                ");

            
            #line 40 "..\..\Views\Careers\Index.cshtml"
           Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page, keywordFilter = ViewBag.KeywordFilter, deptIdFilter = ViewBag.DeptId, jobTypeIdFilter = ViewBag.JobTypeId, statusIdFilter = ViewBag.StatusId })));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <!-- /LEFT COLUMNS -->\r\n            <!-- RIGHT " +
"COLUMNS -->\r\n            <div");

WriteLiteral(" class=\"col-md-3 col-sm-3 col-md-pull-9 col-sm-pull-9\"");

WriteLiteral(">\r\n                <h4>");

            
            #line 45 "..\..\Views\Careers\Index.cshtml"
               Write(Resources.Resources.Search);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");

            
            #line 46 "..\..\Views\Careers\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Careers\Index.cshtml"
                 using (Html.BeginForm("Index", "Careers", FormMethod.Post))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 51 "..\..\Views\Careers\Index.cshtml"
                           Write(Html.TextBox("keywordFilter", ViewBag.KeywordFilter as string, new { @class = "form-control", @placeholder = Resources.Resources.Keywords }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"             <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 56 "..\..\Views\Careers\Index.cshtml"
                           Write(Html.DropDownList("deptIdFilter", new SelectList(ViewBag.DeptIdFilter, "Value", "Text"), Resources.Resources.ChooseDepartment, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"             <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 61 "..\..\Views\Careers\Index.cshtml"
                           Write(Html.DropDownList("jobTypeIdFilter", new SelectList(ViewBag.JobTypeIdFilter, "Value", "Text"), Resources.Resources.ChooseJobType, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"             <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 66 "..\..\Views\Careers\Index.cshtml"
                           Write(Html.DropDownList("statusIdFilter", new SelectList(ViewBag.StatusIdFilter, "Value", "Text"), Resources.Resources.ChooseStatus, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"             <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4076), Tuple.Create("\"", 4111)
            
            #line 71 "..\..\Views\Careers\Index.cshtml"
, Tuple.Create(Tuple.Create("", 4084), Tuple.Create<System.Object, System.Int32>(Resources.Resources.Search
            
            #line default
            #line hidden
, 4084), false)
);

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n        " +
"            </div>\r\n");

            
            #line 75 "..\..\Views\Careers\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <!-- /RIGHT COLUMNS -->\r\n</se" +
"ction>\r\n");

        }
    }
}
#pragma warning restore 1591
