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
    
    #line 4 "..\..\Views\Home\Index.cshtml"
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
    
    #line 1 "..\..\Views\Home\Index.cshtml"
    using cutecms_porto.Areas.CMS.Models.DBModel;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Home\Index.cshtml"
    using cutecms_porto.Areas.Config.Models.DBModel;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Home\Index.cshtml"
    using cutecms_porto.Areas.Identity.Models.DBModel;
    
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
            
            #line 6 "..\..\Views\Home\Index.cshtml"
  
    ViewBag.Title = Resources.Resources.Home;
    CMSEntities cmsDb = new CMSEntities();
    CMSEntities configDb = new CMSEntities();
    IdentityEntities IdentityDb = new IdentityEntities();
    var openingHours = Model.ContentLists.Where(c => c.Code.Trim().Equals("opening-hour")).FirstOrDefault()?.ListItems ?? new List<ListItem>();
    var shortcutContents = Model.Contents.Where(c => c.HasShortcut);
    var partnerList = Model.ContentLists.Where(c => c.Code.Trim().Equals("partner"))?.FirstOrDefault() ?? new ContentList();
    var resourcesList = Model.ContentLists.Where(c => c.Code.Trim().Equals("resource"))?.FirstOrDefault() ?? new ContentList();
    var testimonialList = Model.ContentLists.Where(c => c.Code.Trim().Equals("testimonial"))?.FirstOrDefault() ?? new ContentList();
    IdentityEntities identityDb = new IdentityEntities();
    var organizations = (List<Organization>)HttpRuntime.Cache["Organizations"];
    var organization = organizations.Where(o => o.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name))?.FirstOrDefault() ?? new Organization();
    IEnumerable<MenuItem> footerMenuItems = configDb.MenuItems.Include("Status").Include("Menu").Include("Language").Where(m => m.Menu.TenantId.Trim().Equals(Tenant.TenantId) && m.Menu.Code.Trim().Equals("footer-menu") && m.Status.Code.Trim().Equals("published") && m.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).OrderBy(o => o.Ordinal);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Styles", () => {

WriteLiteral("\r\n    <!-- Current Page CSS -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1782), Tuple.Create("\"", 1837)
, Tuple.Create(Tuple.Create("", 1789), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/rs-plugin/css/settings.css")
, 1789), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1867), Tuple.Create("\"", 1920)
, Tuple.Create(Tuple.Create("", 1874), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/rs-plugin/css/layers.css")
, 1874), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1950), Tuple.Create("\"", 2007)
, Tuple.Create(Tuple.Create("", 1957), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/rs-plugin/css/navigation.css")
, 1957), false)
);

WriteLiteral(">\r\n");

});

WriteLiteral("<div");

WriteLiteral(" role=\"main\"");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"slider-container rev_slider_wrapper\"");

WriteLiteral(" style=\"height: 760px;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" id=\"revolutionSlider\"");

WriteLiteral(" class=\"slider rev_slider\"");

WriteLiteral(" data-plugin-revolution-slider");

WriteLiteral(" data-plugin-options=\"{\'delay\': 5000, \'gridwidth\': 800, \'gridheight\': 600}\"");

WriteLiteral(">\r\n            <ul>\r\n");

            
            #line 31 "..\..\Views\Home\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Home\Index.cshtml"
                 foreach (var item in Model.HomeGallery)
            {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" data-transition=\"fade\"");

WriteLiteral(">\r\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2460), Tuple.Create("\"", 2480)
            
            #line 34 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2466), Tuple.Create<System.Object, System.Int32>(item.FilePath
            
            #line default
            #line hidden
, 2466), false)
);

WriteAttribute("alt", Tuple.Create("\r\n                             alt=\"", 2481), Tuple.Create("\"", 2698)
            
            #line 35 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2517), Tuple.Create<System.Object, System.Int32>(item.ImageFileTerms.Where(it => it.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name) && it.ImageFileId == item.Id).FirstOrDefault()?.Value ?? item.Code
            
            #line default
            #line hidden
, 2517), false)
);

WriteLiteral("\r\n                             data-bgposition=\"center center\"");

WriteLiteral("\r\n                             data-bgfit=\"cover\"");

WriteLiteral("\r\n                             data-bgrepeat=\"no-repeat\"");

WriteLiteral("\r\n                             class=\"rev-slidebg\"");

WriteLiteral(">\r\n\r\n                        <div");

WriteLiteral(" class=\"tp-caption\"");

WriteLiteral("\r\n                             data-x=\"center\"");

