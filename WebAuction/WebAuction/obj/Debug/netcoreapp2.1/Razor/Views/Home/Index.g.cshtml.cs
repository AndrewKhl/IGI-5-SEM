#pragma checksum "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fed53c6dc175a852a1f31233b2d25caeb444d52d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed53c6dc175a852a1f31233b2d25caeb444d52d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a42815f67ba74deb3f2328af750d8b49844d5163", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAuction.Models.Lot>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
  
    //ViewData["Title"] = "Список смартфонов";
    Layout = null;

#line default
#line hidden
            BeginContext(118, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(145, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77e49a9188a43ff855f5aab20c3682c", async() => {
                BeginContext(151, 30, true);
                WriteLiteral("\r\n    <title>Аукцион</title>\r\n");
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
            BeginContext(188, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(190, 549, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c219e5f81ba49a1b6aa76a3799266a8", async() => {
                BeginContext(196, 190, true);
                WriteLiteral("\r\n    <h3>Лоты</h3>\r\n    <table>\r\n        <tr>\r\n            <td>ID</td>\r\n            <td>Название</td>\r\n            <td>Начальная цена</td>\r\n            <td>Цена выкупа</td>\r\n        </tr>\r\n");
                EndContext();
#line 21 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
         foreach (var lot in Model)
        {

#line default
#line hidden
                BeginContext(434, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(473, 6, false);
#line 24 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
               Write(lot.Id);

#line default
#line hidden
                EndContext();
                BeginContext(479, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(507, 11, false);
#line 25 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
               Write(lot.NameLot);

#line default
#line hidden
                EndContext();
                BeginContext(518, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(546, 14, false);
#line 26 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
               Write(lot.StartPrice);

#line default
#line hidden
                EndContext();
                BeginContext(560, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(588, 19, false);
#line 27 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
               Write(lot.RedemptionPrice);

#line default
#line hidden
                EndContext();
                BeginContext(607, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(634, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20f68c1bfcd94f0d9d6860b2b77a588e", async() => {
                    BeginContext(663, 14, true);
                    WriteLiteral("Сделать ставку");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 643, "~/Home/Buy/", 643, 11, true);
#line 28 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 654, lot.Id, 654, 7, false);

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
                BeginContext(681, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 30 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(718, 14, true);
                WriteLiteral("    </table>\r\n");
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
            BeginContext(739, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAuction.Models.Lot>> Html { get; private set; }
    }
}
#pragma warning restore 1591
