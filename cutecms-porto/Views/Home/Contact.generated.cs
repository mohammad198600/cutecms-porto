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
    
    #line 3 "..\..\Views\Home\Contact.cshtml"
    using System.Data.Entity.Core.Objects;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    
    #line 2 "..\..\Views\Home\Contact.cshtml"
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
    
    #line 6 "..\..\Views\Home\Contact.cshtml"
    using cutecms_porto.Areas.Config.Models.DBModel;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Home\Contact.cshtml"
    using cutecms_porto.Areas.Identity.Models.DBModel;
    
    #line default
    #line hidden
    using cutecms_porto.Helpers;
    
    #line 5 "..\..\Views\Home\Contact.cshtml"
    using cutecms_porto.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Contact.cshtml")]
    public partial class _Views_Home_Contact_cshtml : System.Web.Mvc.WebViewPage<OrganizationViewModel>
    {
        public _Views_Home_Contact_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\Views\Home\Contact.cshtml"
  
    ViewBag.Title = Resources.Resources.ContactUs;
    IdentityEntities identityDb = new IdentityEntities();
    ConfigEntities configDb = new ConfigEntities();

            
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

            
            #line 18 "..\..\Views\Home\Contact.cshtml"
                   Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>" +
"\r\n    <div");

WriteLiteral(" id=\"googlemaps\"");

WriteLiteral(" class=\"google-map\"");

WriteLiteral("></div>\r\n");

});

WriteLiteral("<!-- Google Maps - Go to the bottom of the page to change settings and map locati" +
"on. -->\r\n\r\n<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"mb-sm mt-sm\"");

WriteLiteral("><strong>");

            
            #line 30 "..\..\Views\Home\Contact.cshtml"
                                       Write(Resources.Resources.ContactUs);

            
            #line default
            #line hidden
