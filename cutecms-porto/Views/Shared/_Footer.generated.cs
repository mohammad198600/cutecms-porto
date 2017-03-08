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
    
    #line 3 "..\..\Views\Shared\_Footer.cshtml"
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
    
    #line 2 "..\..\Views\Shared\_Footer.cshtml"
    using cutecms_porto.Areas.CMS.Models.DBModel;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Shared\_Footer.cshtml"
    using cutecms_porto.Areas.Config.Models.DBModel;
    
    #line default
    #line hidden
    using cutecms_porto.Helpers;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Footer.cshtml")]
    public partial class _Views_Shared__Footer_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Footer_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\_Footer.cshtml"
  
    CMSEntities db = new CMSEntities();
    var organizations = (List<Organization>)HttpRuntime.Cache["Organizations"];
    var organization = organizations.Where(o => o.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).FirstOrDefault();
    IEnumerable<MenuItem> footerMenuItems = db.MenuItems.Include("Status").Include("Menu").Include("Language").Where(m => m.Menu.TenantId.Trim().Equals(Tenant.TenantId) && m.Menu.Code.Trim().Equals("footer-menu") && m.Status.Code.Trim().Equals("published") && m.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).OrderBy(o => o.Ordinal);

            
            #line default
            #line hidden
WriteLiteral("\r\n<footer");

WriteLiteral(" id=\"footer\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"footer-ribbon\"");

WriteLiteral(">\r\n                <span>");

            
            #line 14 "..\..\Views\Shared\_Footer.cshtml"
                 Write(Resources.Resources.KeepInTouch);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"newsletter\"");

WriteLiteral(">\r\n                    <h4>");

            
            #line 18 "..\..\Views\Shared\_Footer.cshtml"
                   Write(Resources.Resources.Newsletter);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                    <p>");

            
            #line 19 "..\..\Views\Shared\_Footer.cshtml"
                  Write(Resources.Resources.SubscriptionMessage);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\r\n                    ");

WriteLiteral("\r\n");

            
            #line 26 "..\..\Views\Shared\_Footer.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Shared\_Footer.cshtml"
                      
                        cutecms_porto.Models.SubscriberViewModel subscriber = new cutecms_porto.Models.SubscriberViewModel();
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 29 "..\..\Views\Shared\_Footer.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Shared\_Footer.cshtml"
                      Html.RenderPartial("~/Views/Shared/Subscribe.cshtml", subscriber);
            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                <h4>");

            
            #line 33 "..\..\Views\Shared\_Footer.cshtml"
               Write(Resources.Resources.LatestTweets);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                <div");

WriteLiteral(" id=\"tweet\"");

WriteLiteral(" class=\"twitter\"");

WriteLiteral(" data-plugin-tweets");

WriteLiteral(" data-plugin-options=\'{\"username\": \"\", \"count\": 2}\'");

WriteLiteral(">\r\n                    <p>");

            
            #line 35 "..\..\Views\Shared\_Footer.cshtml"
                  Write(Resources.Resources.PleaseWait);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"contact-details\"");

WriteLiteral(">\r\n                    <h4>");

            
            #line 40 "..\..\Views\Shared\_Footer.cshtml"
                   Write(Resources.Resources.ContactUs);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");

            
            #line 41 "..\..\Views\Shared\_Footer.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Shared\_Footer.cshtml"
                     if (organization != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <ul");

WriteLiteral(" class=\"contact\"");

WriteLiteral(">\r\n                            <li><p><i");

WriteLiteral(" class=\"fa fa-map-marker\"");

WriteLiteral("></i> <strong>");

            
            #line 44 "..\..\Views\Shared\_Footer.cshtml"
                                                                       Write(Resources.Resources.Address);

            
            #line default
            #line hidden
WriteLiteral(":</strong> ");

            
            #line 44 "..\..\Views\Shared\_Footer.cshtml"
                                                                                                              Write(organization.AddressLine1);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 44 "..\..\Views\Shared\_Footer.cshtml"
                                                                                                                                          Write(organization.City);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 44 "..\..\Views\Shared\_Footer.cshtml"
                                                                                                                                                              Write(organization.Country);

            
            #line default
            #line hidden
WriteLiteral("</p></li>\r\n                            <li><p><i");

WriteLiteral(" class=\"fa fa-phone\"");

WriteLiteral("></i> <strong>");

            
            #line 45 "..\..\Views\Shared\_Footer.cshtml"
                                                                  Write(Resources.Resources.Phone);

            
            #line default
            #line hidden
WriteLiteral(":</strong> ");

            
            #line 45 "..\..\Views\Shared\_Footer.cshtml"
                                                                                                       Write(organization.Telephone);

            
            #line default
            #line hidden
WriteLiteral("</p></li>\r\n                            <li><p><i");

WriteLiteral(" class=\"fa fa-envelope\"");

WriteLiteral("></i> <strong>");

            
            #line 46 "..\..\Views\Shared\_Footer.cshtml"
                                                                     Write(Resources.Resources.Email);

            
            #line default
            #line hidden
WriteLiteral(":</strong> <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2824), Tuple.Create("\"", 2857)
, Tuple.Create(Tuple.Create("", 2831), Tuple.Create("mailto:", 2831), true)
            
            #line 46 "..\..\Views\Shared\_Footer.cshtml"
                                               , Tuple.Create(Tuple.Create("", 2838), Tuple.Create<System.Object, System.Int32>(organization.Email
            
            #line default
            #line hidden
, 2838), false)
);

