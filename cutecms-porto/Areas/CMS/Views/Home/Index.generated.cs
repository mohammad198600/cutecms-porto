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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/CMS/Views/Home/Index.cshtml")]
    public partial class _Areas_CMS_Views_Home_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_CMS_Views_Home_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\CMS\Views\Home\Index.cshtml"
  
    ViewBag.MainTitle = Resources.Resources.Home;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Styles", () => {

WriteLiteral("\r\n    <!-- vector map CSS -->\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 115), Tuple.Create("\"", 199)
, Tuple.Create(Tuple.Create("", 122), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/bower_components/vectormap/jquery-jvectormap-2.0.2.css")
, 122), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 231), Tuple.Create("\"", 301)
, Tuple.Create(Tuple.Create("", 238), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/bower_components/css-chart/css-chart.css")
, 238), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n");

});

WriteLiteral("<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-4 col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"white-box\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral("><small");

WriteLiteral(" class=\"pull-right m-t-10 text-success\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-sort-asc\"");

WriteLiteral("></i> 18% High then last month</small> Site Traffic</h3>\r\n            <div");

WriteLiteral(" class=\"stats-row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                    <h6>Overall Growth</h6>\r\n                    <b>80.40%</b>" +
"\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                    <h6>Montly</h6>\r\n                    <b>15.40%</b>\r\n      " +
"          </div>\r\n                <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                    <h6>Day</h6>\r\n                    <b>5.50%</b>\r\n          " +
"      </div>\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"sparkline8\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-md-4 col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"white-box\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral("><small");

WriteLiteral(" class=\"pull-right m-t-10 text-danger\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-sort-desc\"");

WriteLiteral("></i> 18% High then last month</small>Site Traffic</h3>\r\n            <div");

WriteLiteral(" class=\"stats-row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                    <h6>Overall Growth</h6>\r\n                    <b>80.40%</b>" +
"\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                    <h6>Montly</h6>\r\n                    <b>15.40%</b>\r\n      " +
"          </div>\r\n                <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                    <h6>Day</h6>\r\n                    <b>5.50%</b>\r\n          " +
"      </div>\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"sparkline9\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-md-4 col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"white-box\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral("><small");

WriteLiteral(" class=\"pull-right m-t-10 text-success\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-sort-asc\"");

WriteLiteral("></i> 18% High then last month</small>Site Traffic</h3>\r\n            <div");

WriteLiteral(" class=\"stats-row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                    <h6>Overall Growth</h6>\r\n                    <b>80.40%</b>" +
"\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                    <h6>Montly</h6>\r\n                    <b>15.40%</b>\r\n      " +
"          </div>\r\n                <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                    <h6>Day</h6>\r\n                    <b>5.50%</b>\r\n          " +
"      </div>\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"sparkline10\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- /.row -->\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-md-12 col-xs-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"white-box\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral(">Site Visits</h3>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-md-8 col-xs-12\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"world-map-marker\"");

WriteLiteral(" style=\"height: 490px;\"");

WriteLiteral("></div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-md-4 col-xs-12\"");

WriteLiteral(">\r\n                    <ul");

WriteLiteral(" class=\"country-state slimscrollcountry\"");

WriteLiteral(">\r\n                        <li>\r\n                            <h2>6350</h2>\r\n     " +
"                       <small>From India</small>\r\n                            <d" +
"iv");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">48% <i");

WriteLiteral(" class=\"fa fa-level-up text-success\"");

WriteLiteral("></i></div>\r\n                            <div");

WriteLiteral(" class=\"progress\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"progress-bar progress-bar-success\"");

WriteLiteral(" role=\"progressbar\"");

WriteLiteral(" aria-valuenow=\"50\"");

WriteLiteral(" aria-valuemin=\"0\"");

WriteLiteral(" aria-valuemax=\"100\"");

WriteLiteral(" style=\"width:48%;\"");

WriteLiteral("> <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">48% Complete</span></div>\r\n                            </div>\r\n                 " +
"       </li>\r\n                        <li>\r\n                            <h2>3250" +
"</h2>\r\n                            <small>From UAE</small>\r\n                    " +
"        <div");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">98% <i");

WriteLiteral(" class=\"fa fa-level-up text-success\"");

WriteLiteral("></i></div>\r\n                            <div");

WriteLiteral(" class=\"progress\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"progress-bar progress-bar-inverse\"");

WriteLiteral(" role=\"progressbar\"");

WriteLiteral(" aria-valuenow=\"50\"");

WriteLiteral(" aria-valuemin=\"0\"");

WriteLiteral(" aria-valuemax=\"100\"");

WriteLiteral(" style=\"width:98%;\"");

WriteLiteral("> <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(@">98% Complete</span></div>
                            </div>
                        </li>
                        <li>
                            <h2>1250</h2>
                            <small>From Australia</small>
                            <div");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">75% <i");

WriteLiteral(" class=\"fa fa-level-down text-danger\"");

WriteLiteral("></i></div>\r\n                            <div");

WriteLiteral(" class=\"progress\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"progress-bar progress-bar-danger\"");

WriteLiteral(" role=\"progressbar\"");

WriteLiteral(" aria-valuenow=\"50\"");

WriteLiteral(" aria-valuemin=\"0\"");

WriteLiteral(" aria-valuemax=\"100\"");

WriteLiteral(" style=\"width:75%;\"");

WriteLiteral("> <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">75% Complete</span></div>\r\n                            </div>\r\n                 " +
"       </li>\r\n                        <li>\r\n                            <h2>1350" +
"</h2>\r\n                            <small>From USA</small>\r\n                    " +
"        <div");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">48% <i");

WriteLiteral(" class=\"fa fa-level-up text-success\"");

WriteLiteral("></i></div>\r\n                            <div");

WriteLiteral(" class=\"progress\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"progress-bar progress-bar-info\"");

WriteLiteral(" role=\"progressbar\"");

WriteLiteral(" aria-valuenow=\"50\"");

WriteLiteral(" aria-valuemin=\"0\"");

WriteLiteral(" aria-valuemax=\"100\"");

WriteLiteral(" style=\"width:48%;\"");

WriteLiteral("> <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">48% Complete</span></div>\r\n                            </div>\r\n                 " +
"       </li>\r\n                        <li>\r\n                            <h2>350<" +
"/h2>\r\n                            <small>From UK</small>\r\n                      " +
"      <div");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">68% <i");

