#pragma checksum "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6cee0502902b439325e6ad74ee691e64c1c309a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DojoActivities_Home), @"mvc.1.0.view", @"/Views/DojoActivities/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DojoActivities/Home.cshtml", typeof(AspNetCore.Views_DojoActivities_Home))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\_ViewImports.cshtml"
using DojoActivity;

#line default
#line hidden
#line 2 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\_ViewImports.cshtml"
using DojoActivity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6cee0502902b439325e6ad74ee691e64c1c309a", @"/Views/DojoActivities/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8457dd025be78c037bd06f59feefd4db5b05a17f", @"/Views/_ViewImports.cshtml")]
    public class Views_DojoActivities_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Activity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 173, true);
            WriteLiteral("\r\n<nav class=\"navbar navbar-dark bg-dark\">\r\n  <h1 class=\"text-white\">Dojo Activity Center</h1>\r\n    <p class=\"mr-auto display-inline\"> <pre><span class=\"text-white\">Welcome ");
            EndContext();
            BeginContext(197, 24, false);
#line 5 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
                                                                        Write(ViewBag.LoggedInUserName);

#line default
#line hidden
            EndContext();
            BeginContext(221, 553, true);
            WriteLiteral(@"</span>             <a href=""/Logout"">Log off</a></pre></p>
</nav>
<hr>
<div class=""container-fluid"">
    <table class=""table table-hover table-dark"">
        <thead>
            <tr>
                <th scope=""col"">Activity</th>
                <th scope=""col"">Date and Time</th>
                <th scope=""col"">Duration</th>
                <th scope=""col"">Event Coordinator</th>
                <th scope=""col"">Number of Participants</th>
                <th scope=""col"">Action</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
             foreach (var activity in @Model)
            {

#line default
#line hidden
            BeginContext(836, 40, true);
            WriteLiteral("            <tr>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 876, "\"", 917, 2);
            WriteAttributeValue("", 883, "/ViewActivity/", 883, 14, true);
#line 24 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
WriteAttributeValue("", 897, activity.ActivityId, 897, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(918, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(920, 14, false);
#line 24 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
                                                            Write(activity.Title);

#line default
#line hidden
            EndContext();
            BeginContext(934, 31, true);
            WriteLiteral("</a></td>\r\n                <td>");
            EndContext();
            BeginContext(966, 32, false);
#line 25 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
               Write(activity.Date.ToString("MMM dd"));

#line default
#line hidden
            EndContext();
            BeginContext(998, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(1003, 33, false);
#line 25 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
                                                    Write(activity.Time.ToString("hh':'mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1064, 17, false);
#line 26 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
               Write(activity.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1081, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1083, 22, false);
#line 26 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
                                  Write(activity.Duration_Type);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1133, 27, false);
#line 27 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
               Write(activity.Creator.First_Name);

#line default
#line hidden
            EndContext();
            BeginContext(1160, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1188, 24, false);
#line 28 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
               Write(activity.Attendees.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1212, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 29 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
                 if (activity.UserId == ViewBag.LoggedInUserId)
                {

#line default
#line hidden
            BeginContext(1303, 22, true);
            WriteLiteral("                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1325, "\"", 1360, 2);
            WriteAttributeValue("", 1332, "/Delete/", 1332, 8, true);
#line 31 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
WriteAttributeValue("", 1340, activity.ActivityId, 1340, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1361, 18, true);
            WriteLiteral(">Delete</a></td>\r\n");
            EndContext();
#line 32 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"

                }
                else
                {
                    if (activity.Status == false)
                    {

#line default
#line hidden
            BeginContext(1515, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1545, "\"", 1578, 2);
            WriteAttributeValue("", 1552, "/join/", 1552, 6, true);
#line 38 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
WriteAttributeValue("", 1558, activity.ActivityId, 1558, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1579, 16, true);
            WriteLiteral(">Join</a></td>\r\n");
            EndContext();
#line 39 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1669, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1699, "\"", 1734, 2);
            WriteAttributeValue("", 1706, "/unjoin/", 1706, 8, true);
#line 43 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
WriteAttributeValue("", 1714, activity.ActivityId, 1714, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1735, 17, true);
            WriteLiteral(">Leave</a></td>\r\n");
            EndContext();
#line 44 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"

                    }
                }

#line default
#line hidden
            BeginContext(1796, 27, true);
            WriteLiteral("            </tr>        \r\n");
            EndContext();
#line 48 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\Home.cshtml"
            }

#line default
#line hidden
            BeginContext(1838, 153, true);
            WriteLiteral("        \r\n        </tbody>\r\n    </table>\r\n</div>\r\n<br>\r\n<a href=\"/NewActivity\" class=\"btn btn-info btn-lg float-right\" role=\"button\">Add New Activity</a>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Activity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
