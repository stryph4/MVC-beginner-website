#pragma checksum "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bcd9a49176643fc63b46f935c2fdf15cf428523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Detail), @"mvc.1.0.view", @"/Views/Products/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Detail.cshtml", typeof(AspNetCore.Views_Products_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bcd9a49176643fc63b46f935c2fdf15cf428523", @"/Views/Products/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baed38cd1fe7e90ae4c16f8cab34854d69aa394e", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("detailimage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/5-star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("rating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/4-star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/3-star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/2-star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/1-star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(60, 67, true);
            WriteLiteral("\r\n<h2>Product Page</h2>\r\n<div class=\"wrapper\">\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(127, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3d22a7b6903a482da2c03182b637f3ae", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 137, "~/images/", 137, 9, true);
#line 10 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
AddHtmlAttributeValue("", 146, Model.ImageName, 146, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(182, 68, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"details\">\r\n        <p id=\"detailname\">");
            EndContext();
            BeginContext(251, 10, false);
#line 13 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
                      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(261, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 14 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
         if (Model.IsTopSeller)
        {

#line default
#line hidden
            BeginContext(311, 57, true);
            WriteLiteral("            <label id=\"bestseller\">BEST SELLER!</label>\r\n");
            EndContext();
#line 17 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
        }

#line default
#line hidden
            BeginContext(379, 60, true);
            WriteLiteral("        <p id=\"manufacturer\" style=\"margin-bottom: 5px;\">by ");
            EndContext();
            BeginContext(440, 18, false);
#line 18 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
                                                       Write(Model.Manufacturer);

#line default
#line hidden
            EndContext();
            BeginContext(458, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 19 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
         if (Model.AverageRating >= 5)
        {

#line default
#line hidden
            BeginContext(515, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(527, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "181769ece7274b3e8f71fe0668784634", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(572, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
        }
        else if (Model.AverageRating >= 4)
        {

#line default
#line hidden
            BeginContext(640, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(652, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5b95ab50390540e49c40f55ec51f0f03", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(697, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
        }
        else if (Model.AverageRating >= 3)
        {

#line default
#line hidden
            BeginContext(765, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(777, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a6fe0f8217e420fa3a7ee5b8d67bdbf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(822, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
        }
        else if (Model.AverageRating >= 2)
        {

#line default
#line hidden
            BeginContext(890, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(902, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e65920ab65d747d2948cadab75a2645e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(947, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(985, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(997, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "92226bfde31249b7a168a041d91d3688", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1042, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
        }

#line default
#line hidden
            BeginContext(1055, 74, true);
            WriteLiteral("        <p id=\"price\" style=\"font-size: 1.2rem; margin-top: -5px;\">Price: ");
            EndContext();
            BeginContext(1130, 11, false);
#line 39 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
                                                                     Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1141, 195, true);
            WriteLiteral("</p>\r\n        <label class=\"producttext\" id=\"weight\" style=\"font-weight:bold; margin-top: -10px;\">Weight&thinsp;</label>\r\n        <label class=\"producttext\" id=\"weight\" style=\"margin-top: -10px\">");
            EndContext();
            BeginContext(1337, 17, false);
#line 41 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
                                                                    Write(Model.WeightInLbs);

#line default
#line hidden
            EndContext();
            BeginContext(1354, 127, true);
            WriteLiteral(" lbs.</label>\r\n        <p class=\"description\"><label style=\"font-weight: bold; margin-bottom: -5px;\">Description:&ensp;</label>");
            EndContext();
            BeginContext(1482, 17, false);
#line 42 "C:\Users\Nabiel El-Gendy\exercises\33-mvc-models-exercises\MVCModels.Web\Views\Products\Detail.cshtml"
                                                                                                           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1499, 30, true);
            WriteLiteral("</p>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