WriteLiteral("</strong></h2>\r\n");

            
            #line 31 "..\..\Views\Home\Contact.cshtml"
            
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Home\Contact.cshtml"
             using (Html.BeginForm("Contact", "Home", FormMethod.Post))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 36 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.LabelFor(model => model.SenderName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 37 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.TextBoxFor(model => model.SenderName, "", new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 38 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.ValidationMessageFor(model => model.SenderName, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 41 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.LabelFor(model => model.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 42 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.TextBoxFor(model => model.Email, "", new { @class = "form-control", @maxlength = "100", placeholder = "example@mail.com" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 43 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 48 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.LabelFor(model => model.Phone));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 49 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.TextBoxFor(model => model.Phone, "", new { @class = "form-control", @maxlength = "100" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 56 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.LabelFor(model => model.Subject));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 57 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.TextBoxFor(model => model.Subject, "", new { @class = "form-control", @maxlength = "100" }));

            
            #line default
            #line hidden
WriteLiteral("  ");

WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 58 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Subject, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 65 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.LabelFor(model => model.Message));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 66 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.TextAreaFor(model => model.Message, new { @class = "form-control", @maxlength = "100", @rows = 14 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 67 "..\..\Views\Home\Contact.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Message, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3558), Tuple.Create("\"", 3591)
            
            #line 73 "..\..\Views\Home\Contact.cshtml"
, Tuple.Create(Tuple.Create("", 3566), Tuple.Create<System.Object, System.Int32>(Resources.Resources.Send
            
            #line default
            #line hidden
, 3566), false)
);

WriteLiteral(" class=\"btn btn-primary btn-lg mb-xlg\"");

WriteLiteral(" data-loading-text=\"Loading...\"");

WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n");

            
            #line 76 "..\..\Views\Home\Contact.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n            <h4");

WriteLiteral(" class=\"heading-primary mt-lg\"");

WriteLiteral("><strong>");

            
            #line 79 "..\..\Views\Home\Contact.cshtml"
                                                 Write(Resources.Resources.GetInTouch);

            
            #line default
            #line hidden
WriteLiteral("</strong></h4>\r\n            ");

WriteLiteral("<p></p><p></p><p></p><p></p>\r\n            <hr>\r\n");

            
            #line 82 "..\..\Views\Home\Contact.cshtml"
            
            
            #line default
            #line hidden
            
            #line 82 "..\..\Views\Home\Contact.cshtml"
             if (Model.Organization != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <h4");

WriteLiteral(" class=\"heading-primary\"");

WriteLiteral(">");

            
            #line 84 "..\..\Views\Home\Contact.cshtml"
                                       Write(Model.Organization.Name);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");

WriteLiteral("                <ul");

WriteLiteral(" class=\"list list-icons list-icons-style-3 mb-xlg\"");

WriteLiteral(">\r\n                    <li><i");

WriteLiteral(" class=\"fa fa-map-marker\"");

WriteLiteral("></i> ");

            
            #line 86 "..\..\Views\Home\Contact.cshtml"
                                                    Write(Model.Organization.AddressLine1);

            
            #line default
            #line hidden
WriteLiteral("<br />");

            
            #line 86 "..\..\Views\Home\Contact.cshtml"
                                                                                          Write(Model.Organization.City);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 86 "..\..\Views\Home\Contact.cshtml"
                                                                                                                    Write(Model.Organization.State);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 86 "..\..\Views\Home\Contact.cshtml"
                                                                                                                                               Write(Model.Organization.ZIP);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 86 "..\..\Views\Home\Contact.cshtml"
                                                                                                                                                                        Write(Model.Organization.Country);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li><i");

WriteLiteral(" class=\"fa fa-phone\"");

WriteLiteral("></i><span> ");

            
            #line 87 "..\..\Views\Home\Contact.cshtml"
                                                      Write(Model.Organization.Telephone ?? Resources.Resources.NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                    <li><i");

WriteLiteral(" class=\"fa fa-envelope\"");

WriteLiteral("></i> <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4776), Tuple.Create("\"", 4815)
, Tuple.Create(Tuple.Create("", 4783), Tuple.Create("mailto:", 4783), true)
            
            #line 88 "..\..\Views\Home\Contact.cshtml"
, Tuple.Create(Tuple.Create("", 4790), Tuple.Create<System.Object, System.Int32>(Model.Organization.Email
            
            #line default
            #line hidden
, 4790), false)
);

WriteLiteral(">");

            
            #line 88 "..\..\Views\Home\Contact.cshtml"
                                                                                              Write(Model.Organization.Email ?? Resources.Resources.NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n                </ul>\r\n");

            
            #line 90 "..\..\Views\Home\Contact.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 91 "..\..\Views\Home\Contact.cshtml"
              
                configDb.Configuration.LazyLoadingEnabled = true;
                var query = (from p in configDb.ConfigDepartments
                             join c in configDb.Contacts on p.Id equals c.DepartmentId
                             where p.TenantId.Equals(Tenant.TenantId) && p.Contacts.Where(c => c.Organization.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).Any() && p.Contacts.Where(c => c.Organization.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name) && c.Organization.IsDefault && c.Organization.TenantId.Equals(Tenant.TenantId)).Any()
                             select p).Distinct().OrderBy(p => p.Ordinal);
            
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 98 "..\..\Views\Home\Contact.cshtml"
            
            
            #line default
            #line hidden
            
            #line 98 "..\..\Views\Home\Contact.cshtml"
             foreach (var item in query)
            {

            
            #line default
            #line hidden
WriteLiteral("                <h4");

WriteLiteral(" class=\"heading-primary\"");

WriteLiteral(">");

            
            #line 100 "..\..\Views\Home\Contact.cshtml"
                                        Write(item.DepartmentTerms.Where(d => d.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name) && d.DepartmentId == item.Id).FirstOrDefault()?.Value ?? item.Code);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");

            
            #line 101 "..\..\Views\Home\Contact.cshtml"
                foreach (var contact in item.Contacts.Where(c => c.Organization.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name)).OrderBy(c => c.Ordinal))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <ul");

WriteLiteral(" class=\"list list-icons list-icons-style-3 mb-xlg\"");

WriteLiteral(">\r\n                        <li><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i><span> ");

            
            #line 104 "..\..\Views\Home\Contact.cshtml"
                                                        Write(string.Format(contact.PersonalTitle.PersonalTitleTerms.Where(p => p.Language.CultureName.Trim().Equals(Thread.CurrentThread.CurrentCulture.Name) && p.PersonalTitleId == contact.PersonalTitleId).FirstOrDefault().Value + " " + "{0}", @contact.Name));

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 104 "..\..\Views\Home\Contact.cshtml"
                                                                                                                                                                                                                                                                                                                 Write(contact.Position);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n");

            
            #line 105 "..\..\Views\Home\Contact.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 105 "..\..\Views\Home\Contact.cshtml"
                         foreach (var phoneNumber in contact.PhoneNumbers)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li><i");

WriteLiteral(" class=\"fa fa-phone\"");

WriteLiteral("></i><span>");

            
            #line 107 "..\..\Views\Home\Contact.cshtml"
                                                             Write(phoneNumber.Number ?? Resources.Resources.NotAvailable);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 107 "..\..\Views\Home\Contact.cshtml"
                                                                                                                       Write(Resources.Resources.Extension);

            
            #line default
            #line hidden
WriteLiteral(": ");

            
            #line 107 "..\..\Views\Home\Contact.cshtml"
                                                                                                                                                        Write(phoneNumber.Extension ?? Resources.Resources.NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n");

            
            #line 108 "..\..\Views\Home\Contact.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <li><i");

WriteLiteral(" class=\"fa fa-map-marker\"");

WriteLiteral("></i><span>");

            
            #line 109 "..\..\Views\Home\Contact.cshtml"
                                                             Write(contact.Office);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                        <li><i");

WriteLiteral(" class=\"fa fa-envelope\"");

WriteLiteral("></i> <a");

WriteAttribute("href", Tuple.Create(" href=\"", 7080), Tuple.Create("\"", 7110)
, Tuple.Create(Tuple.Create("", 7087), Tuple.Create("mailto:", 7087), true)
            
            #line 110 "..\..\Views\Home\Contact.cshtml"
, Tuple.Create(Tuple.Create("", 7094), Tuple.Create<System.Object, System.Int32>(contact.Email
            
            #line default
            #line hidden
, 7094), false)
);

WriteLiteral(">");

            
            #line 110 "..\..\Views\Home\Contact.cshtml"
                                                                                         Write(contact.Email ?? Resources.Resources.NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n                    </ul>\r\n");

            
            #line 112 "..\..\Views\Home\Contact.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 114 "..\..\Views\Home\Contact.cshtml"
              configDb.Configuration.LazyLoadingEnabled = false; 
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"post-block post-share\"");

WriteLiteral(">\r\n        <h3");

WriteLiteral(" class=\"heading-primary\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-share\"");

WriteLiteral("></i>");

            
            #line 119 "..\..\Views\Home\Contact.cshtml"
                                                          Write(Resources.Resources.Share);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n        <!-- AddThis Button BEGIN -->\r\n        <div");

WriteLiteral(" class=\"addthis_toolbox addthis_default_style \"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"addthis_button_facebook_like\"");

WriteLiteral(" fb:like:layout=\"button_count\"");

WriteLiteral("></a>\r\n            <a");

WriteLiteral(" class=\"addthis_button_tweet\"");

WriteLiteral("></a>\r\n            <a");

WriteLiteral(" class=\"addthis_button_pinterest_pinit\"");

WriteLiteral("></a>\r\n            <a");

WriteLiteral(" class=\"addthis_counter addthis_pill_style\"");

WriteLiteral("></a>\r\n        </div>\r\n        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"//s7.addthis.com/js/300/addthis_widget.js#pubid=xa-50faf75173aadc53\"");

WriteLiteral("></script>\r\n        <!-- AddThis Button END -->\r\n    </div>\r\n</div>\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n\r\n    <script");

WriteLiteral(" src=\"https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY\"");

WriteLiteral("></script>\r\n    <script>\r\n\r\n        /*\r\n        Map Settings\r\n\r\n            Find " +
"the Latitude and Longitude of your address:\r\n                - http://universimm" +
"edia.pagesperso-orange.fr/geo/loc.htm\r\n                - http://www.findlatitude" +
"andlongitude.com/find-address-from-latitude-and-longitude/\r\n\r\n        */\r\n\r\n    " +
"    // Map Markers\r\n        var mapMarkers = [{\r\n            address: \"New York," +
" NY 10017\",\r\n            html: \"<strong>New York Office</strong><br>New York, NY" +
" 10017\",\r\n            icon: {\r\n                image: \"assets/porto/img/pin.png\"" +
",\r\n                iconsize: [26, 46],\r\n                iconanchor: [12, 46]\r\n  " +
"          },\r\n            popup: true\r\n        }];\r\n\r\n        // Map Initial Loc" +
"ation\r\n        var initLatitude = 40.75198;\r\n        var initLongitude = -73.969" +
"78;\r\n\r\n        // Map Extended Settings\r\n        var mapSettings = {\r\n          " +
"  controls: {\r\n                draggable: (($.browser.mobile) ? false : true),\r\n" +
"                panControl: true,\r\n                zoomControl: true,\r\n         " +
"       mapTypeControl: true,\r\n                scaleControl: true,\r\n             " +
"   streetViewControl: true,\r\n                overviewMapControl: true\r\n         " +
"   },\r\n            scrollwheel: false,\r\n            markers: mapMarkers,\r\n      " +
"      latitude: initLatitude,\r\n            longitude: initLongitude,\r\n          " +
"  zoom: 16\r\n        };\r\n\r\n        var map = $(\'#googlemaps\').gMap(mapSettings);\r" +
"\n\r\n        // Map Center At\r\n        var mapCenterAt = function (options, e) {\r\n" +
"            e.preventDefault();\r\n            $(\'#googlemaps\').gMap(\"centerAt\", o" +
"ptions);\r\n        }\r\n\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