WriteLiteral(" data-hoffset=\"-150\"");

WriteLiteral("\r\n                             data-y=\"center\"");

WriteLiteral(" data-voffset=\"-95\"");

WriteLiteral("\r\n                             data-start=\"1000\"");

WriteLiteral("\r\n                             style=\"z-index: 5\"");

WriteLiteral("\r\n                             data-transform_in=\"x:[-300%];opacity:0;s:500;\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 3278), Tuple.Create("\"", 3332)
, Tuple.Create(Tuple.Create("", 3284), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/img/slides/slide-title-border.png")
, 3284), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral("></div>\r\n\r\n                        <div");

WriteLiteral(" class=\"tp-caption top-label\"");

WriteLiteral("\r\n                             data-x=\"center\"");

WriteLiteral(" data-hoffset=\"0\"");

WriteLiteral("\r\n                             data-y=\"center\"");

WriteLiteral(" data-voffset=\"-95\"");

WriteLiteral("\r\n                             data-start=\"500\"");

WriteLiteral("\r\n                             style=\"z-index: 5\"");

WriteLiteral("\r\n                             data-transform_in=\"y:[-300%];opacity:0;s:500;\"");

WriteLiteral(">");

            
            #line 53 "..\..\Views\Home\Index.cshtml"
                                                                        Write(item.ImageFileTerms.Where(it => it.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name) && it.ImageFileId == item.Id).FirstOrDefault()?.PrimaryCaption);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                            <div");

WriteLiteral(" class=\"tp-caption\"");

WriteLiteral("\r\n                                 data-x=\"center\"");

WriteLiteral(" data-hoffset=\"150\"");

WriteLiteral("\r\n                                 data-y=\"center\"");

WriteLiteral(" data-voffset=\"-95\"");

WriteLiteral("\r\n                                 data-start=\"1000\"");

WriteLiteral("\r\n                                 style=\"z-index: 5\"");

WriteLiteral("\r\n                                 data-transform_in=\"x:[300%];opacity:0;s:500;\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 4276), Tuple.Create("\"", 4330)
, Tuple.Create(Tuple.Create("", 4282), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/img/slides/slide-title-border.png")
, 4282), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral("></div>\r\n\r\n                            <div");

WriteLiteral(" class=\"tp-caption main-label\"");

WriteLiteral("\r\n                                 data-x=\"center\"");

WriteLiteral(" data-hoffset=\"0\"");

WriteLiteral("\r\n                                 data-y=\"center\"");

WriteLiteral(" data-voffset=\"-45\"");

WriteLiteral("\r\n                                 data-start=\"1500\"");

WriteLiteral("\r\n                                 data-whitespace=\"nowrap\"");

WriteLiteral("\r\n                                 data-transform_in=\"y:[100%];s:500;\"");

WriteLiteral("\r\n                                 data-transform_out=\"opacity:0;s:500;\"");

WriteLiteral("\r\n                                 style=\"z-index: 5\"");

WriteLiteral("\r\n                                 data-mask_in=\"x:0px;y:0px;\"");

WriteLiteral(">");

            
            #line 70 "..\..\Views\Home\Index.cshtml"
                                                         Write(item.ImageFileTerms.Where(it => it.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name) && it.ImageFileId == item.Id).FirstOrDefault()?.SecondaryCaption);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                                <div");

WriteLiteral(" class=\"tp-caption bottom-label\"");

WriteLiteral("\r\n                                     data-x=\"center\"");

WriteLiteral(" data-hoffset=\"0\"");

WriteLiteral("\r\n                                     data-y=\"center\"");

WriteLiteral(" data-voffset=\"5\"");

WriteLiteral("\r\n                                     data-start=\"2000\"");

WriteLiteral("\r\n                                     style=\"z-index: 5\"");

WriteLiteral("\r\n                                     data-transform_in=\"y:[100%];opacity:0;s:50" +
"0;\"");

WriteLiteral(">");

            
            #line 77 "..\..\Views\Home\Index.cshtml"
                                                                               Write(item.ImageFileTerms.Where(it => it.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name) && it.ImageFileId == item.Id).FirstOrDefault()?.TertiaryCaption);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                                    <a");

WriteLiteral(" class=\"tp-caption btn btn-lg btn-primary btn-slider-action\"");

WriteLiteral("\r\n                                       data-hash");

WriteLiteral("\r\n                                       data-hash-offset=\"85\"");

WriteLiteral("\r\n                                       href=\"#home-intro\"");

WriteLiteral("\r\n                                       data-x=\"center\"");

