#pragma checksum "C:\Projects\NotificationSystem\NotificationSystem\Notification.Api\Views\NotificationChannel\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7303d5bb4a27b27d4970ddf953dfadc4016b0f4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NotificationChannel_Post), @"mvc.1.0.view", @"/Views/NotificationChannel/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7303d5bb4a27b27d4970ddf953dfadc4016b0f4b", @"/Views/NotificationChannel/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b94b0adc7a7b4f3c164db135010efdf7d25ca286", @"/Views/_ViewImports.cshtml")]
    public class Views_NotificationChannel_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\NotificationSystem\NotificationSystem\Notification.Api\Views\NotificationChannel\Post.cshtml"
  
    ViewData["Title"] = " Notification Channel";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-12 col-xl-12"">
    <h2 class=""card-title mb-3""><span style=""font-size: 20px;""><strong>Add Notification Channel</strong></span></h2>
    <div class=""card"">
        <div class=""card-header"">
        </div>
        <div class=""card-body"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7303d5bb4a27b27d4970ddf953dfadc4016b0f4b4240", async() => {
                WriteLiteral(@"
                <div class=""mb-3 row form-validate"">
                    <label class=""col-form-label col-sm-2 text-sm-right"">Name</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" placeholder=""Full Name"" id=""name"">
                    </div>
                </div>
                <div class=""mb-3 row"">
                    <label class=""col-form-label col-sm-2 text-sm-right"">Description</label>
                    <div class=""col-sm-10"">
                        <textarea class=""form-control"" placeholder=""Description"" rows=""3"" id=""description""></textarea>
                    </div>
                </div>
                <div class=""mb-3 row"">
                    <div class=""col-sm-10 ml-sm-auto"">
                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<script>
    const form = document.getElementById('form');
    const name = document.getElementById('name');
    const description = document.getElementById('description');

    form.addEventListener('submit', (e) => {
        e.preventDefault();
        //custom function for checking valid input
        checkInput();
    });

    function checkInput() {
        //get value from input
        const nameValue = name.nodeValue.trim();
        const descriptionValue = description.nodeValue.trim();

        if (nameValue === '') {
            //show error
            //add error class
            setErrorFor(name, 'name cannot be blank');
        } else {
            //success class
            setSuccessFor(name);
        }

        if (descriptionValue === '') {
            //show error
            //add error class
            setErrorFor(description, 'description cannot be blank');
        } else {
            //success class
            s");
            WriteLiteral(@"etSuccessFor(description);
        }
    }

    function setErrorFor(input, message) {
        const formValidate = input.parentElement;
        const small = formValidate.querySelector('small');

        //add error message inside small
        small.innerText = message

        //add error class
        formValidate.className = 'form-validate error';
    }

    function setSuccessFor(input) {
        const formValidate = input.parentElement;

        formValidate.className = 'form-validate success';
    }
</script>







");
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
