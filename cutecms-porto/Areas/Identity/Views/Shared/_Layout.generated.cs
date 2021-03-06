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
    
    #line 3 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
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
    
    #line 1 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
    using cutecms_porto.Areas.Config.Models.DBModel;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
    using cutecms_porto.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Identity/Views/Shared/_Layout.cshtml")]
    public partial class _Areas_Identity_Views_Shared__Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Identity_Views_Shared__Layout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
  
    var organizations = (List<Organization>)HttpRuntime.Cache["Organizations"];
    var organization = organizations.Where(o => o.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).FirstOrDefault();


            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteAttribute("lang", Tuple.Create(" lang=\"", 364), Tuple.Create("\"", 434)
            
            #line 10 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 371), Tuple.Create<System.Object, System.Int32>(cutecms_porto.Helpers.CultureHelper.GetCurrentNeutralCulture()
            
            #line default
            #line hidden
, 371), false)
);

WriteAttribute("dir", Tuple.Create(" dir=\"", 435), Tuple.Create("\"", 510)
            
            #line 10 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
    , Tuple.Create(Tuple.Create("", 441), Tuple.Create<System.Object, System.Int32>(cutecms_porto.Helpers.CultureHelper.IsRighToLeft() ? "rtl" : "ltr"
            
            #line default
            #line hidden
, 441), false)
);

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"robots\"");

WriteLiteral(" content=\"noindex,nofollow\"");

WriteLiteral(" />\r\n    <title>");

            
            #line 16 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 16 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
                        Write(organization?.Name);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <!-- CSS -->\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 824), Tuple.Create("\"", 878)
, Tuple.Create(Tuple.Create("", 831), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/bootstrap/dist/css/bootstrap.css")
, 831), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    ");

WriteLiteral("\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 1025), Tuple.Create("\"", 1067)
, Tuple.Create(Tuple.Create("", 1032), Tuple.Create<System.Object, System.Int32>(Href("~/assets/identity/bootstrap.min.css")
, 1032), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 1099), Tuple.Create("\"", 1136)
, Tuple.Create(Tuple.Create("", 1106), Tuple.Create<System.Object, System.Int32>(Href("~/assets/identity/identity.css")
, 1106), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.cs" +
"s\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n");

            
            #line 23 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
     if (cutecms_porto.Helpers.CultureHelper.IsRighToLeft())
    {

            
            #line default
            #line hidden
WriteLiteral("        <link");

WriteAttribute("href", Tuple.Create(" href=\"", 1353), Tuple.Create("\"", 1399)
, Tuple.Create(Tuple.Create("", 1360), Tuple.Create<System.Object, System.Int32>(Href("~/assets/identity/bootstrap-rtl.min.css")
, 1360), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n");

WriteLiteral("        <style>\r\n            .dropdown-menu {\r\n                right: 0px !import" +
"ant;\r\n                left: auto !important;\r\n            }\r\n        </style>\r\n");

            
            #line 32 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral(@"        <style>
            .dropdown-menu {
                right: auto !important;
                left: 0px !important;
            }

            .form-top-left {
                float: right;
                width: 75%;
                padding-top: 25px;
            }

            .form-top-right {
                float: left;
                width: 10%;
                padding-top: 5px;
                font-size: 66px;
                color: #fff;
                line-height: 100px;
                text-align: right;
                opacity: 0.3;
            }
        </style>
");

            
            #line 58 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <style>\r\n        .top-100 {\r\n            top: 100px;\r\n        }\r\n    </style>" +
"\r\n</head>\r\n<body");

WriteLiteral(" class=\"body-top\"");

WriteLiteral(">\r\n    <div>\r\n        <!-- Navbar Menu -->\r\n        <nav");

WriteLiteral(" class=\"navbar navbar-inverse navbar-fixed-top\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"navbar-header\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"navbar-toggle collapsed\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\"#bs-example-navbar-collapse-1\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">Toggle navigation</span>\r\n                        <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                        <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                        <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                    </button>\r\n                </div>\r\n                " +
"<!-- Collect the nav links, forms, and other content for toggling -->\r\n         " +
"       <div");

WriteLiteral(" class=\"collapse navbar-collapse\"");

WriteLiteral(" style=\"margin:0 1px 0 1px;\"");

WriteLiteral(" id=\"bs-example-navbar-collapse-1\"");

WriteLiteral(">\r\n                    <div>\r\n                        <ul");

WriteLiteral(" class=\"nav navbar-nav\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 82 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
                       Write(Html.Partial("~/Areas/Identity/Views/Shared/_LoginPartial.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                    " +
"<div>\r\n                        <ul");

WriteAttribute("class", Tuple.Create(" class=\"", 3461), Tuple.Create("\"", 3549)
, Tuple.Create(Tuple.Create("", 3469), Tuple.Create("nav", 3469), true)
, Tuple.Create(Tuple.Create(" ", 3472), Tuple.Create("navbar-nav", 3473), true)
            
            #line 86 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("  ", 3483), Tuple.Create<System.Object, System.Int32>(CultureHelper.IsRighToLeft() ? "navbar-left" : "navbar-right"
            
            #line default
            #line hidden
, 3485), false)
);

WriteLiteral(">\r\n");

            
            #line 87 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 87 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
                             if (organization != null)
                            {
                                foreach (var item in organization.SocialNetworks)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li>\r\n                                       " +
" <span");

WriteLiteral(" class=\"li-social\"");

WriteLiteral(">\r\n                                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3912), Tuple.Create("\"", 3928)
            
            #line 93 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 3919), Tuple.Create<System.Object, System.Int32>(item.Url
            
            #line default
            #line hidden
, 3919), false)
);