WriteLiteral(" data-hoffset=\"0\"");

WriteLiteral("\r\n                                       data-y=\"center\"");

WriteLiteral(" data-voffset=\"80\"");

WriteLiteral("\r\n                                       data-start=\"2200\"");

WriteLiteral("\r\n                                       data-whitespace=\"nowrap\"");

WriteLiteral("\r\n                                       data-transform_in=\"y:[100%];s:500;\"");

WriteLiteral("\r\n                                       data-transform_out=\"opacity:0;s:500;\"");

WriteLiteral("\r\n                                       style=\"z-index: 5\"");

WriteLiteral("\r\n                                       data-mask_in=\"x:0px;y:0px;\"");

WriteLiteral(">Get Started Now!</a>\r\n\r\n                                </li>\r\n");

            
            #line 93 "..\..\Views\Home\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"home-intro home-intro-primary\"");

WriteLiteral(" id=\"home-intro\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n                    <p>\r\n");

WriteLiteral("                        ");

            
            #line 103 "..\..\Views\Home\Index.cshtml"
                    Write(Model.ContentLists.Where(c => c.Code.Trim().Equals("intro")).FirstOrDefault()?.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <span");

WriteLiteral(" class=\"text-light\"");

WriteLiteral(">");

            
            #line 104 "..\..\Views\Home\Index.cshtml"
                                             Write(Model.ContentLists.Where(c => c.Code.Trim().Equals("intro")).FirstOrDefault()?.Subtitle);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </p>\r\n                </div>\r\n                ");

WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    ");

WriteLiteral("\r\n    <section");

WriteLiteral(" class=\"section section-background section-center mt-none\"");

WriteLiteral(" style=\"background-image: url(~/assets/porto/img/patterns/swirl_pattern.png);\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"mb-xl\"");

WriteLiteral(">Our <strong>Services</strong></h2>\r\n");

            
            #line 202 "..\..\Views\Home\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 202 "..\..\Views\Home\Index.cshtml"
             foreach (var item in shortcutContents)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"row mt-xlg pt-xlg mb-xlg pb-xs\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-8 col-md-8\"");

WriteLiteral(">\r\n                        <h2");

WriteLiteral(" class=\"font-weight-semibold mb-xs\"");

WriteLiteral(">");

            
            #line 206 "..\..\Views\Home\Index.cshtml"
                                                          Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                        <p");

WriteLiteral(" class=\"lead font-weight-normal\"");

WriteLiteral(">");

            
            #line 207 "..\..\Views\Home\Index.cshtml"
                                                      Write(item.Subtitle);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        <p");

WriteLiteral(" class=\"text-justify\"");

WriteLiteral(">");

            
            #line 208 "..\..\Views\Home\Index.cshtml"
                                           Write(item.MainContent.StripHtml().Chop(300).Trim());

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        <a");

WriteLiteral(" class=\"btn btn-borders btn-quaternary custom-button text-uppercase mt-lg mb-lg f" +
"ont-weight-bold\"");

WriteAttribute("href", Tuple.Create(" href=\"", 13465), Tuple.Create("\"", 13532)
            
            #line 209 "..\..\Views\Home\Index.cshtml"
                                                 , Tuple.Create(Tuple.Create("", 13472), Tuple.Create<System.Object, System.Int32>(Url.Action("Content", "Pages" , new { slug=@item.UrlSlug })
            
            #line default
            #line hidden
, 13472), false)
);

WriteLiteral(">");

            
            #line 209 "..\..\Views\Home\Index.cshtml"
                                                                                                                                                                                           Write(Resources.Resources.ReadMore);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-sm-4 col-md-4\"");

WriteLiteral(">\r\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 13678), Tuple.Create("\"", 13699)
            
            #line 212 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 13684), Tuple.Create<System.Object, System.Int32>(item.ImagePath
            
            #line default
            #line hidden
, 13684), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 13700), Tuple.Create("\"", 13721)
            
            #line 212 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 13706), Tuple.Create<System.Object, System.Int32>(item.ImageName
            
            #line default
            #line hidden
, 13706), false)
);

WriteLiteral(" class=\"img-responsive boxshadow\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");

            
            #line 215 "..\..\Views\Home\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </section>\r\n    <section");

WriteLiteral(" class=\"section section-tertiary pb-none mb-none\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-7\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"text-light\"");

WriteLiteral("><strong>Who</strong> We Are</h2>\r\n                    <p");

WriteLiteral(" class=\"text-light\"");

