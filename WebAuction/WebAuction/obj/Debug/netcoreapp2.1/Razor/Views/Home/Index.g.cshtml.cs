#pragma checksum "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad733b3aa5ac2332548e44cbde7a4eef2ef9b7f5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad733b3aa5ac2332548e44cbde7a4eef2ef9b7f5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a42815f67ba74deb3f2328af750d8b49844d5163", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAuction.ViewModels.TableLot>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Lot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrChangeLot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Аукцион";

#line default
#line hidden
            BeginContext(95, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(122, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4910cadf36d34c058b6ff7ba9da1a495", async() => {
                BeginContext(128, 30, true);
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
            BeginContext(165, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(167, 3309, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "400a331e651c4f0eb54d7b1e7ec671f5", async() => {
                BeginContext(173, 65, true);
                WriteLiteral("\r\n    <div class=\"d-flex justify-content-end offset-4\">\r\n        ");
                EndContext();
                BeginContext(238, 159, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3712bd06ff44494780f39467673275ed", async() => {
                    BeginContext(307, 83, true);
                    WriteLiteral("\r\n            <button class=\"btn btn-dark\" type=\"submit\">New lot</button>\r\n        ");
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
                BeginContext(397, 730, true);
                WriteLiteral(@"
    </div>

    <h3>Lots</h3>
    <div class=""form-check"">
        <input type=""checkbox"" class=""form-check-input"" id=""view-all-lots"">
        <label class=""form-check-label"">View all lots</label>
    </div>

    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">MaxBid</th>
                <th scope=""col"">HostBid</th>
                <th scope=""col"">RedemptionPrice</th>
                <th scope=""col"">HostLot</th>
                <th scope=""col"">DateEnd</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody id=""body-table"">
");
                EndContext();
#line 38 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
             foreach (var lot in Model)
            {

#line default
#line hidden
                BeginContext(1183, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1230, 6, false);
#line 41 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
                   Write(lot.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1236, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1268, 11, false);
#line 42 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
                   Write(lot.NameLot);

#line default
#line hidden
                EndContext();
                BeginContext(1279, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1311, 10, false);
#line 43 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
                   Write(lot.MaxBid);

#line default
#line hidden
                EndContext();
                BeginContext(1321, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1353, 11, false);
#line 44 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
                   Write(lot.HostBid);

#line default
#line hidden
                EndContext();
                BeginContext(1364, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1396, 19, false);
#line 45 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
                   Write(lot.RedemptionPrice);

#line default
#line hidden
                EndContext();
                BeginContext(1415, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1447, 11, false);
#line 46 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
                   Write(lot.HostLot);

#line default
#line hidden
                EndContext();
                BeginContext(1458, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1490, 11, false);
#line 47 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
                   Write(lot.DateEnd);

#line default
#line hidden
                EndContext();
                BeginContext(1501, 59, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1560, "\"", 1595, 3);
                WriteAttributeValue("", 1567, "/Lot/AddOrChangeLot/", 1567, 20, true);
#line 49 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
WriteAttributeValue("", 1587, lot.Id, 1587, 7, false);

#line default
#line hidden
                WriteAttributeValue("", 1594, "/", 1594, 1, true);
                EndWriteAttribute();
                BeginContext(1596, 58, true);
                WriteLiteral(">!</a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 52 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1669, 246, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            setInterval(function () {\r\n                var status = $(\'#view-all-lots\').is(\":checked\");\r\n                $.ajax({\r\n                    url: \'");
                EndContext();
                BeginContext(1916, 29, false);
#line 61 "D:\3 курс Информатика БГУИР\ИГИ 5 сем\WebAuction\WebAuction\Views\Home\Index.cshtml"
                     Write(Url.Action("Refresh", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1945, 1524, true);
                WriteLiteral(@"',
                    type: ""GET"",
                    data: ""str="" + status,
                    success: function (response) {
                        response = JSON.parse(response);
                        $(""#body-table"").empty();
                        for (var i = 0; i < response.length; i++) {
                            console.log(response[i]);
                            $(""#body-table"").append(""<tr>"");
                            $(""#body-table"").append(""<td>"" + response[i].Id + ""</td>"");
                            $(""#body-table"").append(""<td>"" + response[i].NameLot + ""</td>"");
                            $(""#body-table"").append(""<td>"" + response[i].MaxBid + ""</td>"");
                            if (response[i].HostBid == null)
                                response[i].HostBid = """";
                            $(""#body-table"").append(""<td>"" + response[i].HostBid + ""</td>"");
                            $(""#body-table"").append(""<td>"" + response[i].RedemptionPrice + ""</td>"");
  ");
                WriteLiteral(@"                          $(""#body-table"").append(""<td>"" + response[i].HostLot + ""</td>"");
                            $(""#body-table"").append(""<td>"" + response[i].DateEnd + ""</td>"");
                            $(""#body-table"").append(""<td><a href=\""/Lot/AddOrChangeLot/"" + response[i].Id + ""/\"">!</a></td>"");
                            $(""#body-table"").append(""</tr>"");
                        }
                    }
                });
            }, 60000);
        });
    </script>
");
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
            BeginContext(3476, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAuction.ViewModels.TableLot>> Html { get; private set; }
    }
}
#pragma warning restore 1591
