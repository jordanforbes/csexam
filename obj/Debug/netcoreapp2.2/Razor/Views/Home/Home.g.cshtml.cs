#pragma checksum "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d88babbedece88ea6761976f68d32b59c5d113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\_ViewImports.cshtml"
using exam;

#line default
#line hidden
#line 2 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\_ViewImports.cshtml"
using exam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d88babbedece88ea6761976f68d32b59c5d113", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecb2a55d59d82a6188c718c6158103bf5dc00b82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Jawn>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ToggleJawn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-status", "leave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-status", "join", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 375, true);
            WriteLiteral(@"<div class=""jumbotron"">
    <h1>Dojo Activity Center</h1>
</div>

<table class=""table"">
    <thead>
        <tr>
            <th>Activity</th>
            <th>Date and Time</th>
            <th>Duration</th>
            <th>Event Coordinator</th>
            <th>Number of Participants</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 18 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
         foreach(Jawn j in Model)
        {
            

#line default
#line hidden
#line 20 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
             if(j.StartTime >= DateTime.Now)
            {

#line default
#line hidden
            BeginContext(501, 40, true);
            WriteLiteral("            <tr>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 541, "\"", 563, 2);
            WriteAttributeValue("", 548, "/jawn/", 548, 6, true);
#line 23 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
WriteAttributeValue("", 554, j.JawnId, 554, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(564, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(566, 7, false);
#line 23 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
                                         Write(j.Title);

#line default
#line hidden
            EndContext();
            BeginContext(573, 31, true);
            WriteLiteral("</a></td>\r\n                <td>");
            EndContext();
            BeginContext(605, 30, false);
#line 24 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
               Write(j.StartTime.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(635, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(637, 2, true);
            WriteLiteral("@ ");
            EndContext();
            BeginContext(640, 26, false);
#line 24 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
                                                  Write(j.Date.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(666, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(694, 10, false);
#line 25 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
               Write(j.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(704, 35, true);
            WriteLiteral(" minutes</td>\r\n                <td>");
            EndContext();
            BeginContext(740, 16, false);
#line 26 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
               Write(j.Organizer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(756, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(784, 17, false);
#line 27 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
               Write(j.Attendees.Count);

#line default
#line hidden
            EndContext();
            BeginContext(801, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 29 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
                     if(@j.Organizer.UserId == @ViewBag.User.UserId)
                    {

#line default
#line hidden
            BeginContext(923, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 949, "\"", 978, 3);
            WriteAttributeValue("", 956, "/jawn/", 956, 6, true);
#line 31 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
WriteAttributeValue("", 962, j.JawnId, 962, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 971, "/delete", 971, 7, true);
            EndWriteAttribute();
            BeginContext(979, 88, true);
            WriteLiteral(" class=\"btn btn-danger\">\r\n                        Delete\r\n                        </a>\r\n");
            EndContext();
#line 34 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
                    }else{
                        

#line default
#line hidden
#line 35 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
                         if(j.Attendees.Any( a => a.UserId == ViewBag.User.UserId)){

#line default
#line hidden
            BeginContext(1181, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1209, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d88babbedece88ea6761976f68d32b59c5d11310204", async() => {
                BeginContext(1311, 5, true);
                WriteLiteral("Flake");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-jawnId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
                                                             WriteLiteral(j.JawnId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["jawnId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-jawnId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["jawnId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1320, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"

                        }else{

#line default
#line hidden
            BeginContext(1356, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1384, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d88babbedece88ea6761976f68d32b59c5d11313493", async() => {
                BeginContext(1485, 6, true);
                WriteLiteral("Attend");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-jawnId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
                                                             WriteLiteral(j.JawnId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["jawnId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-jawnId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["jawnId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1495, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
                        }

#line default
#line hidden
#line 40 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(1547, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"

            }

#line default
#line hidden
#line 46 "C:\Users\Jordf\onedrive\documents\coding\codingdojo\csharptime\exams\exam\Views\Home\Home.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1619, 228, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n <div class=\"row\">\r\n        <div class=\"col-lg-10\">\r\n        </div>\r\n        <div class=\"col-lg-2\">\r\n            <a href=\"/jawn/new\" class=\"btn btn-info\">Add New Activity</a>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Jawn>> Html { get; private set; }
    }
}
#pragma warning restore 1591
