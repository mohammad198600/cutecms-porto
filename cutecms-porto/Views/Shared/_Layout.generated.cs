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
    
    #line 3 "..\..\Views\Shared\_Layout.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    
    #line 4 "..\..\Views\Shared\_Layout.cshtml"
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
    
    #line 1 "..\..\Views\Shared\_Layout.cshtml"
    using cutecms_porto.Areas.CMS.Models.DBModel;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\_Layout.cshtml"
    using cutecms_porto.Areas.Config.Models.DBModel;
    
    #line default
    #line hidden
    using cutecms_porto.Helpers;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Layout.cshtml")]
    public partial class _Views_Shared__Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Layout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Shared\_Layout.cshtml"
  
    var organizations = (List<Organization>)HttpRuntime.Cache["Organizations"];
    var organization = organizations.Where(o => o.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name))?.FirstOrDefault() ?? new Organization();

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteAttribute("dir", Tuple.Create(" dir=\"", 431), Tuple.Create("\"", 484)
            
            #line 10 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 437), Tuple.Create<System.Object, System.Int32>(CultureHelper.IsRighToLeft() ? "rtl" : "ltr"
            
            #line default
            #line hidden
, 437), false)
);

WriteLiteral(">\r\n<head>\r\n    <!-- Basic -->\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n\r\n    <title>");

            
            #line 16 "..\..\Views\Shared\_Layout.cshtml"
       Write(organization?.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 16 "..\..\Views\Shared\_Layout.cshtml"
                              Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n\r\n    <meta");

WriteLiteral(" name=\"keywords\"");

WriteAttribute("content", Tuple.Create(" content=\"", 691), Tuple.Create("\"", 732)
            
            #line 18 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 701), Tuple.Create<System.Object, System.Int32>(organization.MetaDescription
            
            #line default
            #line hidden
, 701), false)
);

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteAttribute("content", Tuple.Create(" content=\"", 766), Tuple.Create("\"", 807)
            
            #line 19 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 776), Tuple.Create<System.Object, System.Int32>(organization.MetaDescription
            
            #line default
            #line hidden
, 776), false)
);

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"author\"");

WriteLiteral(" content=\"CuteCMS.NET\"");

WriteLiteral(">\r\n\r\n    <!-- Favicon -->\r\n    <link");

WriteLiteral(" rel=\"shortcut icon\"");

WriteAttribute("href", Tuple.Create(" href=\"", 912), Tuple.Create("\"", 949)
, Tuple.Create(Tuple.Create("", 919), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/img/favicon.ico")
, 919), false)
);

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1007), Tuple.Create("\"", 1053)
, Tuple.Create(Tuple.Create("", 1014), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/img/apple-touch-icon.png")
, 1014), false)
);

WriteLiteral(">\r\n\r\n    <!-- Mobile Metas -->\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, minimum-scale=1.0, maximum-scale=1.0, user-scalable" +
"=no\"");

WriteLiteral(">\r\n\r\n    <!-- Web Fonts  -->\r\n    <link async");

WriteLiteral(" href=\"https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700,800%7CSh" +
"adows+Into+Light\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n\r\n    <!-- Vendor CSS -->\r\n    ");

WriteLiteral("\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 2112), Tuple.Create("\"", 2148)
, Tuple.Create(Tuple.Create("", 2119), Tuple.Create<System.Object, System.Int32>(Href("~/assets/optimized/vendor.css")
, 2119), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n");

            
            #line 41 "..\..\Views\Shared\_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Shared\_Layout.cshtml"
     if (CultureHelper.IsRighToLeft())
    {


            
            #line default
            #line hidden
WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2250), Tuple.Create("\"", 2310)
, Tuple.Create(Tuple.Create("", 2257), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/bootstrap-rtl/bootstrap-rtl.css")
, 2257), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("        <!-- Theme CSS  -->\r\n");

WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2375), Tuple.Create("\"", 2414)
, Tuple.Create(Tuple.Create("", 2382), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/css/rtl-theme.css")
, 2382), false)
);

WriteLiteral(">\r\n");

WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2448), Tuple.Create("\"", 2496)
, Tuple.Create(Tuple.Create("", 2455), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/css/rtl-theme-elements.css")
, 2455), false)
);

WriteLiteral(">\r\n");

WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2530), Tuple.Create("\"", 2574)
, Tuple.Create(Tuple.Create("", 2537), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/css/rtl-theme-blog.css")
, 2537), false)
);

