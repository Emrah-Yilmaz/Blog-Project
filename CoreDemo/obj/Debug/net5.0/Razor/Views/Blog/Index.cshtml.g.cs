#pragma checksum "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be9a479d8707c5d921954838ac3c206df892876f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be9a479d8707c5d921954838ac3c206df892876f", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <h3 class=\"tittle\">Blog Posts</h3>\n    <div class=\"inner-sec\">\n        <!--left-->\n        <div class=\"left-blog-info-w3layouts-agileits text-left\">\n            <div class=\"row\">\n");
#nullable restore
#line 14 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Blog\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 card border\">\n                        <a href=\"single.html\">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 539, "\"", 560, 1);
#nullable restore
#line 18 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 545, item.BlogImage, 545, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 592, "\"", 598, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                        <div class=""card-body"">
                            <ul class=""blog-icons my-4"">
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i>
                                        ");
#nullable restore
#line 25 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Blog\Index.cshtml"
                                    Write(((DateTime)item.CreateDate).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </li>
                                <li class=""mx-2"">
                                    <a href=""#"">
                                        <i class=""far fa-comment""></i> 21
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <i class=""fas fa-eye""></i> ");
#nullable restore
#line 35 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Blog\Index.cshtml"
                                                              Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </a>\n                                </li> \n\n                            </ul>\n                            <h5 class=\"card-title\">\n                                <a href=\"single.html\">");
#nullable restore
#line 41 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Blog\Index.cshtml"
                                                 Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            </h5>\n                            <p class=\"card-text mb-3\">");
#nullable restore
#line 43 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Blog\Index.cshtml"
                                                 Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1951, "\"", 1988, 2);
            WriteAttributeValue("", 1958, "/Blog/BlogDetails/", 1958, 18, true);
#nullable restore
#line 44 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1976, item.BlogId, 1976, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Read More</a>\n                        </div>\n                    </div>\n");
#nullable restore
#line 47 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Blog\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n            </div>\n            <!--//left-->\n        </div>\n\n\n    </div>\n</div>\n\n");
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
