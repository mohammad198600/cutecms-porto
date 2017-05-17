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
    
    #line 3 "..\..\Views\Home\Index.cshtml"
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
    
    #line 2 "..\..\Views\Home\Index.cshtml"
    using cutecms_porto.Areas.CMS.Models.DBModel;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Home\Index.cshtml"
    using cutecms_porto.Areas.Config.Models.DBModel;
    
    #line default
    #line hidden
    using cutecms_porto.Helpers;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Index.cshtml")]
    public partial class _Views_Home_Index_cshtml : System.Web.Mvc.WebViewPage<cutecms_porto.Models.HomeViewModel>
    {
        public _Views_Home_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Home\Index.cshtml"
  
    ViewBag.Title = Resources.Resources.Home;
    ViewBag.Contents = Model.Contents;
    CMSEntities cmsDb = new CMSEntities();

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Styles", () => {

WriteLiteral("\r\n    <!-- Current Page CSS -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 379), Tuple.Create("\"", 447)
, Tuple.Create(Tuple.Create("", 386), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/circle-flip-slideshow/css/component.css")
, 386), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 477), Tuple.Create("\"", 533)
, Tuple.Create(Tuple.Create("", 484), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/nivo-slider/nivo-slider.css")
, 484), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 563), Tuple.Create("\"", 623)
, Tuple.Create(Tuple.Create("", 570), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/nivo-slider/default/default.css")
, 570), false)
);

WriteLiteral(">\r\n");

});

WriteLiteral("<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"nivo-slider\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"slider-wrapper theme-default\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"nivoSlider\"");

WriteLiteral(" class=\"nivoSlider\"");

WriteLiteral(">\r\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 900), Tuple.Create("\"", 943)
, Tuple.Create(Tuple.Create("", 906), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/img/slides/slide-1.jpg")
, 906), false)
);

WriteLiteral(" data-thumb=\"img/slides/slide-1.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        <a");

WriteLiteral(" href=\"index.html\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 1041), Tuple.Create("\"", 1084)
, Tuple.Create(Tuple.Create("", 1047), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/img/slides/slide-2.jpg")
, 1047), false)
);

WriteLiteral(" data-thumb=\"img/slides/slide-2.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" /></a>\r\n                    </div>\r\n                    <div");

WriteLiteral(" id=\"htmlcaption\"");

WriteLiteral(" class=\"nivo-html-caption\"");

WriteLiteral("></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n" +
"    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"home-intro home-intro-compact\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n                        <p>\r\n");

WriteLiteral("                          ");

            
            #line 36 "..\..\Views\Home\Index.cshtml"
                     Write(Resources.Resources.Lorem1);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <span>");

            
            #line 37 "..\..\Views\Home\Index.cshtml"
                             Write(Resources.Resources.Lorem2);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </p>\r\n                    </div>\r\n              " +
"      <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"get-started\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"btn btn-lg btn-primary\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\Home\Index.cshtml"
                                                                  Write(Resources.Resources.GetStarted);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                            <div");

WriteLiteral(" class=\"learn-more\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Home\Index.cshtml"
                                               Write(Resources.Resources.Or);

            
            #line default
            #line hidden
WriteLiteral(" <a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Home\Index.cshtml"
                                                                                   Write(Resources.Resources.LearnMore);

            
            #line default
            #line hidden
WriteLiteral("</a></div>\r\n                        </div>\r\n                    </div>\r\n         " +
"       </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"row center\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 57 "..\..\Views\Home\Index.cshtml"
           Write(Resources.Resources.Lorem3);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <hr");

WriteLiteral(" class=\"tall\"");

WriteLiteral(">\r\n    </div>\r\n\r\n</div>\r\n\r\n<section");

WriteLiteral(" class=\"section section-custom-map\"");

WriteLiteral(">\r\n    <section");

WriteLiteral(" class=\"section section-default section-footer\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"recent-posts mb-xl\"");

WriteLiteral(">\r\n                        <h2>");

            
            #line 78 "..\..\Views\Home\Index.cshtml"
                       Write(Resources.Resources.LatestNews);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"owl-carousel owl-theme mb-none\"");

WriteLiteral(" data-plugin-options=\'{\"items\": 1}\'");

WriteLiteral(">\r\n                                <div>\r\n                                    <di" +
"v");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                                        <article>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"date\"");

WriteLiteral(">\r\n                                                <span");

WriteLiteral(" class=\"day\"");

WriteLiteral(">15</span>\r\n                                                <span");

WriteLiteral(" class=\"month\"");

WriteLiteral(">");

            
            #line 86 "..\..\Views\Home\Index.cshtml"
                                                               Write(Resources.Resources.January);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                            </div>\r\n                    " +
"                        <h4");

WriteLiteral(" class=\"heading-primary\"");

WriteLiteral("><a");

WriteLiteral(" href=\"blog-post.html\"");

WriteLiteral(">");

            
            #line 88 "..\..\Views\Home\Index.cshtml"
                                                                                            Write(Resources.Resources.LoremTitle);

            
            #line default
            #line hidden
WriteLiteral("</a></h4>\r\n                                            <p>");

            
            #line 89 "..\..\Views\Home\Index.cshtml"
                                          Write(Resources.Resources.Lorem3);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                        </article>\r\n                       " +
"             </div>\r\n                                    <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                                        <article>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"date\"");

WriteLiteral(">\r\n                                                <span");

WriteLiteral(" class=\"day\"");

WriteLiteral(">15</span>\r\n                                                <span");

WriteLiteral(" class=\"month\"");

WriteLiteral(">");

            
            #line 96 "..\..\Views\Home\Index.cshtml"
                                                               Write(Resources.Resources.January);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                            </div>\r\n                    " +
"                        <h4");

