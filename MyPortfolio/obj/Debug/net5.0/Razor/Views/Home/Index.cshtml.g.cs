#pragma checksum "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65b6d1007d3eb6b42021b9608ff75656b92b16cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\_ViewImports.cshtml"
using MyPortfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\_ViewImports.cshtml"
using MyPortfolio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\_ViewImports.cshtml"
using MyPortfolio.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\_ViewImports.cshtml"
using MyPortfolio.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\_ViewImports.cshtml"
using MyPortfolio.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b6d1007d3eb6b42021b9608ff75656b92b16cd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b074ef144e2b3ba86945b4559194dc1ddce26871", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Your Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Your Email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Your Phone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<header class=\"masthead bg-primary text-white text-center\">\r\n    <div class=\"container d-flex align-items-center flex-column\">\r\n        <!-- Masthead Avatar Image-->\r\n        <img style=\"border-radius:100%\" class=\"masthead-avatar mb-5\"");
            BeginWriteAttribute("src", " src=\"", 261, "\"", 296, 2);
            WriteAttributeValue("", 267, "assets/img/", 267, 11, true);
#nullable restore
#line 7 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
WriteAttributeValue("", 278, Model.Owner.Image, 278, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 297, "\"", 303, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <!-- Masthead Heading-->\r\n        <h1 class=\"masthead-heading text-uppercase mb-0\">");
#nullable restore
#line 9 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
                                                    Write(Model.Owner.OwnerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h4>");
#nullable restore
#line 10 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
       Write(Model.Owner.Address.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 10 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
                                      Write(Model.Owner.Address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 10 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
                                                                  Write(Model.Owner.Address.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
        <!-- Icon Divider-->
        <div class=""divider-custom divider-light"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
            <div class=""divider-custom-line""></div>
        </div>
        <!-- Masthead Subheading-->
        <p class=""masthead-subheading font-weight-light mb-0"">");
#nullable restore
#line 18 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
                                                         Write(Model.Owner.Profile);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>
</header>

<!-- Portfolio Section-->
<section class=""page-section portfolio"" id=""portfolio"">
    <div class=""container"">
        <!-- Portfolio Section Heading-->
        <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Portfolio</h2>
        <!-- Icon Divider-->
        <div class=""divider-custom"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
            <div class=""divider-custom-line""></div>
        </div>
        <!-- Portfolio Grid Items-->
        <div class=""row justify-content-center"">
            <!-- Portfolio Item 1-->

");
#nullable restore
#line 37 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
             foreach (var item in Model.Portfolio)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6 col-lg-4 mb-5\">\r\n                <div class=\"portfolio-item mx-auto\" data-toggle=\"modal\" data-target=\"#id-");
#nullable restore
#line 40 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
                                                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                    <div class=""portfolio-item-caption d-flex align-items-center justify-content-center h-100 w-100"">
                        <div class=""portfolio-item-caption-content text-center text-white""><i class=""fas fa-plus fa-3x""></i></div>
                    </div>
                    <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 2170, "\"", 2208, 2);
            WriteAttributeValue("", 2176, "assets/img/portfolio/", 2176, 21, true);
#nullable restore
#line 44 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
WriteAttributeValue("", 2197, item.Image, 2197, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2209, "\"", 2215, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>                       \r\n             </div>\r\n");
#nullable restore
#line 47 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                

            </div>
    </div>
</section>
<!-- About Section-->
<section class=""page-section bg-primary text-white mb-0"" id=""about"">
    <div class=""container"">
        <!-- About Section Heading-->
        <h2 class=""page-section-heading text-center text-uppercase text-white"">About</h2>
        <!-- Icon Divider-->
        <div class=""divider-custom divider-light"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
            <div class=""divider-custom-line""></div>
        </div>
        <!-- About Section Content-->
        <div>
            <center>
                <div><p class=""lead"">");
#nullable restore
#line 67 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
                                Write(Model.About.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p></div>
            </center>
        </div>
    </div>
</section>


<!-- Contact Section-->
<section class=""page-section"" id=""contact"">
    <div class=""container"">
        <!-- Contact Section Heading-->
        <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Contact Me</h2>
        <!-- Icon Divider-->
        <div class=""divider-custom"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
            <div class=""divider-custom-line""></div>
        </div>
        <!-- Contact Section Form-->
        <div class=""container"">

            <div class=""row mt-5"">
                <div class=""col-lg-6"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65b6d1007d3eb6b42021b9608ff75656b92b16cd14977", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col form-group mt-3\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65b6d1007d3eb6b42021b9608ff75656b92b16cd15382", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 93 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Contact.ClientName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <div></div>\r\n                            </div>\r\n                            <div class=\"col form-group mt-3\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65b6d1007d3eb6b42021b9608ff75656b92b16cd17780", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 97 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Contact.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <div></div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group mt-3\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65b6d1007d3eb6b42021b9608ff75656b92b16cd20195", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 102 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Contact.PhoneNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <div class=\"validate\"></div>\r\n                        </div>\r\n                        <div class=\"form-group mt-3\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65b6d1007d3eb6b42021b9608ff75656b92b16cd22594", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 106 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Contact.Message);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <div></div>\r\n                        </div>\r\n                        <div class=\"mt-1\"><input type=\"submit\" class=\"btn btn-warning\" value=\"Send Message\"/></div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Portfolio Modals-->\r\n<!-- Portfolio Modal 1-->\r\n");
#nullable restore
#line 120 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
 foreach (var item in Model.Portfolio)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"portfolio-modal modal fade\"");
            BeginWriteAttribute("id", " id=\"", 5414, "\"", 5430, 2);
            WriteAttributeValue("", 5419, "id-", 5419, 3, true);
#nullable restore
#line 122 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
WriteAttributeValue("", 5422, item.Id, 5422, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""portfolioModal1Label"" aria-hidden=""true"">
        <div class=""modal-dialog modal-xl"" role=""document"">
            <div class=""modal-content"">
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true""><i class=""fas fa-times""></i></span>
                </button>
                <div class=""modal-body text-center"">
                    <div class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-8"">
                                <!-- Portfolio Modal - Title-->
                                <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0""");
            BeginWriteAttribute("id", " id=\"", 6207, "\"", 6220, 1);
#nullable restore
#line 133 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
WriteAttributeValue("", 6212, item.Id, 6212, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 133 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
                                                                                                              Write(item.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                <!-- Icon Divider-->
                                <div class=""divider-custom"">
                                    <div class=""divider-custom-line""></div>
                                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                                    <div class=""divider-custom-line""></div>
                                </div>
                                <!-- Portfolio Modal - Image-->
                                <img class=""img-fluid rounded mb-5""");
            BeginWriteAttribute("src", " src=\"", 6792, "\"", 6830, 2);
            WriteAttributeValue("", 6798, "assets/img/portfolio/", 6798, 21, true);
#nullable restore
#line 141 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
WriteAttributeValue("", 6819, item.Image, 6819, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6831, "\"", 6837, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <!-- Portfolio Modal - Text-->\r\n                                <p class=\"mb-5\">");
#nullable restore
#line 143 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"
                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <button class=""btn btn-primary"" data-dismiss=""modal"">
                                    <i class=""fas fa-times fa-fw""></i>
                                    Close Window
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 155 "F:\Badr\Education\ASP.NET MVC Core\MyPortfolio\MyPortfolio\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
