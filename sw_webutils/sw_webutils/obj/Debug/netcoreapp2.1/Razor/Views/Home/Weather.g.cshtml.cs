#pragma checksum "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac8d0d1d412f6915d2d6f2b620a0462edbb67164"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Weather), @"mvc.1.0.view", @"/Views/Home/Weather.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Weather.cshtml", typeof(AspNetCore.Views_Home_Weather))]
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
#line 1 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\_ViewImports.cshtml"
using sw_webutils.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac8d0d1d412f6915d2d6f2b620a0462edbb67164", @"/Views/Home/Weather.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aac0766cd53a5700f8cb6999787a547c2c4bd04f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Weather : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeatherData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2 control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(63, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(67, 653, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46fedd1a10f34ac58acc297259de7db4", async() => {
                BeginContext(118, 20, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
                EndContext();
                BeginContext(138, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bc22bc1c5734e3aa673031607379d40", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 11 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
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
                BeginContext(198, 42, true);
                WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(240, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97de8fea59ea4c2781aeee1d87aa58fc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 14 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.City);

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
                BeginContext(301, 46, true);
                WriteLiteral("\r\n        <div class=\"col-md-5\">\r\n            ");
                EndContext();
                BeginContext(347, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d354270a87d4146b15d4c044238ef57", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 16 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.City);

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
                BeginContext(392, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(406, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c640f0c1bd84e138f522ad22883bc33", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 17 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.City);

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
                BeginContext(465, 248, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-5\">\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Search City Info\" />\r\n        </div>\r\n    </div>\r\n\r\n");
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
            BeginContext(720, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 31 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
 if (@Model?.Text != null)
{

#line default
#line hidden
            BeginContext(757, 36, true);
            WriteLiteral("    <br />\r\n    <br />\r\n    <hr />\r\n");
            EndContext();
            BeginContext(801, 82, true);
            WriteLiteral("    <p>\r\n        <iframe width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0\"");
            EndContext();
            BeginWriteAttribute("src", "\r\n                src=\"", 883, "\"", 1018, 4);
            WriteAttributeValue("", 906, "https://www.google.com/maps/embed/v1/place?q=", 906, 45, true);
#line 40 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
WriteAttributeValue("", 951, Model?.City, 951, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 963, "&key=AIzaSyDRXiFKs4KA0-2PHFdOIKkrYLuwrDYPYYI", 963, 44, true);
            WriteAttributeValue("\r\n\r\n\r\n     ", 1007, "", 1018, 11, true);
            EndWriteAttribute();
            BeginContext(1019, 38, true);
            WriteLiteral(" allowfullscreen></iframe>\r\n    </p>\r\n");
            EndContext();
            BeginContext(1061, 99, true);
            WriteLiteral("    <div>\r\n\r\n\r\n        <ul class=\"list-group\">\r\n\r\n            <li class=\"list-group-item\">Huminity:");
            EndContext();
            BeginContext(1161, 15, false);
#line 52 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
                                            Write(Model?.Huminity);

#line default
#line hidden
            EndContext();
            BeginContext(1176, 55, true);
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">Sunrise:");
            EndContext();
            BeginContext(1232, 14, false);
#line 53 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
                                           Write(Model?.SunRise);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 54, true);
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">SunSet:");
            EndContext();
            BeginContext(1301, 13, false);
#line 54 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
                                          Write(Model?.SunSet);

#line default
#line hidden
            EndContext();
            BeginContext(1314, 55, true);
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">Weather:");
            EndContext();
            BeginContext(1370, 11, false);
#line 55 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
                                           Write(Model?.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1381, 34, true);
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1421, 29, true);
            WriteLiteral("    <ul class=\"list-group\">\r\n");
            EndContext();
#line 62 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
         foreach (var f in @Model.WeatherForecastDatas)
        {


#line default
#line hidden
            BeginContext(1520, 45, true);
            WriteLiteral("            <li class=\"list-group-item\">Date:");
            EndContext();
            BeginContext(1566, 6, false);
#line 65 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
                                        Write(f.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1572, 51, true);
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">Day:");
            EndContext();
            BeginContext(1624, 5, false);
#line 66 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
                                       Write(f.Day);

#line default
#line hidden
            EndContext();
            BeginContext(1629, 52, true);
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">High:");
            EndContext();
            BeginContext(1682, 6, false);
#line 67 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
                                        Write(f.High);

#line default
#line hidden
            EndContext();
            BeginContext(1688, 51, true);
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">Low:");
            EndContext();
            BeginContext(1740, 5, false);
#line 68 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
                                       Write(f.Low);

#line default
#line hidden
            EndContext();
            BeginContext(1745, 56, true);
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"> Weather:");
            EndContext();
            BeginContext(1802, 6, false);
#line 69 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
                                            Write(f.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1808, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
            BeginContext(1819, 20, true);
            WriteLiteral("            <br />\r\n");
            EndContext();
#line 73 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"

        }

#line default
#line hidden
            BeginContext(1852, 15, true);
            WriteLiteral("\r\n\r\n    </ul>\r\n");
            EndContext();
#line 78 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"

}

#line default
#line hidden
            BeginContext(1872, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 81 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"
 if (@Model?.Count == 0)
{


#line default
#line hidden
            BeginContext(1905, 89, true);
            WriteLiteral("    <br />\r\n    <br />\r\n    <hr />\r\n    <div><h3>Please enter a valid city .</h3></div>\r\n");
            EndContext();
#line 88 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Weather.cshtml"


}

#line default
#line hidden
            BeginContext(2001, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherData> Html { get; private set; }
    }
}
#pragma warning restore 1591