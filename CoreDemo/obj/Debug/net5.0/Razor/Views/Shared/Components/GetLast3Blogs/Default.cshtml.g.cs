#pragma checksum "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Shared\Components\GetLast3Blogs\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "832ac7323bfa3ec07c7701ec9617e4768799c9c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetLast3Blogs_Default), @"mvc.1.0.view", @"/Views/Shared/Components/GetLast3Blogs/Default.cshtml")]
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
#line 1 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Shared\Components\GetLast3Blogs\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"832ac7323bfa3ec07c7701ec9617e4768799c9c6", @"/Views/Shared/Components/GetLast3Blogs/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_GetLast3Blogs_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n      <div class=\"tech-btm\">\n                    <h3>Son Gönderiler</h3>\n\n");
#nullable restore
#line 7 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Shared\Components\GetLast3Blogs\Default.cshtml"
           foreach(var item in Model)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"blog-grids row mb-3\">\n                        <div class=\"col-md-5 blog-grid-left\">\n                            <a");
            BeginWriteAttribute("href", " href=\"", 329, "\"", 366, 2);
            WriteAttributeValue("", 336, "/Blog/BlogDetails/", 336, 18, true);
#nullable restore
#line 11 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Shared\Components\GetLast3Blogs\Default.cshtml"
WriteAttributeValue("", 354, item.BlogId, 354, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <img");
            BeginWriteAttribute("src", " src=\"", 405, "\"", 426, 1);
#nullable restore
#line 12 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Shared\Components\GetLast3Blogs\Default.cshtml"
WriteAttributeValue("", 411, item.BlogImage, 411, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 458, "\"", 464, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            </a>\n                        </div>\n                        <div class=\"col-md-7 blog-grid-right\">\n\n                            <h5>\n                                <a href=\"single.html\">");
#nullable restore
#line 18 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Shared\Components\GetLast3Blogs\Default.cshtml"
                                                 Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </a>\n                            </h5>\n                            <div class=\"sub-meta\">\n                                <span>\n                                    <i class=\"far fa-clock\"></i>");
#nullable restore
#line 22 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Shared\Components\GetLast3Blogs\Default.cshtml"
                                                            Write(((DateTime)item.CreateDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </span>\n                            </div>\n                        </div>\n\n                    </div>\n");
#nullable restore
#line 28 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Shared\Components\GetLast3Blogs\Default.cshtml"


                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591