WriteLiteral(">\r\n");

WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2608), Tuple.Create("\"", 2652)
, Tuple.Create(Tuple.Create("", 2615), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/css/rtl-theme-shop.css")
, 2615), false)
);

WriteLiteral(">\r\n");

            
            #line 50 "..\..\Views\Shared\_Layout.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2710), Tuple.Create("\"", 2745)
, Tuple.Create(Tuple.Create("", 2717), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/css/theme.css")
, 2717), false)
);

WriteLiteral(">\r\n");

WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2779), Tuple.Create("\"", 2823)
, Tuple.Create(Tuple.Create("", 2786), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/css/theme-elements.css")
, 2786), false)
);

WriteLiteral(">\r\n");

WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2857), Tuple.Create("\"", 2897)
, Tuple.Create(Tuple.Create("", 2864), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/css/theme-blog.css")
, 2864), false)
);

WriteLiteral(">\r\n");

WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2931), Tuple.Create("\"", 2971)
, Tuple.Create(Tuple.Create("", 2938), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/css/theme-shop.css")
, 2938), false)
);

WriteLiteral(">\r\n");

            
            #line 57 "..\..\Views\Shared\_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <!-- Current Page CSS -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3039), Tuple.Create("\"", 3094)
, Tuple.Create(Tuple.Create("", 3046), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/rs-plugin/css/settings.css")
, 3046), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3124), Tuple.Create("\"", 3177)
, Tuple.Create(Tuple.Create("", 3131), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/rs-plugin/css/layers.css")
, 3131), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3207), Tuple.Create("\"", 3264)
, Tuple.Create(Tuple.Create("", 3214), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/rs-plugin/css/navigation.css")
, 3214), false)
);

WriteLiteral(">\r\n\r\n    <!-- Skin CSS -->\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 3302), Tuple.Create("\"", 3354)
, Tuple.Create(Tuple.Create("", 3309), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/css/skins/skin-corporate-7.css")
, 3309), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <!-- Demo CSS -->\r\n\r\n\r\n    <!-- Theme Custom CSS -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3461), Tuple.Create("\"", 3497)
, Tuple.Create(Tuple.Create("", 3468), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/css/custom.css")
, 3468), false)
);

WriteLiteral(">\r\n\r\n    <!-- Head Libs -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3538), Tuple.Create("\"", 3592)
, Tuple.Create(Tuple.Create("", 3544), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/modernizr/modernizr.min.js")
, 3544), false)
);

WriteLiteral("></script>\r\n\r\n");

            
            #line 74 "..\..\Views\Shared\_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Shared\_Layout.cshtml"
     if (cutecms_porto.Helpers.CultureHelper.IsRighToLeft())
    {

            
            #line default
            #line hidden
WriteLiteral(@"        <style>
            .dropdown-menu .edge ul {
                left: 100% !important;
                right: auto !important;
            }

            #topNav div.submenu-dark ul.dropdown-menu a.dropdown-toggle {
                padding-left: 25px;
            }

            .team .thumb-info .thumb-info-caption .custom-thumb-info-title i {
                left: 20px !important;
            }

            .team .owl-carousel.nav-bottom .owl-nav {
                left: 10px !important;
            }
        </style>
");

            
            #line 94 "..\..\Views\Shared\_Layout.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral(@"        <style>
            .dropdown-menu .edge ul {
                left: auto !important;
                right: 100% !important;
                /*background: rgba(86, 86, 86, 1) !important;*/
            }

            #topNav div.submenu-dark ul.dropdown-menu a.dropdown-toggle {
                padding-right: 25px;
            }

            .team .thumb-info .thumb-info-caption .custom-thumb-info-title i {
                right: 20px !important;
            }

            .team .owl-carousel.nav-bottom .owl-nav {
                right: 10px !important;
            }
        </style>
");

            
            #line 116 "..\..\Views\Shared\_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 117 "..\..\Views\Shared\_Layout.cshtml"
Write(RenderSection("Styles", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4919), Tuple.Create("\"", 4967)
, Tuple.Create(Tuple.Create("", 4925), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/jquery/jquery.min.js")
, 4925), false)
);

WriteLiteral("></script>\r\n\r\n</head>\r\n<body>\r\n    <div");

WriteLiteral(" class=\"body\"");

