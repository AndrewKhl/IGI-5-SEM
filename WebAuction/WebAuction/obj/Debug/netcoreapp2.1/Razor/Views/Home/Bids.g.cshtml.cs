#pragma checksum "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9d81809d910ae26a6f4a9701ffa14c3e20461cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Bids), @"mvc.1.0.view", @"/Views/Home/Bids.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Bids.cshtml", typeof(AspNetCore.Views_Home_Bids))]
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
#line 6 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9d81809d910ae26a6f4a9701ffa14c3e20461cd", @"/Views/Home/Bids.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a42815f67ba74deb3f2328af750d8b49844d5163", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Bids : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAuction.Models.Bid>>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
  
    ViewData["Title"] = "Bids";

#line default
#line hidden
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(131, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(167, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(196, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02b439c6456b451c97aab79ea09d568b", async() => {
                BeginContext(202, 35, true);
                WriteLiteral("\r\n    <title>List of bids</title>\r\n");
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
            BeginContext(244, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(246, 2252, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d78b1dd8c56849f1968914b13f767668", async() => {
                BeginContext(252, 10, true);
                WriteLiteral("\r\n    <h3>");
                EndContext();
                BeginContext(263, 17, false);
#line 17 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
   Write(Localizer["Bids"]);

#line default
#line hidden
                EndContext();
                BeginContext(280, 7, true);
                WriteLiteral("</h3>\r\n");
                EndContext();
#line 18 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
     if (User.IsInRole("admin"))
    {

#line default
#line hidden
                BeginContext(328, 184, true);
                WriteLiteral("        <div class=\"form-check\">\r\n            <input type=\"checkbox\" class=\"form-check-input\" id=\"view-all-bids\" onclick=\"RefreshTable()\">\r\n            <label class=\"form-check-label\">");
                EndContext();
                BeginContext(513, 24, false);
#line 22 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
                                       Write(Localizer["ViewAllBids"]);

#line default
#line hidden
                EndContext();
                BeginContext(537, 26, true);
                WriteLiteral("</label>\r\n        </div>\r\n");
                EndContext();
#line 24 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
    }

#line default
#line hidden
                BeginContext(570, 154, true);
                WriteLiteral("    <table class=\"table\">\r\n        <thead class=\"thead-dark\">\r\n            <tr>\r\n                <th scope=\"col\">ID</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(725, 16, false);
#line 29 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
                           Write(Localizer["Sum"]);

#line default
#line hidden
                EndContext();
                BeginContext(741, 39, true);
                WriteLiteral("</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(781, 20, false);
#line 30 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
                           Write(Localizer["DateBid"]);

#line default
#line hidden
                EndContext();
                BeginContext(801, 39, true);
                WriteLiteral("</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(841, 18, false);
#line 31 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
                           Write(Localizer["LotID"]);

#line default
#line hidden
                EndContext();
                BeginContext(859, 39, true);
                WriteLiteral("</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(899, 20, false);
#line 32 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
                           Write(Localizer["NameLot"]);

#line default
#line hidden
                EndContext();
                BeginContext(919, 39, true);
                WriteLiteral("</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(959, 20, false);
#line 33 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
                           Write(Localizer["DateEnd"]);

#line default
#line hidden
                EndContext();
                BeginContext(979, 39, true);
                WriteLiteral("</th>\r\n                <th scope=\"col\">");
                EndContext();
                BeginContext(1019, 20, false);
#line 34 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
                           Write(Localizer["HostBid"]);

#line default
#line hidden
                EndContext();
                BeginContext(1039, 256, true);
                WriteLiteral(@"</th>
            </tr>
        </thead>
        <tbody id=""body-table""></tbody>
    </table>

    <script>
        function RefreshTable() {
            var status = $('#view-all-bids').is("":checked"");
            $.ajax({
                url: '");
                EndContext();
                BeginContext(1296, 38, false);
#line 44 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Bids.cshtml"
                 Write(Url.Action("RefreshTableBids", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1334, 1157, true);
                WriteLiteral(@"',
                type: ""GET"",
                data: ""str="" + status,
                success: function (response) {
                    response = JSON.parse(response);
                    $(""#body-table"").empty();
                    for (var i = 0; i < response.length; i++) {
                        $(""#body-table"").append(""<tr>"");
                        $(""#body-table"").append(""<td>"" + response[i].Id + ""</td>"");
                        $(""#body-table"").append(""<td>"" + response[i].Sum + ""</td>"");
                        $(""#body-table"").append(""<td>"" + response[i].DateBid + ""</td>"");
                        $(""#body-table"").append(""<td>"" + response[i].LotId + ""</td>"");
                        $(""#body-table"").append(""<td>"" + response[i].LotName + ""</td>"");
                        $(""#body-table"").append(""<td>"" + response[i].DateEnd + ""</td>"");
                        $(""#body-table"").append(""<td>"" + response[i].HostName + ""</td>"");
                        $(""#body-table"").append(""</tr>"");");
                WriteLiteral("\n                    }\r\n                }\r\n            });\r\n        };\r\n\r\n        $(document).ready(RefreshTable());\r\n    </script>\r\n");
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
            BeginContext(2498, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAuction.Models.Bid>> Html { get; private set; }
    }
}
#pragma warning restore 1591