WriteLiteral(">");

            
            #line 46 "..\..\Views\Shared\_Footer.cshtml"
                                                                                                                                               Write(organization.Email);

            
            #line default
            #line hidden
WriteLiteral("</a></p></li>\r\n                        </ul>\r\n");

            
            #line 48 "..\..\Views\Shared\_Footer.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                <h4>");

            
            #line 52 "..\..\Views\Shared\_Footer.cshtml"
               Write(Resources.Resources.FollowUs);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n\r\n");

            
            #line 54 "..\..\Views\Shared\_Footer.cshtml"
                
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Shared\_Footer.cshtml"
                 if (organization != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <ul");

WriteLiteral(" class=\"social-icons\"");

WriteLiteral(">\r\n");

            
            #line 57 "..\..\Views\Shared\_Footer.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Shared\_Footer.cshtml"
                         foreach (var item in organization.SocialNetworks.OrderBy(s => s.Ordinal))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li");

WriteAttribute("class", Tuple.Create(" class=\"", 3353), Tuple.Create("\"", 3384)
, Tuple.Create(Tuple.Create("", 3361), Tuple.Create("social-icons-", 3361), true)
            
            #line 59 "..\..\Views\Shared\_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 3374), Tuple.Create<System.Object, System.Int32>(item.Code
            
            #line default
            #line hidden
, 3374), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3388), Tuple.Create("\"", 3404)
            
            #line 59 "..\..\Views\Shared\_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 3395), Tuple.Create<System.Object, System.Int32>(item.Url
            
            #line default
            #line hidden
, 3395), false)
);

WriteLiteral(" target=\"_blank\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3421), Tuple.Create("\"", 3439)
            
            #line 59 "..\..\Views\Shared\_Footer.cshtml"
                           , Tuple.Create(Tuple.Create("", 3429), Tuple.Create<System.Object, System.Int32>(item.Name
            
            #line default
            #line hidden
, 3429), false)
);

WriteLiteral("><i");

WriteAttribute("class", Tuple.Create(" class=\"", 3443), Tuple.Create("\"", 3468)
, Tuple.Create(Tuple.Create("", 3451), Tuple.Create("fa", 3451), true)
            
            #line 59 "..\..\Views\Shared\_Footer.cshtml"
                                                   , Tuple.Create(Tuple.Create(" ", 3453), Tuple.Create<System.Object, System.Int32>(item.CssClass
            
            #line default
            #line hidden
, 3454), false)
);

WriteLiteral("></i></a></li>\r\n");

            
            #line 60 "..\..\Views\Shared\_Footer.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n");

            
            #line 62 "..\..\Views\Shared\_Footer.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"footer-copyright\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-1\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3768), Tuple.Create("\"", 3800)
, Tuple.Create(Tuple.Create("", 3775), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/index.html")
, 3775), false)
);

WriteLiteral(" class=\"logo\"");

WriteLiteral(">\r\n                        <img");

WriteLiteral(" alt=\"CuteCMS.NET\"");

WriteLiteral(" class=\"img-responsive\"");

WriteAttribute("src", Tuple.Create(" src=\"", 3886), Tuple.Create("\"", 3926)
, Tuple.Create(Tuple.Create("", 3892), Tuple.Create<System.Object, System.Int32>(Href("~/assets/porto/img/footer-logo.png")
, 3892), false)
);

WriteLiteral(">\r\n                    </a>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-7\"");

WriteLiteral(">\r\n                    <p>© ");

            
            #line 75 "..\..\Views\Shared\_Footer.cshtml"
                    Write(DateTime.Now.Year);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 75 "..\..\Views\Shared\_Footer.cshtml"
                                        Write(organization?.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 75 "..\..\Views\Shared\_Footer.cshtml"
                                                               Write(Resources.Resources.CopyRights);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n                    <nav");

WriteLiteral(" id=\"sub-menu\"");

WriteLiteral(">\r\n                        <ul>\r\n");

            
            #line 80 "..\..\Views\Shared\_Footer.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 80 "..\..\Views\Shared\_Footer.cshtml"
                             foreach (var item in footerMenuItems)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 4397), Tuple.Create("\"", 4414)
            
            #line 82 "..\..\Views\Shared\_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 4404), Tuple.Create<System.Object, System.Int32>(item.Path
            
            #line default
            #line hidden
, 4404), false)
);

WriteLiteral(">");

            
            #line 82 "..\..\Views\Shared\_Footer.cshtml"
                                                    Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 83 "..\..\Views\Shared\_Footer.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("\r\n                        </ul>\r\n                    </nav>\r\n                </di" +
"v>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</footer>\r\n");

        }
    }
}
#pragma warning restore 1591
