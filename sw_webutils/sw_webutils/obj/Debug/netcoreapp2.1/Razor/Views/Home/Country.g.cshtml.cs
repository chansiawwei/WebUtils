#pragma checksum "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72d6f470ccc9ffbf60a090a590f2aead66ffb309"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Country), @"mvc.1.0.view", @"/Views/Home/Country.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Country.cshtml", typeof(AspNetCore.Views_Home_Country))]
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
#line 1 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\_ViewImports.cshtml"
using sw_webutils.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d6f470ccc9ffbf60a090a590f2aead66ffb309", @"/Views/Home/Country.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aac0766cd53a5700f8cb6999787a547c2c4bd04f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Country : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CountryData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2 control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Country", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
  
    ViewData["Title"] = "Country";

#line default
#line hidden
            BeginContext(65, 20, true);
            WriteLiteral("<h1>Country</h1>\r\n\r\n");
            EndContext();
            BeginContext(85, 679, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10bf5b8fa74b4c438c97a33b32941159", async() => {
                BeginContext(138, 20, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
                EndContext();
                BeginContext(158, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b2131ee62a84bc880a5f732ecc9ee1d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 11 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(218, 42, true);
                WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(260, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de12132203d84907b168435c89b21606", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 14 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CountryName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(328, 46, true);
                WriteLiteral("\r\n        <div class=\"col-md-5\">\r\n            ");
                EndContext();
                BeginContext(374, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f30e62e8c4b46f1a6b0e3d06395a78b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 16 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CountryName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(426, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(440, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acff3f059db34a23bb35db6b4da03338", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 17 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CountryName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(506, 251, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-5\">\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Search Country Info\" />\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(764, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 31 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
 if (@Model?.Capital != null)
{


#line default
#line hidden
            BeginContext(806, 36, true);
            WriteLiteral("    <br />\r\n    <br />\r\n    <hr />\r\n");
            EndContext();
            BeginContext(844, 82, true);
            WriteLiteral("    <p>\r\n        <iframe width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0\"");
            EndContext();
            BeginWriteAttribute("src", "\r\n                src=\"", 926, "\"", 1068, 4);
            WriteAttributeValue("", 949, "https://www.google.com/maps/embed/v1/place?q=", 949, 45, true);
#line 40 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
WriteAttributeValue("", 994, Model?.CountryName, 994, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1013, "&key=AIzaSyDRXiFKs4KA0-2PHFdOIKkrYLuwrDYPYYI", 1013, 44, true);
            WriteAttributeValue("\r\n\r\n\r\n     ", 1057, "", 1068, 11, true);
            EndWriteAttribute();
            BeginContext(1069, 38, true);
            WriteLiteral(" allowfullscreen></iframe>\r\n    </p>\r\n");
            EndContext();
            BeginContext(1109, 74, true);
            WriteLiteral("    <ul class=\"list-group\">\r\n        <li class=\"list-group-item\">Country: ");
            EndContext();
            BeginContext(1184, 17, false);
#line 47 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
                                        Write(Model.CountryName);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 52, true);
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Capital: ");
            EndContext();
            BeginContext(1254, 13, false);
#line 48 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
                                        Write(Model.Capital);

#line default
#line hidden
            EndContext();
            BeginContext(1267, 49, true);
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Area: ");
            EndContext();
            BeginContext(1317, 10, false);
#line 49 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
                                     Write(Model.Area);

#line default
#line hidden
            EndContext();
            BeginContext(1327, 55, true);
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Population: ");
            EndContext();
            BeginContext(1383, 16, false);
#line 50 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
                                           Write(Model.Population);

#line default
#line hidden
            EndContext();
            BeginContext(1399, 53, true);
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Currency: ");
            EndContext();
            BeginContext(1453, 18, false);
#line 51 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
                                         Write(Model.CurrencyCode);

#line default
#line hidden
            EndContext();
            BeginContext(1471, 19, true);
            WriteLiteral("</li>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1490, "\"", 1510, 1);
#line 52 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
WriteAttributeValue("", 1496, Model.FalgUrl, 1496, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1511, "\"", 1535, 1);
#line 52 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
WriteAttributeValue("", 1517, Model.CountryName, 1517, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1536, 45, true);
            WriteLiteral(" width=\"200px\" height=\"200px\" />\r\n    </ul>\r\n");
            EndContext();
#line 54 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"


}
else
{
    if (@Model?.CountryName != null)
    {


#line default
#line hidden
            BeginContext(1644, 107, true);
            WriteLiteral("        <br />\r\n        <br />\r\n        <hr />\r\n        <div><h3>Please enter a valid country.</h3></div>\r\n");
            EndContext();
#line 66 "C:\Users\Chan Siaw Wei\Desktop\WebUtils\sw_webutils\sw_webutils\Views\Home\Country.cshtml"

    }
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CountryData> Html { get; private set; }
    }
}
#pragma warning restore 1591
