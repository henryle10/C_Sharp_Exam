#pragma checksum "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "263c2731217ef74dfe0da09cfbc947cd3d0318fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\_ViewImports.cshtml"
using C_Sharp_Exam;

#line default
#line hidden
#line 2 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\_ViewImports.cshtml"
using C_Sharp_Exam.Models;

#line default
#line hidden
#line 3 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263c2731217ef74dfe0da09cfbc947cd3d0318fd", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2519257a7c28080513208906c29671ddaf66f59", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline-block; margin-left: 50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActivityInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewActivityPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(21, 201, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-8\">\r\n        <h2>Dojo Activity Center</h2>\r\n    </div>\r\n    <div class=\"col-sm-4\" style=\"margin: auto\">\r\n        <h4 style=\"display: inline-block;\">Welcome, ");
            EndContext();
            BeginContext(223, 17, false);
#line 8 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
                                               Write(ViewBag.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(240, 15, true);
            WriteLiteral("</h4>\r\n        ");
            EndContext();
            BeginContext(255, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263c2731217ef74dfe0da09cfbc947cd3d0318fd6305", async() => {
                BeginContext(349, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(359, 380, true);
            WriteLiteral(@"
    </div>
</div>
<hr style=""border: 1px solid black;"">
<table class=""table table-stripped table-bordered"">
    <thead>
        <tr>
            <th>Activity</th>
            <th>Date and Time</th>
            <th>Duration</th>
            <th>Event Coordinator</th>
            <th>No. of Participants</th>
            <th>Actions</th>
        </tr>
    </thead>
");
            EndContext();
#line 24 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
     foreach (Event e in Model)
    {

#line default
#line hidden
            BeginContext(779, 43, true);
            WriteLiteral("    <tbody>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(822, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263c2731217ef74dfe0da09cfbc947cd3d0318fd8675", async() => {
                BeginContext(900, 6, false);
#line 28 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
                                                                                        Write(e.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
                                                                     WriteLiteral(e.EventId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(910, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(934, 12, false);
#line 29 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
           Write(e.Date.Month);

#line default
#line hidden
            EndContext();
            BeginContext(946, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(948, 10, false);
#line 29 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
                         Write(e.Date.Day);

#line default
#line hidden
            EndContext();
            BeginContext(958, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(963, 6, false);
#line 29 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
                                        Write(e.Time);

#line default
#line hidden
            EndContext();
            BeginContext(969, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(993, 10, false);
#line 30 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
           Write(e.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1005, 11, false);
#line 30 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
                       Write(e.HourOrMin);

#line default
#line hidden
            EndContext();
            BeginContext(1016, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1040, 14, false);
#line 31 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
           Write(e.Creator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1054, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1078, 17, false);
#line 32 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
           Write(e.EventList.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1095, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 33 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
             if (e.Creator.UserId == @ViewBag.uid )
            {

#line default
#line hidden
            BeginContext(1170, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1190, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263c2731217ef74dfe0da09cfbc947cd3d0318fd14375", async() => {
                BeginContext(1261, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
                                                                   WriteLiteral(e.EventId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1271, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 36 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
            }
            else
            {
                

#line default
#line hidden
#line 39 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
                 if(@e.EventList.Any(user => user.UserId == @ViewBag.uid))
                {

#line default
#line hidden
            BeginContext(1421, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1447, "\"", 1471, 2);
            WriteAttributeValue("", 1454, "/Leave/", 1454, 7, true);
#line 41 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1461, e.EventId, 1461, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1472, 18, true);
            WriteLiteral(">Leave</a></td> \r\n");
            EndContext();
#line 42 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1550, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1576, "\"", 1599, 2);
            WriteAttributeValue("", 1583, "/Join/", 1583, 6, true);
#line 45 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1589, e.EventId, 1589, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1600, 17, true);
            WriteLiteral(">Join</a></td> \r\n");
            EndContext();
#line 46 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
                }

#line default
#line hidden
#line 46 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1651, 29, true);
            WriteLiteral("        </tr>\r\n    </tbody>\r\n");
            EndContext();
#line 50 "C:\Users\henry\OneDrive\Documents\Coding Practice\C# Exam\C_Sharp_Exam\Views\Home\Dashboard.cshtml"
    }

#line default
#line hidden
            BeginContext(1687, 40, true);
            WriteLiteral("</table>\r\n<div class=\"text-right\">\r\n    ");
            EndContext();
            BeginContext(1727, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263c2731217ef74dfe0da09cfbc947cd3d0318fd19634", async() => {
                BeginContext(1802, 16, true);
                WriteLiteral("Add New Activity");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1822, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
