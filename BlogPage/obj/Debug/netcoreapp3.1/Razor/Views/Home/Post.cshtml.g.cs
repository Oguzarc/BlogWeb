#pragma checksum "C:\Users\Oğuz ARAÇ\source\repos\BlogWeb.api\BlogPage\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63b93161f7ed78afec17616efd1bfea2c735eef5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
#line 1 "C:\Users\Oğuz ARAÇ\source\repos\BlogWeb.api\BlogPage\Views\_ViewImports.cshtml"
using BlogPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Oğuz ARAÇ\source\repos\BlogWeb.api\BlogPage\Views\_ViewImports.cshtml"
using BlogPage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63b93161f7ed78afec17616efd1bfea2c735eef5", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ba1fbddc62dfb781ec3ecd25edb5540087e462b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogWeb.entity.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Oğuz ARAÇ\source\repos\BlogWeb.api\BlogPage\Views\Home\Post.cshtml"
   
    ViewData["Title"] = "Posts";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-wrapper"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"" style=""padding:25px"">
                    <div class=""col-mb-1"">
                        <div class=""col-md-4""><h3 class=""title"">");
#nullable restore
#line 11 "C:\Users\Oğuz ARAÇ\source\repos\BlogWeb.api\BlogPage\Views\Home\Post.cshtml"
                                                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3></div>\r\n                        <div class=\"col-md-3\"><h6 class=\"text-body\"> ");
#nullable restore
#line 12 "C:\Users\Oğuz ARAÇ\source\repos\BlogWeb.api\BlogPage\Views\Home\Post.cshtml"
                                                                Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogWeb.entity.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
