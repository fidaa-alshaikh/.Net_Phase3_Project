#pragma checksum "C:\Users\fedaa_1zoqddg\source\repos\Project3Phase3MVC\Project3Phase3MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6803d9e80b553685e0a788109821d4cec66f8d24"
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
#line 1 "C:\Users\fedaa_1zoqddg\source\repos\Project3Phase3MVC\Project3Phase3MVC\Views\_ViewImports.cshtml"
using Project3Phase3MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fedaa_1zoqddg\source\repos\Project3Phase3MVC\Project3Phase3MVC\Views\_ViewImports.cshtml"
using Project3Phase3MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6803d9e80b553685e0a788109821d4cec66f8d24", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ecb3bed95309adf3d0c70d7de062f2c1e8b232b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DotNet_Phase3_Project.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ProductCard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fedaa_1zoqddg\source\repos\Project3Phase3MVC\Project3Phase3MVC\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6803d9e80b553685e0a788109821d4cec66f8d244119", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""jumbotron"">
    <h1>ASP.NET</h1>
    <p class=""lead"">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
    <p><a href=""https://asp.net"" class=""btn btn-primary btn-lg"">Learn more &raquo;</a></p>
</div>

<div class=""row"">
  
        <div class=""container d-flex justify-content-center mt-50 mb-50"">
            <div class=""row"">
");
#nullable restore
#line 18 "C:\Users\fedaa_1zoqddg\source\repos\Project3Phase3MVC\Project3Phase3MVC\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4 mt-2\">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <div class=\"card-img-actions\"> <img");
            BeginWriteAttribute("src", " src=", 854, "", 870, 1);
#nullable restore
#line 23 "C:\Users\fedaa_1zoqddg\source\repos\Project3Phase3MVC\Project3Phase3MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 859, item.Image, 859, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img img-fluid\" width=\"96\" height=\"350\"");
            BeginWriteAttribute("alt", " alt=\"", 921, "\"", 927, 0);
            EndWriteAttribute();
            WriteLiteral(@"> </div>
                            </div>
                            <div class=""card-body bg-light text-center"">
                                <div class=""mb-2"">
                                    <h6 class=""font-weight-semibold mb-2""> <a href=""#"" class=""text-default mb-2"" data-abc=""true"">");
#nullable restore
#line 27 "C:\Users\fedaa_1zoqddg\source\repos\Project3Phase3MVC\Project3Phase3MVC\Views\Home\Index.cshtml"
                                                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </h6> <a href=\"#\" class=\"text-muted\" data-abc=\"true\">");
#nullable restore
#line 27 "C:\Users\fedaa_1zoqddg\source\repos\Project3Phase3MVC\Project3Phase3MVC\Views\Home\Index.cshtml"
                                                                                                                                                                                                Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </div>\r\n                                <h3 class=\"mb-0 font-weight-semibold\">$");
#nullable restore
#line 29 "C:\Users\fedaa_1zoqddg\source\repos\Project3Phase3MVC\Project3Phase3MVC\Views\Home\Index.cshtml"
                                                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <button type=\"button\" class=\"btn bg-cart\"><i class=\"fa fa-cart-plus mr-2\"></i> <a");
            BeginWriteAttribute("href", " href=\"", 1559, "\"", 1595, 2);
            WriteAttributeValue("", 1566, "/home/details/", 1566, 14, true);
#nullable restore
#line 30 "C:\Users\fedaa_1zoqddg\source\repos\Project3Phase3MVC\Project3Phase3MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1580, item.ProductID, 1580, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">More Details</a></button>
                                <button type=""button"" class=""btn bg-cart""><i class=""fa fa-cart-plus mr-2""></i> Add to cart</button>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 35 "C:\Users\fedaa_1zoqddg\source\repos\Project3Phase3MVC\Project3Phase3MVC\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n        </div>\r\n    \r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DotNet_Phase3_Project.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591