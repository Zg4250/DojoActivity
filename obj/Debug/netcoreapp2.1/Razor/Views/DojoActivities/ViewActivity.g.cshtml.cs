#pragma checksum "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f0d6d1593bd8339d2abae4e2de89f1f626f80f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DojoActivities_ViewActivity), @"mvc.1.0.view", @"/Views/DojoActivities/ViewActivity.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DojoActivities/ViewActivity.cshtml", typeof(AspNetCore.Views_DojoActivities_ViewActivity))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f0d6d1593bd8339d2abae4e2de89f1f626f80f1", @"/Views/DojoActivities/ViewActivity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8457dd025be78c037bd06f59feefd4db5b05a17f", @"/Views/_ViewImports.cshtml")]
    public class Views_DojoActivities_ViewActivity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Roster>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 252, true);
            WriteLiteral("\r\n<nav class=\"navbar navbar-dark bg-dark\">\r\n  <h1 class=\"text-white\">Dojo Activity Center</h1>\r\n    <p class=\"mr-auto display-inline\"> <pre><a href = \"/Home\">Home</a>             <a href=\"/Logout\">Log off</a></pre></p>\r\n</nav>\r\n<hr>\r\n<br><br>\r\n<button>");
            EndContext();
#line 9 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"
         if (ViewBag.this_Activity.UserId == ViewBag.LoggedInUserId)
                {

#line default
#line hidden
            BeginContext(354, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 372, "\"", 420, 2);
            WriteAttributeValue("", 379, "/Delete/", 379, 8, true);
#line 11 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"
WriteAttributeValue("", 387, ViewBag.this_Activity.ActivityId, 387, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(421, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 12 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"

                }
                else
                {
                    if (ViewBag.this_Activity.Status == false)
                    {

#line default
#line hidden
            BeginContext(583, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 609, "\"", 655, 2);
            WriteAttributeValue("", 616, "/join/", 616, 6, true);
#line 18 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"
WriteAttributeValue("", 622, ViewBag.this_Activity.ActivityId, 622, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(656, 11, true);
            WriteLiteral(">Join</a>\r\n");
            EndContext();
#line 19 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(741, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 767, "\"", 815, 2);
            WriteAttributeValue("", 774, "/unjoin/", 774, 8, true);
#line 23 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"
WriteAttributeValue("", 782, ViewBag.this_Activity.ActivityId, 782, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(816, 12, true);
            WriteLiteral(">Leave</a>\r\n");
            EndContext();
#line 24 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"

                    }
                }

#line default
#line hidden
            BeginContext(870, 15, true);
            WriteLiteral("</button>\r\n<h2>");
            EndContext();
            BeginContext(886, 13, false);
#line 27 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(899, 71, true);
            WriteLiteral("</h2>\r\n<br>\r\n<div class=\"container-fluid\">\r\n    <h4>Event Coordinator: ");
            EndContext();
            BeginContext(971, 19, false);
#line 30 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"
                      Write(ViewBag.Coordinator);

#line default
#line hidden
            EndContext();
            BeginContext(990, 48, true);
            WriteLiteral("</h4>\r\n    <br>\r\n    <br>\r\n    <h4>Description: ");
            EndContext();
            BeginContext(1039, 19, false);
#line 33 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"
                Write(ViewBag.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1058, 55, true);
            WriteLiteral("</h4>\r\n    <br>\r\n    <h4>Participants:</h4>\r\n    <ul>\r\n");
            EndContext();
#line 37 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"
     foreach (var participant in @Model)
    {

#line default
#line hidden
            BeginContext(1162, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(1175, 27, false);
#line 39 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"
       Write(participant.User.First_Name);

#line default
#line hidden
            EndContext();
            BeginContext(1202, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 40 "C:\Users\ZGX\Documents\CSharp\DojoActivity\Views\DojoActivities\ViewActivity.cshtml"
    }

#line default
#line hidden
            BeginContext(1216, 17, true);
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Roster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