WriteLiteral(">\r\n        <header");

WriteLiteral(" id=\"header\"");

WriteLiteral(" class=\"header-mobile-nav-only\"");

WriteLiteral(" data-plugin-options=\'{\"stickyEnabled\": true, \"stickyEnableOnBoxed\": true, \"stick" +
"yEnableOnMobile\": true, \"stickyStartAt\": 52, \"stickySetTop\": \"-52px\", \"stickyCha" +
"ngeLogo\": true}\'");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"header-body\"");

WriteLiteral(" style=\"top:0px\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"header-top\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n");

            
            #line 127 "..\..\Views\Shared\_Layout.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 127 "..\..\Views\Shared\_Layout.cshtml"
                          Html.RenderAction("GetTopMenu", "Home", new { area = "" });
            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"header-search hidden-xs\"");

WriteLiteral(">\r\n");

            
            #line 129 "..\..\Views\Shared\_Layout.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 129 "..\..\Views\Shared\_Layout.cshtml"
                             using (Html.BeginForm("Contents", "Home", new { area = "" }, FormMethod.Post))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 132 "..\..\Views\Shared\_Layout.cshtml"
                       Write(Html.Editor("keywordFilter", new { htmlAttributes = new { @placeholder = Resources.Resources.Search, @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <span");

WriteLiteral(" class=\"input-group-btn\"");

WriteLiteral(">\r\n                                <button");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-search\"");

WriteLiteral("></i></button>\r\n                            </span>\r\n                        </di" +
"v>\r\n");

            
            #line 137 "..\..\Views\Shared\_Layout.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n\r\n                    </div>\r\n                </d" +
"iv>\r\n                <div");

WriteLiteral(" class=\"header-container container\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"header-row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"header-column\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"header-logo\"");

WriteLiteral(">\r\n                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6490), Tuple.Create("\"", 6540)
, Tuple.Create(Tuple.Create("", 6497), Tuple.Create<System.Object, System.Int32>(Href("~/")
, 6497), false)
            
            #line 146 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 6499), Tuple.Create<System.Object, System.Int32>(Thread.CurrentThread.CurrentCulture.Name
            
            #line default
            #line hidden
, 6499), false)
);

WriteLiteral(">\r\n                                    ");

WriteLiteral("\r\n                                    ");

WriteLiteral("\r\n                                    <img");

WriteAttribute("alt", Tuple.Create(" alt=\"", 7089), Tuple.Create("\"", 7127)
            
            #line 149 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 7095), Tuple.Create<System.Object, System.Int32>(organization?.PrimaryLogoName
            
            #line default
            #line hidden
, 7095), false)
);

WriteLiteral(" width=\"111\"");

WriteLiteral(" height=\"54\"");

WriteLiteral(" data-sticky-width=\"82\"");

WriteLiteral(" data-sticky-height=\"40\"");

WriteLiteral(" data-sticky-top=\"15\"");

WriteAttribute("src", Tuple.Create(" src=\"", 7220), Tuple.Create("\"", 7258)
            
            #line 149 "..\..\Views\Shared\_Layout.cshtml"
                                                                                                  , Tuple.Create(Tuple.Create("", 7226), Tuple.Create<System.Object, System.Int32>(organization?.PrimaryLogoPath
            
            #line default
            #line hidden
, 7226), false)
);

WriteLiteral(" style=\"top: 0; width: 111px; height: 54px;\"");

WriteLiteral(">\r\n                                </a>\r\n                            </div>\r\n    " +
"                    </div>\r\n                        <div");

WriteLiteral(" class=\"header-column\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"header-row\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"header-nav header-nav-stripe\"");

WriteLiteral(">\r\n                                    <button");

WriteLiteral(" class=\"btn header-btn-collapse-nav\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\".header-nav-main\"");

WriteLiteral(">\r\n                                        <i");

WriteLiteral(" class=\"fa fa-bars\"");

WriteLiteral("></i>\r\n                                    </button>\r\n                           " +
"         <div");

WriteLiteral(" class=\"header-nav-main header-nav-main-square header-nav-main-effect-1 header-na" +
"v-main-sub-effect-1 collapse\"");

WriteLiteral(">\r\n                                        <nav>\r\n                               " +
"             <ul");

WriteLiteral(" class=\"nav nav-pills\"");

WriteLiteral(" id=\"mainNav\"");