WriteLiteral(" class=\"fa fa-level-down text-danger\"");

WriteLiteral("></i></div>\r\n                            <div");

WriteLiteral(" class=\"progress\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"progress-bar progress-bar-purple\"");

WriteLiteral(" role=\"progressbar\"");

WriteLiteral(" aria-valuenow=\"50\"");

WriteLiteral(" aria-valuemin=\"0\"");

WriteLiteral(" aria-valuemax=\"100\"");

WriteLiteral(" style=\"width:68%;\"");

WriteLiteral("> <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">48% Complete</span></div>\r\n                            </div>\r\n                 " +
"       </li>\r\n                    </ul>\r\n                    <div");

WriteLiteral(" class=\"col-md-4 col-sm-4 col-xs-12 m-t-20 text-center\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"chart easy-pie-chart-2\"");

WriteLiteral(" data-percent=\"75\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"percent\"");

WriteLiteral(">75</span><br />\r\n                            <h4>New Users Visits</h4>\r\n        " +
"                </div>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-md-4 col-sm-4 col-xs-12 m-t-20 text-center\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"chart easy-pie-chart-1\"");

WriteLiteral(" data-percent=\"65\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"percent\"");

WriteLiteral(">75</span><br />\r\n                            <h4>Returning Users</h4>\r\n         " +
"               </div>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"col-md-4 col-sm-4 col-xs-12 m-t-20 text-center\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"chart easy-pie-chart-3\"");

WriteLiteral(" data-percent=\"25\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"percent\"");

WriteLiteral(">75</span><br />\r\n                            <h4>Bounce Rate</h4>\r\n             " +
"           </div>\r\n                    </div>\r\n                </div>\r\n         " +
"   </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--row -->\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-4 col-lg-4 col-xs-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"white-box\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral(">Browser Stats</h3>\r\n            <ul");

WriteLiteral(" class=\"basic-list\"");

WriteLiteral(">\r\n                <li>Google Chrome <span");

WriteLiteral(" class=\"pull-right label-danger label\"");

WriteLiteral(">21.8%</span></li>\r\n                <li>Mozila Firefox <span");

WriteLiteral(" class=\"pull-right label-purple label\"");

WriteLiteral(">21.8%</span></li>\r\n                <li>Apple Safari <span");

WriteLiteral(" class=\"pull-right label-success label\"");

WriteLiteral(">21.8%</span></li>\r\n                <li>Internet Explorer <span");

WriteLiteral(" class=\"pull-right label-info label\"");

WriteLiteral(">21.8%</span></li>\r\n                <li>Opera mini <span");

WriteLiteral(" class=\"pull-right label-warning label\"");

WriteLiteral(">21.8%</span></li>\r\n                <li>Mozila Firefox <span");

WriteLiteral(" class=\"pull-right label-purple label\"");

WriteLiteral(">21.8%</span></li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-md-4 col-xs-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"white-box\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral(">CPU LOAD</h3>\r\n            <div");

WriteLiteral(" class=\"stats-row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                    <h6>Usage</h6>\r\n                    <b>60GB</b>\r\n         " +
"       </div>\r\n                <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                    <h6>Space</h6>\r\n                    <b>320 GB</b>\r\n       " +
"         </div>\r\n                <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                    <h6>CPU</h6>\r\n                    <b>50%</b>\r\n            " +
"    </div>\r\n            </div>\r\n            <div");

WriteLiteral(" style=\"height: 280px;\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" id=\"placeholder\"");

WriteLiteral(" class=\"demo-placeholder\"");

WriteLiteral("></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-md-4 col-lg-4 col-xs-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"white-box\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"user-bg\"");

WriteLiteral(">\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 8928), Tuple.Create("\"", 8978)
, Tuple.Create(Tuple.Create("", 8934), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/images/large/img1.jpg")
, 8934), false)
);