WriteLiteral(">");

            
            #line 223 "..\..\Views\Home\Index.cshtml"
                                      Write(Model.ContentLists.Where(c => c.Code.Trim().Equals("about")).FirstOrDefault()?.Content);

            
            #line default
            #line hidden
WriteLiteral(" </p>\r\n                    <a");

WriteLiteral(" class=\"btn btn-secondary mt-lg mb-sm\"");

WriteLiteral(">");

            
            #line 224 "..\..\Views\Home\Index.cshtml"
                                                         Write(Model.ContentLists.Where(c => c.Code.Trim().Equals("about")).FirstOrDefault()?.Subtitle);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-4 col-md-offset-1\"");

WriteLiteral(">\r\n                    <img");

WriteLiteral(" class=\"img-responsive appear-animation\"");

WriteAttribute("src", Tuple.Create(" src=\"", 14543), Tuple.Create("\"", 14640)
            
            #line 227 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 14549), Tuple.Create<System.Object, System.Int32>(Model.ContentLists.Where(c => c.Code.Trim().Equals("about")).FirstOrDefault()?.ImagePath
            
            #line default
            #line hidden
, 14549), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" data-appear-animation=\"fadeInUp\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n  " +
"  <section");

WriteLiteral(" class=\"section section-background section-center mt-none\"");

WriteLiteral(" style=\"background-image: url(~/assets/porto/img/patterns/swirl_pattern.png);\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-10 col-md-offset-1\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-dark mt-xl\"");

WriteLiteral(">Our <strong>Clients</strong></h2>\r\n                    <div");

WriteLiteral(" class=\"owl-carousel owl-theme nav-bottom rounded-nav\"");

WriteLiteral(" data-plugin-options=\"{\'items\': 1, \'loop\': false}\"");

WriteLiteral(">\r\n");

            
            #line 238 "..\..\Views\Home\Index.cshtml"
                     
            
            #line default
            #line hidden
            
            #line 238 "..\..\Views\Home\Index.cshtml"
                      foreach (var item in testimonialList.ListItems)
            {

            
            #line default
            #line hidden
WriteLiteral("                        <div>\r\n                            <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"testimonial testimonial-style-2 testimonial-with-quotes mb-none\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"testimonial-author\"");

WriteLiteral(">\r\n                                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 15644), Tuple.Create("\"", 15665)
            
            #line 244 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 15650), Tuple.Create<System.Object, System.Int32>(item.ThumbPath
            
            #line default
            #line hidden
, 15650), false)
);

WriteLiteral(" class=\"img-responsive img-circle\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                                    </div>\r\n                                  " +
"  <blockquote>\r\n                                        <p>");

            
            #line 247 "..\..\Views\Home\Index.cshtml"
                                      Write(item.Body);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                    </blockquote>\r\n                        " +
"            <div");

WriteLiteral(" class=\"testimonial-author\"");

WriteLiteral(">\r\n                                        <p><strong>");

            
            #line 250 "..\..\Views\Home\Index.cshtml"
                                              Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong><span>");

            
            #line 250 "..\..\Views\Home\Index.cshtml"
                                                                        Write(item.Subtitle);

            
            #line default
            #line hidden
WriteLiteral("</span></p>\r\n                                    </div>\r\n                        " +
"        </div>\r\n                            </div>\r\n                        </di" +
"v>\r\n");

            
            #line 255 "..\..\Views\Home\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        <" +
"/div>\r\n    </section>\r\n    ");

WriteLiteral("\r\n    <section");

WriteLiteral(" class=\"section section-primary\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"recent-posts mb-xl\"");

WriteLiteral(">\r\n                        <h2");

WriteLiteral(" class=\"mb-xs\"");

WriteLiteral(">Our <strong>Blog</strong></h2>\r\n                        <div");

WriteLiteral(" class=\"owl-carousel owl-theme mb-none\"");

WriteLiteral(" data-plugin-options=\'{\"items\": 1}\'");

WriteLiteral(">\r\n");

            
            #line 309 "..\..\Views\Home\Index.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 309 "..\..\Views\Home\Index.cshtml"
                              var newsIndex = 0; bool newsDivClosed = false; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 310 "..\..\Views\Home\Index.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 310 "..\..\Views\Home\Index.cshtml"
                             foreach (var item in Model.Contents.Where(c => c.ContentType.Code.Trim().Equals("article")).OrderByDescending(c => c.PublishedOn).Take(12))
                            {
                                newsDivClosed = false;
                                if (newsIndex % 2 == 0)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    ");

WriteLiteral("<div class=\"row mt-lg\">\r\n");

            
            #line 316 "..\..\Views\Home\Index.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                                    <article>\r\n                               " +
"         <div");