WriteLiteral(" class=\"heading-primary\"");

WriteLiteral("><a");

WriteLiteral(" href=\"blog-post.html\"");

WriteLiteral(">");

            
            #line 98 "..\..\Views\Home\Index.cshtml"
                                                                                            Write(Resources.Resources.LoremTitle);

            
            #line default
            #line hidden
WriteLiteral("</a></h4>\r\n                                            <p>");

            
            #line 99 "..\..\Views\Home\Index.cshtml"
                                          Write(Resources.Resources.Lorem3);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                        </article>\r\n                       " +
"             </div>\r\n                                </div>\r\n                   " +
"             <div>\r\n                                    <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                                        <article>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"date\"");

WriteLiteral(">\r\n                                                <span");

WriteLiteral(" class=\"day\"");

WriteLiteral(">12</span>\r\n                                                <span");

WriteLiteral(" class=\"month\"");

WriteLiteral(">Jan</span>\r\n                                            </div>\r\n                " +
"                            <h4");

WriteLiteral(" class=\"heading-primary\"");

WriteLiteral("><a");

WriteLiteral(" href=\"blog-post.html\"");

WriteLiteral(">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</a></h4>\r\n             " +
"                               <p>");

            
            #line 111 "..\..\Views\Home\Index.cshtml"
                                          Write(Resources.Resources.Lorem3);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                        </article>\r\n                       " +
"             </div>\r\n                                    <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                                        <article>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"date\"");

WriteLiteral(">\r\n                                                <span");

WriteLiteral(" class=\"day\"");

WriteLiteral(">11</span>\r\n                                                <span");

WriteLiteral(" class=\"month\"");

WriteLiteral(">Jan</span>\r\n                                            </div>\r\n                " +
"                            <h4");

WriteLiteral(" class=\"heading-primary\"");

WriteLiteral("><a");

WriteLiteral(" href=\"blog-post.html\"");

WriteLiteral(">");

            
            #line 120 "..\..\Views\Home\Index.cshtml"
                                                                                            Write(Resources.Resources.LoremTitle);

            
            #line default
            #line hidden
WriteLiteral("</a></h4>\r\n                                            <p>");

            
            #line 121 "..\..\Views\Home\Index.cshtml"
                                          Write(Resources.Resources.Lorem3);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                        </article>\r\n                       " +
"             </div>\r\n                                </div>\r\n                   " +
"             <div>\r\n                                    <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                                        <article>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"date\"");

WriteLiteral(">\r\n                                                <span");

WriteLiteral(" class=\"day\"");

WriteLiteral(">15</span>\r\n                                                <span");

WriteLiteral(" class=\"month\"");

WriteLiteral(">Jan</span>\r\n                                            </div>\r\n                " +
"                            <h4");

WriteLiteral(" class=\"heading-primary\"");

WriteLiteral("><a");

WriteLiteral(" href=\"blog-post.html\"");

