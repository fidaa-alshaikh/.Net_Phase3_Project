#pragma checksum "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a1cbc686f3754bf65e12e81f91bb61e3f484749"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddProduct), @"mvc.1.0.view", @"/Views/Home/AddProduct.cshtml")]
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
#line 1 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\_ViewImports.cshtml"
using Project3Phase3MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\_ViewImports.cshtml"
using Project3Phase3MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a1cbc686f3754bf65e12e81f91bb61e3f484749", @"/Views/Home/AddProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ecb3bed95309adf3d0c70d7de062f2c1e8b232b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNet_Phase3_Project.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
  
    ViewBag.Title = "AddProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>AddProduct</h2>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Product</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 17 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 19 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
       Write(Html.LabelFor(model => model.Category, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 21 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
           Write(Html.EditorFor(model => model.Category, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.Category, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 29 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 30 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 35 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
       Write(Html.LabelFor(model => model.Price, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 37 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
           Write(Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 38 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 43 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
       Write(Html.LabelFor(model => model.Image, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 45 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
           Write(Html.EditorFor(model => model.Image, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 46 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.Image, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 51 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 53 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
           Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 54 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 64 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 67 "C:\Users\fedaa_1zoqddg\OneDrive\Desktop\.NET-COURSE\Projects\.Net_Phase3_Project\Project3Phase3MVC\Project3Phase3MVC\Views\Home\AddProduct.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNet_Phase3_Project.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