WriteLiteral("><i");

WriteAttribute("class", Tuple.Create(" class=\"", 3932), Tuple.Create("\"", 3957)
, Tuple.Create(Tuple.Create("", 3940), Tuple.Create("fa", 3940), true)
            
            #line 93 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create(" ", 3942), Tuple.Create<System.Object, System.Int32>(item.CssClass
            
            #line default
            #line hidden
, 3943), false)
);

WriteLiteral("></i></a>\r\n                                        </span>\r\n                     " +
"               </li>\r\n");

            
            #line 96 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
                                }
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>" +
"\r\n            </div>\r\n        </nav>\r\n        <div");

WriteLiteral(" class=\"wrap\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"container body-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-6 col-sm-offset-3 form-box top-100\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-top\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"form-top-left\"");

WriteLiteral(" ");

            
            #line 108 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
                                                   Write(cutecms_porto.Helpers.CultureHelper.IsRighToLeft() ? "style=text-align:right" : "style=text-align:left");

            
            #line default
            #line hidden
WriteLiteral(">\r\n                                <h3>");

            
            #line 109 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
                               Write(ViewBag.MainTitle);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                                <p>");

            
            #line 110 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
                              Write(ViewBag.SubTitle);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"form-top-right\"");

WriteLiteral(">\r\n                                <i");

WriteAttribute("class", Tuple.Create(" class=\'", 4895), Tuple.Create("\'", 4921)
            
            #line 113 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 4903), Tuple.Create<System.Object, System.Int32>(ViewBag.IconTitle
            
            #line default
            #line hidden
, 4903), false)
);

WriteLiteral("></i>\r\n                            </div>\r\n                        </div>\r\n      " +
"                  <div");

WriteLiteral(" class=\"form-bottom\"");

WriteLiteral(" style=\"padding-top:5px;padding-bottom:5px\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 117 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
                       Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n");

WriteLiteral("                ");

            
            #line 121 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
           Write(RenderSection("SocialLinks", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" style=\"margin: 0; padding: 0; left: 0; top: 0; width: 100%; position: fixed; z-i" +
"ndex: -999999;\"");

WriteLiteral("><img");

WriteLiteral(" style=\"margin: 0; padding: 0; border: medium; left: 0; width: 100%; height: 960p" +
"x; position: absolute; z-index: -999999; max-height: none; max-width: none;\"");

WriteAttribute("src", Tuple.Create(" src=\"", 5596), Tuple.Create("\"", 5639)
, Tuple.Create(Tuple.Create("", 5602), Tuple.Create<System.Object, System.Int32>(Href("~/assets/identity/images/login-bg.jpg")
, 5602), false)
);

WriteLiteral("></div>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 5660), Tuple.Create("\"", 5708)
, Tuple.Create(Tuple.Create("", 5666), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/vendor/jquery/jquery.min.js")
, 5666), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 5732), Tuple.Create("\"", 5783)
, Tuple.Create(Tuple.Create("", 5738), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/bootstrap/dist/js/bootstrap.js")
, 5738), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("    ");

            
            #line 128 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 132 "..\..\Areas\Identity\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
