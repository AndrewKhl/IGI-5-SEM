#pragma checksum "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f0a88e7c2ddbce1c3f9eda7a4a202c868951d29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Lots), @"mvc.1.0.view", @"/Views/Home/Lots.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Lots.cshtml", typeof(AspNetCore.Views_Home_Lots))]
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
#line 6 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f0a88e7c2ddbce1c3f9eda7a4a202c868951d29", @"/Views/Home/Lots.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a42815f67ba74deb3f2328af750d8b49844d5163", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Lots : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAuction.ViewModels.TableLot>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Lot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrChangeLot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-1 float-right text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
  
    ViewData["Title"] = "Аукцион";

#line default
#line hidden
            BeginContext(95, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(179, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(206, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a234d6c2cbd4e8eb0469850d476fa27", async() => {
                BeginContext(212, 30, true);
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
            BeginContext(249, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(251, 3039, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6a4e61a783640c48c8e53ffb9109aa7", async() => {
                BeginContext(257, 72, true);
                WriteLiteral("\r\n    <div style=\"position:relative; left:18px;\" class=\"my-2\">\r\n        ");
                EndContext();
                BeginContext(329, 207, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9268490e97949839725bab8edb874a1", async() => {
                    BeginContext(421, 69, true);
                    WriteLiteral("\r\n            <button class=\"btn btn-dark float-right\" type=\"submit\">");
                    EndContext();
                    BeginContext(491, 19, false);
#line 18 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
                                                              Write(Localizer["NewLot"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(510, 19, true);
                    WriteLiteral("</button>\r\n        ");
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(536, 24, true);
                WriteLiteral("\r\n    </div>\r\n\r\n    <h3>");
                EndContext();
                BeginContext(561, 17, false);
#line 22 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
   Write(Localizer["Lots"]);

#line default
#line hidden
                EndContext();
                BeginContext(578, 7, true);
                WriteLiteral("</h3>\r\n");
                EndContext();
#line 23 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
     if (User.IsInRole("admin"))
    {

#line default
#line hidden
                BeginContext(626, 184, true);
                WriteLiteral("        <div class=\"form-check\">\r\n            <input type=\"checkbox\" class=\"form-check-input\" id=\"view-all-lots\" onclick=\"RefreshTable()\">\r\n            <label class=\"form-check-label\">");
                EndContext();
                BeginContext(811, 20, false);
#line 27 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
                                       Write(Localizer["AllLots"]);

#line default
#line hidden
                EndContext();
                BeginContext(831, 26, true);
                WriteLiteral("</label>\r\n        </div>\r\n");
                EndContext();
#line 29 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
    }

#line default
#line hidden
                BeginContext(864, 154, true);
                WriteLiteral("    <table class=\"table\">\r\n        <thead class=\"thead-dark\">\r\n            <tr>\r\n                <th scope=\"col\">ID</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(1019, 17, false);
#line 34 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
                           Write(Localizer["Name"]);

#line default
#line hidden
                EndContext();
                BeginContext(1036, 39, true);
                WriteLiteral("</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(1076, 19, false);
#line 35 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
                           Write(Localizer["MaxBid"]);

#line default
#line hidden
                EndContext();
                BeginContext(1095, 39, true);
                WriteLiteral("</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(1135, 20, false);
#line 36 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
                           Write(Localizer["HostBid"]);

#line default
#line hidden
                EndContext();
                BeginContext(1155, 39, true);
                WriteLiteral("</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(1195, 28, false);
#line 37 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
                           Write(Localizer["RedemptionPrice"]);

#line default
#line hidden
                EndContext();
                BeginContext(1223, 39, true);
                WriteLiteral("</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(1263, 20, false);
#line 38 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
                           Write(Localizer["HostLot"]);

#line default
#line hidden
                EndContext();
                BeginContext(1283, 39, true);
                WriteLiteral("</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(1323, 20, false);
#line 39 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
                           Write(Localizer["DateEnd"]);

#line default
#line hidden
                EndContext();
                BeginContext(1343, 345, true);
                WriteLiteral(@"</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody id=""body-table""></tbody>
    </table>

    <script>
        function RefreshTable() {
            var value = $(""#valueSearch"").val();
            var status = $('#view-all-lots').is("":checked"");
            $.ajax({
                url: '");
                EndContext();
                BeginContext(1689, 33, false);
#line 51 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
                 Write(Url.Action("SearchValue", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1722, 1296, true);
                WriteLiteral(@"',
                type: ""POST"",
                data: { 'value': value, 'status': status },
                success: function (data) {
                    CreateTable(data);
                }
            });
        };

        $(""#btnSearch"").on(""click"", RefreshTable);

        function CreateTable(response) {
            response = JSON.parse(response);
            $(""#body-table"").empty();
            for (var i = 0; i < response.length; i++) {
                $(""#body-table"").append(""<tr>"");
                $(""#body-table"").append(""<td>"" + response[i].Id + ""</td>"");
                $(""#body-table"").append(""<td>"" + response[i].NameLot + ""</td>"");
                $(""#body-table"").append(""<td>"" + response[i].MaxBid + ""</td>"");
                if (response[i].HostBid == null)
                    response[i].HostBid = """";
                $(""#body-table"").append(""<td>"" + response[i].HostBid + ""</td>"");
                $(""#body-table"").append(""<td>"" + response[i].RedemptionPrice + ""</td>"")");
                WriteLiteral(@";
                $(""#body-table"").append(""<td>"" + response[i].HostLot + ""</td>"");
                $(""#body-table"").append(""<td>"" + response[i].DateEnd + ""</td>"");
                $(""#body-table"").append(""<td><a href=\""/Lot/AddOrChangeLot/"" + response[i].Id + ""/\"">""+ '");
                EndContext();
                BeginContext(3019, 18, false);
#line 76 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Lots.cshtml"
                                                                                                    Write(Localizer["DoBid"]);

#line default
#line hidden
                EndContext();
                BeginContext(3037, 246, true);
                WriteLiteral("\' + \"</a></td>\");\r\n                $(\"#body-table\").append(\"</tr>\");\r\n            }\r\n        };\r\n\r\n        $(document).ready(function () {\r\n            RefreshTable();\r\n            setInterval(RefreshTable, 30000);\r\n        });\r\n\r\n    </script>\r\n");
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
            BeginContext(3290, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAuction.ViewModels.TableLot>> Html { get; private set; }
    }
}
#pragma warning restore 1591