WriteLiteral(" alt=\"user\"");

WriteLiteral(" style=\"100%\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"overlay-box\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"user-content\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><img");

WriteLiteral(" alt=\"img\"");

WriteLiteral(" class=\"thumb-lg img-circle\"");

WriteAttribute("src", Tuple.Create(" src=\"", 9192), Tuple.Create("\"", 9242)
, Tuple.Create(Tuple.Create("", 9198), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/images/users/genu.jpg")
, 9198), false)
);

WriteLiteral("></a>\r\n                        <h4");

WriteLiteral(" class=\"text-white\"");

WriteLiteral(">User Name</h4>\r\n                        <h5");

WriteLiteral(" class=\"text-white\"");

WriteLiteral(">info@myadmin.com</h5>\r\n                    </div>\r\n                </div>\r\n     " +
"       </div>\r\n            <div");

WriteLiteral(" class=\"user-btm-box\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-4 col-sm-4 text-center\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"text-purple\"");

WriteLiteral("><i");

WriteLiteral(" class=\"ti-facebook\"");

WriteLiteral("></i></p>\r\n                    <h1>258</h1>\r\n                </div>\r\n            " +
"    <div");

WriteLiteral(" class=\"col-md-4 col-sm-4 text-center\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"text-blue\"");

WriteLiteral("><i");

WriteLiteral(" class=\"ti-twitter\"");

WriteLiteral("></i></p>\r\n                    <h1>125</h1>\r\n                </div>\r\n            " +
"    <div");

WriteLiteral(" class=\"col-md-4 col-sm-4 text-center\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("><i");

WriteLiteral(" class=\"ti-dribbble\"");

WriteLiteral("></i></p>\r\n                    <h1>556</h1>\r\n                </div>\r\n            " +
"    <div");

WriteLiteral(" class=\"stats-row col-md-12 m-t-20 m-b-0 text-center\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"stat-item\"");

WriteLiteral(">\r\n                        <h6>Contact info</h6>\r\n                        <b><i");

WriteLiteral(" class=\"ti-mobile\"");

WriteLiteral("></i> 123-456-7890</b>\r\n                    </div>\r\n                </div>\r\n     " +
"       </div>\r\n        </div>\r\n    </div>\r\n    <!-- row -->\r\n    <!-- /.row -->\r" +
"\n</div>\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n    <!-- Flot Charts JavaScript -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10530), Tuple.Create("\"", 10595)
, Tuple.Create(Tuple.Create("", 10536), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/bower_components/flot/jquery.flot.js")
, 10536), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10619), Tuple.Create("\"", 10707)
, Tuple.Create(Tuple.Create("", 10625), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/bower_components/flot.tooltip/js/jquery.flot.tooltip.min.j" +
"s")
, 10625), false)
);

WriteLiteral("></script>\r\n    <!-- google maps api -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10761), Tuple.Create("\"", 10847)
, Tuple.Create(Tuple.Create("", 10767), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/bower_components/vectormap/jquery-jvectormap-2.0.2.min.js")
, 10767), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 10871), Tuple.Create("\"", 10961)
, Tuple.Create(Tuple.Create("", 10877), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/bower_components/vectormap/jquery-jvectormap-world-mill-en" +
".js")
, 10877), false)
);

WriteLiteral("></script>\r\n    <!-- Sparkline charts -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11016), Tuple.Create("\"", 11102)
, Tuple.Create(Tuple.Create("", 11022), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/bower_components/jquery-sparkline/jquery.sparkline.min.js")
, 11022), false)
);

WriteLiteral("></script>\r\n    <!-- EASY PIE CHART JS -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11158), Tuple.Create("\"", 11257)
, Tuple.Create(Tuple.Create("", 11164), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/bower_components/jquery.easy-pie-chart/dist/jquery.easypie" +
"chart.min.js")
, 11164), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11281), Tuple.Create("\"", 11371)
, Tuple.Create(Tuple.Create("", 11287), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/plugins/bower_components/jquery.easy-pie-chart/easy-pie-chart.init" +
".js")
, 11287), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11395), Tuple.Create("\"", 11432)
, Tuple.Create(Tuple.Create("", 11401), Tuple.Create<System.Object, System.Int32>(Href("~/assets/admin/js/dashboard2.js")
, 11401), false)
);

WriteLiteral(@"></script>
    <!-- Google Analytics -->
    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
                m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');
        ga('create', 'UA-XXXXX-Y', 'auto');
        ga('send', 'pageview');
    </script>
    <!-- End Google Analytics -->
");

});

        }
    }
}
#pragma warning restore 1591