WriteLiteral(">\r\n                                                <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">\r\n                                                    <a");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteAttribute("href", Tuple.Create(" href=\"", 8278), Tuple.Create("\"", 8328)
, Tuple.Create(Tuple.Create("", 8285), Tuple.Create<System.Object, System.Int32>(Href("~/")
, 8285), false)
            
            #line 163 "..\..\Views\Shared\_Layout.cshtml"
       , Tuple.Create(Tuple.Create("", 8287), Tuple.Create<System.Object, System.Int32>(Thread.CurrentThread.CurrentCulture.Name
            
            #line default
            #line hidden
, 8287), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                                        ");

            
            #line 164 "..\..\Views\Shared\_Layout.cshtml"
                                                   Write(Resources.Resources.Home);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                    </a>\r\n                     " +
"                           </li>\r\n");

            
            #line 167 "..\..\Views\Shared\_Layout.cshtml"
                                                
            
            #line default
            #line hidden
            
            #line 167 "..\..\Views\Shared\_Layout.cshtml"
                                                  Html.RenderAction("GetHeaderMenu", "Home", new { area = "" });
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 168 "..\..\Views\Shared\_Layout.cshtml"
                                                
            
            #line default
            #line hidden
            
            #line 168 "..\..\Views\Shared\_Layout.cshtml"
                                                  Html.RenderPartial("~/Views/Shared/Account.cshtml");
            
            #line default
            #line hidden
WriteLiteral(@"
                                            </ul>
                                        </nav>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");

WriteLiteral("            ");

            
            #line 179 "..\..\Views\Shared\_Layout.cshtml"
       Write(Html.Partial("_NewsBar"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </header>\r\n");

WriteLiteral("        ");

            
            #line 181 "..\..\Views\Shared\_Layout.cshtml"
   Write(RenderSection("PageHeader", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" role=\"main\"");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 183 "..\..\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 185 "..\..\Views\Shared\_Layout.cshtml"
        
            
            #line default
            #line hidden
            
            #line 185 "..\..\Views\Shared\_Layout.cshtml"
          Html.RenderAction("GetFooter", "Home", new { area = "" });
            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <!-- Vendor -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 9374), Tuple.Create("\"", 9436)
, Tuple.Create(Tuple.Create("", 9380), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/jquery.appear/jquery.appear.min.js")
, 9380), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 9460), Tuple.Create("\"", 9522)
, Tuple.Create(Tuple.Create("", 9466), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/jquery.easing/jquery.easing.min.js")
, 9466), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 9546), Tuple.Create("\"", 9608)
, Tuple.Create(Tuple.Create("", 9552), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/jquery-cookie/jquery-cookie.min.js")
, 9552), false)
);

WriteLiteral("></script>\r\n    ");

WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 9720), Tuple.Create("\"", 9777)
, Tuple.Create(Tuple.Create("", 9726), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/bootstrap/js/bootstrap.min.js")
, 9726), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 9801), Tuple.Create("\"", 9849)
, Tuple.Create(Tuple.Create("", 9807), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/common/common.min.js")
, 9807), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("    ");

            
            #line 194 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 9917), Tuple.Create("\"", 9995)
, Tuple.Create(Tuple.Create("", 9923), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/jquery.easy-pie-chart/jquery.easy-pie-chart.min.js")
, 9923), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10019), Tuple.Create("\"", 10077)
, Tuple.Create(Tuple.Create("", 10025), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/jquery.gmap/jquery.gmap.min.js")
, 10025), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10101), Tuple.Create("\"", 10167)
, Tuple.Create(Tuple.Create("", 10107), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/jquery.lazyload/jquery.lazyload.min.js")
, 10107), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10191), Tuple.Create("\"", 10248)
, Tuple.Create(Tuple.Create("", 10197), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/isotope/jquery.isotope.min.js")
, 10197), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10272), Tuple.Create("\"", 10332)
, Tuple.Create(Tuple.Create("", 10278), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/owl.carousel/owl.carousel.min.js")
, 10278), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10356), Tuple.Create("\"", 10427)
, Tuple.Create(Tuple.Create("", 10362), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/magnific-popup/jquery.magnific-popup.min.js")
, 10362), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10451), Tuple.Create("\"", 10495)
, Tuple.Create(Tuple.Create("", 10457), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/vide/vide.min.js")
, 10457), false)
);

