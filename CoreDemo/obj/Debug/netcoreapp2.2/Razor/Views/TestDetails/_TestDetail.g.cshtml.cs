#pragma checksum "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7694752188fd1d197a4e616dc97a032ca99d6e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestDetails__TestDetail), @"mvc.1.0.view", @"/Views/TestDetails/_TestDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TestDetails/_TestDetail.cshtml", typeof(AspNetCore.Views_TestDetails__TestDetail))]
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
#line 1 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#line 2 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#line 3 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Data.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7694752188fd1d197a4e616dc97a032ca99d6e2", @"/Views/TestDetails/_TestDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b16f8c087b736e29b25f5d72fe0ce89dfadf1faf", @"/Views/_ViewImports.cshtml")]
    public class Views_TestDetails__TestDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestDetailCustomModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Testform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 457, true);
            WriteLiteral(@"
<div class=""modal-content"" style=""width: 900px !important;"">
    <div class=""modal-header has-border"">
        Create Test Detail
        <button type=""button"" class=""close custom-modal__close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"" class=""ua-icon-modal-close"">x</span>
        </button>
    </div>
    <div class=""modal-body"">
        <div class=""row"">
            <div class=""col-md-12"">
                ");
            EndContext();
            BeginContext(487, 2115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7694752188fd1d197a4e616dc97a032ca99d6e24638", async() => {
                BeginContext(578, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(601, 25, false);
#line 14 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml"
               Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
                EndContext();
                BeginContext(626, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(649, 29, false);
#line 15 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml"
               Write(Html.HiddenFor(m => m.TestId));

#line default
#line hidden
                EndContext();
                BeginContext(678, 177, true);
                WriteLiteral("\r\n\r\n                    <div class=\"form-group\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                ");
                EndContext();
                BeginContext(856, 28, false);
#line 20 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml"
                           Write(Html.LabelFor(m => m.UserId));

#line default
#line hidden
                EndContext();
                BeginContext(884, 122, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                ");
                EndContext();
                BeginContext(1007, 130, false);
#line 23 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml"
                           Write(Html.DropDownListFor(m => m.UserId, new SelectList(ViewBag.UserList, "UserId", "UserName"), null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1137, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1172, 40, false);
#line 24 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml"
                           Write(Html.ValidationMessageFor(m => m.UserId));

#line default
#line hidden
                EndContext();
                BeginContext(1212, 273, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                ");
                EndContext();
                BeginContext(1486, 30, false);
#line 32 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml"
                           Write(Html.LabelFor(m => m.Distance));

#line default
#line hidden
                EndContext();
                BeginContext(1516, 122, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                ");
                EndContext();
                BeginContext(1639, 88, false);
#line 35 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml"
                           Write(Html.TextBoxFor(m => m.Distance, null, new { @class = "form-control" , type ="number" }));

#line default
#line hidden
                EndContext();
                BeginContext(1727, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1762, 42, false);
#line 36 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Distance));

#line default
#line hidden
                EndContext();
                BeginContext(1804, 278, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <hr />
                    <div class=""form-group text-right"">
                        <button type=""submit"" class=""btn btn-primary"">Save Detail </button>
");
                EndContext();
#line 44 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml"
                         if (Model.Id > 0)
                        {
                            

#line default
#line hidden
                BeginContext(2182, 232, false);
#line 46 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml"
                       Write(Html.ActionLink("Delete", "DeleteTestDetail", "TestDetails", new { id = Model.Id , testId = Model.TestId }, new { @class = "btn btn-primary", onclick = "return confirm('Do you want to delete this athlate from the test detail?');" }));

#line default
#line hidden
                EndContext();
#line 46 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml"
                                                                                                                                                                                                                                                                     
                        }

#line default
#line hidden
                BeginContext(2443, 152, true);
                WriteLiteral("                        <button type=\"button\" class=\"btn btn-primary\" data-dismiss=\"modal\">Cancel</button>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Demo\AspNetCoreDemo\CoreDemo\CoreDemo\Views\TestDetails\_TestDetail.cshtml"
AddHtmlAttributeValue("", 529, Url.Action("SaveNewTestDetail", "TestDetails"), 529, 47, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2602, 64, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestDetailCustomModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