WriteLiteral(">");

            
            #line 132 "..\..\Views\Home\Index.cshtml"
                                                                                            Write(Resources.Resources.LoremTitle);

            
            #line default
            #line hidden
WriteLiteral("</a></h4>\r\n                                            <p>");

            
            #line 133 "..\..\Views\Home\Index.cshtml"
                                          Write(Resources.Resources.Lorem3);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                        </article>\r\n                       " +
"             </div>\r\n                                    <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                                        <article>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"date\"");

WriteLiteral(">\r\n                                                <span");

WriteLiteral(" class=\"day\"");

WriteLiteral(">15</span>\r\n                                                <span");

WriteLiteral(" class=\"month\"");

WriteLiteral(">Jan</span>\r\n                                            </div>\r\n                " +
"                            <h4");

WriteLiteral(" class=\"heading-primary\"");

WriteLiteral("><a");

WriteLiteral(" href=\"blog-post.html\"");

WriteLiteral(">");

            
            #line 142 "..\..\Views\Home\Index.cshtml"
                                                                                            Write(Resources.Resources.LoremTitle);

            
            #line default
            #line hidden
WriteLiteral("</a></h4>\r\n                                            <p>");

            
            #line 143 "..\..\Views\Home\Index.cshtml"
                                          Write(Resources.Resources.Lorem3);

            
            #line default
            #line hidden
WriteLiteral(@"</p>
                                        </article>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                    <h2>");

            
            #line 152 "..\..\Views\Home\Index.cshtml"
                   Write(Resources.Resources.WhatClientsSay);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"owl-carousel owl-theme mb-none\"");

WriteLiteral(" data-plugin-options=\'{\"items\": 1}\'");

WriteLiteral(">\r\n                            <div>\r\n                                <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"testimonial testimonial-primary\"");

WriteLiteral(">\r\n                                        <blockquote>\r\n                        " +
"                    <p>");

            
            #line 159 "..\..\Views\Home\Index.cshtml"
                                          Write(Resources.Resources.Lorem3);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                        </blockquote>\r\n                    " +
"                    <div");

WriteLiteral(" class=\"testimonial-arrow-down\"");

WriteLiteral("></div>\r\n                                        <div");

WriteLiteral(" class=\"testimonial-author\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"testimonial-author-thumbnail img-thumbnail\"");

WriteLiteral(">\r\n                                                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 8552), Tuple.Create("\"", 8597)
, Tuple.Create(Tuple.Create("", 8558), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/img/clients/client-1.jpg")
, 8558), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                                            </div>\r\n                          " +
"                  <p><strong>");

            
            #line 166 "..\..\Views\Home\Index.cshtml"
                                                  Write(Resources.Resources.JohnSmith);

            
            #line default
            #line hidden
WriteLiteral("</strong><span>");

            
            #line 166 "..\..\Views\Home\Index.cshtml"
                                                                                               Write(Resources.Resources.JobTitleName);

            
            #line default
            #line hidden
WriteLiteral("</span></p>\r\n                                        </div>\r\n                    " +
"                </div>\r\n                                </div>\r\n                " +
"            </div>\r\n                            <div>\r\n                         " +
"       <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"testimonial testimonial-primary\"");

WriteLiteral(">\r\n                                        <blockquote>\r\n                        " +
"                    <p>");

            
            #line 175 "..\..\Views\Home\Index.cshtml"
                                          Write(Resources.Resources.Lorem3);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                        </blockquote>\r\n                    " +
"                    <div");

WriteLiteral(" class=\"testimonial-arrow-down\"");

WriteLiteral("></div>\r\n                                        <div");

WriteLiteral(" class=\"testimonial-author\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"testimonial-author-thumbnail img-thumbnail\"");

WriteLiteral(">\r\n                                                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 9650), Tuple.Create("\"", 9695)
, Tuple.Create(Tuple.Create("", 9656), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/img/clients/client-1.jpg")
, 9656), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                                            </div>\r\n                          " +
"                  <p><strong>");

            
            #line 182 "..\..\Views\Home\Index.cshtml"
                                                  Write(Resources.Resources.JohnSmith);

            
            #line default
            #line hidden
WriteLiteral("</strong><span>");

            
            #line 182 "..\..\Views\Home\Index.cshtml"
                                                                                               Write(Resources.Resources.JobTitleName);

            
            #line default
            #line hidden
WriteLiteral(@"</span></p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</section>
");

        }
    }
}
#pragma warning restore 1591