WriteLiteral("></script>\r\n\r\n    <!-- Theme Base, Components and Settings -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10571), Tuple.Create("\"", 10603)
, Tuple.Create(Tuple.Create("", 10577), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/js/theme.js")
, 10577), false)
);

WriteLiteral("></script>\r\n\r\n    <!-- Current Page Vendor and Views -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10673), Tuple.Create("\"", 10744)
, Tuple.Create(Tuple.Create("", 10679), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/rs-plugin/js/jquery.themepunch.tools.min.js")
, 10679), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10768), Tuple.Create("\"", 10844)
, Tuple.Create(Tuple.Create("", 10774), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/rs-plugin/js/jquery.themepunch.revolution.min.js")
, 10774), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10868), Tuple.Create("\"", 10943)
, Tuple.Create(Tuple.Create("", 10874), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/circle-flip-slideshow/js/jquery.flipshow.min.js")
, 10874), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10967), Tuple.Create("\"", 11032)
, Tuple.Create(Tuple.Create("", 10973), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/nivo-slider/jquery.nivo.slider.min.js")
, 10973), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11056), Tuple.Create("\"", 11098)
, Tuple.Create(Tuple.Create("", 11062), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/js/views/view.home.js")
, 11062), false)
);

WriteLiteral("></script>\r\n\r\n    <!-- Tiny MCE -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11147), Tuple.Create("\"", 11215)
, Tuple.Create(Tuple.Create("", 11153), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/bower_components/tinymce/tinymce.min.js")
, 11153), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11239), Tuple.Create("\"", 11314)
, Tuple.Create(Tuple.Create("", 11245), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/bower_components/tinymce/jquery.tinymce.min.js")
, 11245), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11338), Tuple.Create("\"", 11409)
, Tuple.Create(Tuple.Create("", 11344), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/bower_components/tinymce/tinymce-layout.js")
, 11344), false)
);

WriteLiteral("></script>\r\n    <!-- Theme Custom -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11460), Tuple.Create("\"", 11493)
, Tuple.Create(Tuple.Create("", 11466), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/js/custom.js")
, 11466), false)
);

WriteLiteral("></script>\r\n\r\n    <!-- Theme Initialization Files -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11560), Tuple.Create("\"", 11597)
, Tuple.Create(Tuple.Create("", 11566), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/js/theme.init.js")
, 11566), false)
);

WriteLiteral(@"></script>

    <!-- Google Analytics: Change UA-XXXXX-X to be your site's ID. Go to http://www.google.com/analytics/ for more information.
    <script>
        (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
        (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
        m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
        })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

        ga('create', 'UA-12345678-1', 'auto');
        ga('send', 'pageview');
    </script>
     -->
");

            
            #line 234 "..\..\Views\Shared\_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 234 "..\..\Views\Shared\_Layout.cshtml"
     if (!CultureHelper.IsRighToLeft())
    {

            
            #line default
            #line hidden
WriteLiteral(@"        <script>
            jQuery(function ($) {
                $("".dropdown li"").on('mouseenter mouseleave', function (e) {
                    if ($('ul', this).length > 0) {
                        var elm = $('ul:first', this);
                        var off = elm.offset();
                        var l = off.left;
                        var w = elm.width();
                        var docW = $("".container"").width();
                        var isEntirelyVisible = (l + w <= docW + 100);
                        if (!isEntirelyVisible) {
                            $(this).addClass('edge');
                        } else {
                            $(this).removeClass('edge');
                        }
                    }
                });
            });
        </script>
");

            
            #line 255 "..\..\Views\Shared\_Layout.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral(@"        <script>
            jQuery(function ($) {
                $("".dropdown li"").on('mouseenter mouseleave', function (e) {
                    if ($('ul', this).length) {
                        var elm = $('ul:first', this);
                        var off = elm.offset();
                        var l = off.left;
                        var r = ($(window).width() - (elm.offset().left + elm.outerWidth()));
                        var w = elm.width();
                        var docW = $("".container"").width();
                        var isEntirelyVisible = (r + w <= docW + 100);
                        if (!isEntirelyVisible && !$(this).hasClass('edge')) {
                            $(this).addClass('edge');
                        }
                        else {
                            $(this).removeClass('edge');
                        }
                    }
                });
            });
        </script>
");

            
            #line 279 "..\..\Views\Shared\_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 280 "..\..\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
