#pragma checksum "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80ef0ad35ef6c27001635038f3ad50fc88222234"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
#line 1 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\_ViewImports.cshtml"
using MVCModels.Web;

#line default
#line hidden
#line 2 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\_ViewImports.cshtml"
using MVCModels.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ef0ad35ef6c27001635038f3ad50fc88222234", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baed38cd1fe7e90ae4c16f8cab34854d69aa394e", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("align", new global::Microsoft.AspNetCore.Html.HtmlString("left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("imageresize"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/5-star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("rating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/4-star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/3-star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/2-star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/1-star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(66, 83, true);
            WriteLiteral("<header>All Products</header>\r\n\r\n<div class=\"wrapper\">\r\n    <div class=\"content\">\r\n");
            EndContext();
#line 10 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
         foreach (var product in Model)
        {


#line default
#line hidden
            BeginContext(203, 103, true);
            WriteLiteral("            <div class=\"productinfo\">\r\n                <div class=\"productimage\">\r\n                    ");
            EndContext();
            BeginContext(306, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2f031a9646441229c9b4ad0e8011c7f", async() => {
                BeginContext(389, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(415, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52048ea9d53c44c9abcba41cf71dd74f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 425, "~/images/", 425, 9, true);
#line 16 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 434, product.ImageName, 434, 18, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(486, 22, true);
                WriteLiteral("\r\n                    ");
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
#line 15 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                                                                       WriteLiteral(product.ProductId);

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
            BeginContext(512, 115, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                <div>\r\n                    <label class=\"producttext\" id=\"productname\">");
            EndContext();
            BeginContext(628, 12, false);
#line 21 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                                                           Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(640, 12, true);
            WriteLiteral("</label>\r\n\r\n");
            EndContext();
#line 23 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                     if (product.IsTopSeller)
                    {

#line default
#line hidden
            BeginContext(722, 69, true);
            WriteLiteral("                        <label id=\"bestseller\">BEST SELLER!</label>\r\n");
            EndContext();
#line 26 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(814, 64, true);
            WriteLiteral("                    <p class=\"producttext\" id=\"manufacturer\">by ");
            EndContext();
            BeginContext(879, 20, false);
#line 27 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                                                           Write(product.Manufacturer);

#line default
#line hidden
            EndContext();
            BeginContext(899, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 28 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                     if (product.RemainingStock <= 2)
                    {

#line default
#line hidden
            BeginContext(983, 96, true);
            WriteLiteral("                        <p class=\"producttext\" style=\"color: dodgerblue; font-size: 1rem;\">Only ");
            EndContext();
            BeginContext(1080, 22, false);
#line 30 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                                                                                           Write(product.RemainingStock);

#line default
#line hidden
            EndContext();
            BeginContext(1102, 12, true);
            WriteLiteral(" left!</p>\r\n");
            EndContext();
#line 31 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1137, 55, true);
            WriteLiteral("                    <p class=\"producttext\" id=\"price\">$");
            EndContext();
            BeginContext(1193, 13, false);
#line 32 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                                                  Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 174, true);
            WriteLiteral("</p>\r\n                    <label class=\"producttext\" id=\"weight\" style=\"font-weight:bold;\">Weight&thinsp;</label>\r\n                    <label class=\"producttext\" id=\"weight\">");
            EndContext();
            BeginContext(1381, 19, false);
#line 34 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                                                      Write(product.WeightInLbs);

#line default
#line hidden
            EndContext();
            BeginContext(1400, 41, true);
            WriteLiteral(" lbs.</label>\r\n                    <br>\r\n");
            EndContext();
#line 36 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                     if (product.AverageRating >= 5)
                    {

#line default
#line hidden
            BeginContext(1518, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1542, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d160a42eb1247dea3515a73faef878f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1587, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                    }
                    else if (product.AverageRating >= 4)
                    {

#line default
#line hidden
            BeginContext(1693, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1717, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46a497bda8994cfb90591ab348959766", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1762, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                    }
                    else if (product.AverageRating >= 3)
                    {

#line default
#line hidden
            BeginContext(1868, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1892, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34a220a551b54f20a6223f738e29fa09", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1937, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                    }
                    else if (product.AverageRating >= 2)
                    {

#line default
#line hidden
            BeginContext(2043, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2067, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "55875d6ac60442bb9b82fe651bb8de5a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2186, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2210, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cefed4ffe2144bd795cbfee912f1f3f4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2255, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2280, 66, true);
            WriteLiteral("                </div>\r\n                <br>\r\n            </div>\r\n");
            EndContext();
#line 59 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2357, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