WriteLiteral(" class=\"date\"");

WriteLiteral(">\r\n                                            <span");

WriteLiteral(" class=\"day\"");

WriteLiteral(">");

            
            #line 320 "..\..\Views\Home\Index.cshtml"
                                                         Write(item.PublishedOn.Value.Day);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                            <span");

WriteLiteral(" class=\"month\"");

WriteLiteral(">");

            
            #line 321 "..\..\Views\Home\Index.cshtml"
                                                           Write(item.PublishedOn.Value.Month);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                        </div>\r\n                        " +
"                <h4");

WriteLiteral(" class=\"heading-primary\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 19653), Tuple.Create("\"", 19720)
            
            #line 323 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 19660), Tuple.Create<System.Object, System.Int32>(Url.Action("Content", "Pages" , new { slug=@item.UrlSlug })
            
            #line default
            #line hidden
, 19660), false)
);

WriteLiteral(">");

            
            #line 323 "..\..\Views\Home\Index.cshtml"
                                                                                                                                      Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</a></h4>\r\n                                        <p");

WriteLiteral(" class=\"text-justify\"");

WriteLiteral(">");

            
            #line 324 "..\..\Views\Home\Index.cshtml"
                                                           Write(item.MainContent.StripHtml().Chop(120));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                        <a");

WriteLiteral(" class=\"btn btn-primary btn-xs\"");

WriteAttribute("href", Tuple.Create(" href=\"", 19926), Tuple.Create("\"", 19993)
            
            #line 325 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 19933), Tuple.Create<System.Object, System.Int32>(Url.Action("Content", "Pages" , new { slug=@item.UrlSlug })
            
            #line default
            #line hidden
, 19933), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-plus\"");

WriteLiteral("></i><span> ");

            
            #line 325 "..\..\Views\Home\Index.cshtml"
                                                                                                                                                                          Write(Resources.Resources.ReadMore);

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n                                    </article>\r\n                    " +
"            </div>\r\n");

            
            #line 328 "..\..\Views\Home\Index.cshtml"
                                newsIndex++;
                                if (newsIndex % 2 == 0)
                                {
                                    newsDivClosed = true;

            
            #line default
            #line hidden
WriteLiteral("                                    ");

WriteLiteral("                                </div>\r\n");

            
            #line 333 "..\..\Views\Home\Index.cshtml"
                            }
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n");

            
            #line 336 "..\..\Views\Home\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 336 "..\..\Views\Home\Index.cshtml"
                         if (!newsDivClosed)
                        {
                            newsDivClosed = true;

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("                        </div>\r\n");

            
            #line 340 "..\..\Views\Home\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n\r\n                        <h2");

WriteLiteral(" class=\"mb-xs\"");

WriteLiteral(">Our <strong>Stats</strong></h2>\r\n\r\n                        <div");

WriteLiteral(" class=\"content-grid content-grid-dashed mt-xlg mb-lg\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"row content-grid-row\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"content-grid-item col-md-6 center\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"counters\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"counter text-color-light\"");

WriteLiteral(">\r\n                                            <strong");

WriteLiteral(" data-to=\"25000\"");

WriteLiteral(" data-append=\"+\"");

WriteLiteral(">0</strong>\r\n                                            <label>Happy Clients</la" +
"bel>\r\n                                        </div>\r\n                          " +
"          </div>\r\n                                </div>\r\n                      " +
"          <div");

WriteLiteral(" class=\"content-grid-item col-md-6 center\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"counters\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"counter text-color-light\"");

WriteLiteral(">\r\n                                            <strong");

WriteLiteral(" data-to=\"15\"");

WriteLiteral(@">0</strong>
                                            <label>Years in Business</label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div");

WriteLiteral(" class=\"row content-grid-row\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"content-grid-item col-md-6 center\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"counters\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"counter text-color-light\"");

WriteLiteral(">\r\n                                            <strong");

WriteLiteral(" data-to=\"352\"");

WriteLiteral(@">0</strong>
                                            <label>Cups of Coffee</label>
                                        </div>
                                    </div>
                                </div>
                                <div");

WriteLiteral(" class=\"content-grid-item col-md-6 center\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"counters\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"counter text-color-light\"");

WriteLiteral(">\r\n                                            <strong");

WriteLiteral(" data-to=\"178\"");

WriteLiteral(@">0</strong>
                                            <label>High Score</label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </section>
        ");

WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
