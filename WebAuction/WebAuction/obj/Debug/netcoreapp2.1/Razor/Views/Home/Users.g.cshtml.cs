#pragma checksum "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8964078b6d8faf461b417c473da8a54c5e4584fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Users.cshtml", typeof(AspNetCore.Views_Home_Users))]
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
#line 1 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\_ViewImports.cshtml"
using WebAuction;

#line default
#line hidden
#line 2 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\_ViewImports.cshtml"
using WebAuction.Models;

#line default
#line hidden
#line 6 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8964078b6d8faf461b417c473da8a54c5e4584fe", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a42815f67ba74deb3f2328af750d8b49844d5163", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAuction.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(133, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(169, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(198, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c71aabd4544a446db5eec4630c71fa0d", async() => {
                BeginContext(204, 36, true);
                WriteLiteral("\r\n    <title>List of users</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(247, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(249, 1040, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "696c2e52bb054a70afabd6de645fdd2d", async() => {
                BeginContext(255, 10, true);
                WriteLiteral("\r\n    <h3>");
                EndContext();
                BeginContext(266, 18, false);
#line 17 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml"
   Write(Localizer["Users"]);

#line default
#line hidden
                EndContext();
                BeginContext(284, 161, true);
                WriteLiteral("</h3>\r\n    <table class=\"table\">\r\n        <thead class=\"thead-dark\">\r\n            <tr>\r\n                <th scope=\"col\">ID</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(446, 21, false);
#line 22 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml"
                           Write(Localizer["Nickname"]);

#line default
#line hidden
                EndContext();
                BeginContext(467, 39, true);
                WriteLiteral("</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(507, 17, false);
#line 23 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml"
                           Write(Localizer["Name"]);

#line default
#line hidden
                EndContext();
                BeginContext(524, 144, true);
                WriteLiteral("</th>\r\n                <th scope=\"col\">Email</th>\r\n                <th scope=\"col\"></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 29 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml"
             foreach (var user in Model)
            {

#line default
#line hidden
                BeginContext(725, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(772, 7, false);
#line 32 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml"
                   Write(user.Id);

#line default
#line hidden
                EndContext();
                BeginContext(779, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(811, 13, false);
#line 33 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml"
                   Write(user.Nickname);

#line default
#line hidden
                EndContext();
                BeginContext(824, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(856, 9, false);
#line 34 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml"
                   Write(user.Name);

#line default
#line hidden
                EndContext();
                BeginContext(865, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(897, 10, false);
#line 35 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml"
                   Write(user.Email);

#line default
#line hidden
                EndContext();
                BeginContext(907, 57, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(964, 219, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4210b6ad54a4404aa9a0ba9e04794316", async() => {
                    BeginContext(1059, 117, true);
                    WriteLiteral("\r\n                            <button class=\"btn-dark size-button\" type=\"submit\">!</button>\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 37 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml"
                                                                                    WriteLiteral(user.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1183, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 42 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Users.cshtml"
            }

#line default
#line hidden
                BeginContext(1250, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1289, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAuction.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
