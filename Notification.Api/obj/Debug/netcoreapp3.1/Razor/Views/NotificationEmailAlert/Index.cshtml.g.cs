#pragma checksum "C:\Projects\NotificationSystem\NotificationSystem\Notification.Api\Views\NotificationEmailAlert\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e9f0cec93f2336639629e6e3729564a543e0bf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NotificationEmailAlert_Index), @"mvc.1.0.view", @"/Views/NotificationEmailAlert/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Projects\NotificationSystem\NotificationSystem\Notification.Api\Views\_ViewImports.cshtml"
using Notification.Api;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\NotificationSystem\NotificationSystem\Notification.Api\Views\_ViewImports.cshtml"
using Notification.Api.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e9f0cec93f2336639629e6e3729564a543e0bf7", @"/Views/NotificationEmailAlert/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b94b0adc7a7b4f3c164db135010efdf7d25ca286", @"/Views/_ViewImports.cshtml")]
    public class Views_NotificationEmailAlert_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NotificationEmailAlert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 1 "C:\Projects\NotificationSystem\NotificationSystem\Notification.Api\Views\NotificationEmailAlert\Index.cshtml"
  
    ViewData["Title"] = " Notification Email Alert";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid p-0"">

    <div class=""row"">

        <div class=""col-12 col-xl-12"">
            <h2 class=""card-title""><span style=""font-size: 20px;""><strong>Email Notification</strong></span></h2>
            <div class=""card"">
                <div class=""card-header"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e9f0cec93f2336639629e6e3729564a543e0bf74749", async() => {
                WriteLiteral("Add Email Notification");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <br />
                </div>
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>Email</th>
                            <th>Subject</th>
                            <th>Message</th>
                            <th>Receiver Name</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>

                        <tr>
                            <td>Johnsonblack@yahoo.com</td>
                            <td>Internship Role</td>
                            <td>I wish to apply for the role of a software developer at your sweet reputable firm, please accept me!</td>
                            <td>James Rodriguez</td>
                            <td class=""table-action"">
                                <a href=""#""><i class=""align-middle"" style=""color:blue"" data-feather=""edit-2""></i></a>
                    ");
            WriteLiteral(@"            <a href=""#""><i class=""align-middle"" style=""color:red"" data-feather=""trash""></i></a>
                            </td>
                        </tr>
                        <tr>
                            <td>Emiliarice@yahoo.com</td>
                            <td>Internship Role</td>
                            <td>I wish to apply for the role of a software developer at your sweet reputable firm, please accept me!</td>
                            <td>Jason Vorhez</td>
                            <td class=""table-action"">
                                <a href=""#""><i class=""align-middle"" style=""color:blue"" data-feather=""edit-2""></i></a>
                                <a href=""#""><i class=""align-middle"" style=""color:red"" data-feather=""trash""></i></a>
                            </td>
                        </tr>
                        <tr>
                            <td>clarkville@yahoo.com</td>
                            <td>Internship Role</td>
                            ");
            WriteLiteral(@"<td>I wish to apply for the role of a software developer at your sweet reputable firm, please accept me!</td>
                            <td>Jonny Bravo</td>
                            <td class=""table-action"">
                                <a href=""#""><i class=""align-middle"" style=""color:blue"" data-feather=""edit-2""></i></a>
                                <a href=""#""><i class=""align-middle"" style=""color:red"" data-feather=""trash""></i></a>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>

    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
