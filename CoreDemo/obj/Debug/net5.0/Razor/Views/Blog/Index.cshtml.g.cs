#pragma checksum "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bda7479a081dcd012bd04ec7a612f1cb5176bd27"
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
#line 1 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bda7479a081dcd012bd04ec7a612f1cb5176bd27", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <h3 class=\"tittle\">Blog Posts</h3>\r\n    <div class=\"inner-sec\">\r\n        <!--left-->\r\n        <div class=\"left-blog-info-w3layouts-agileits text-left\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 card border\">\r\n                        <a href=\"single.html\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 556, "\"", 577, 1);
#nullable restore
#line 18 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 562, item.BlogImage, 562, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 609, "\"", 615, 0);
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
#line 25 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"
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
#line 35 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"
                                                              Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li> \r\n\r\n                            </ul>\r\n                            <h5 class=\"card-title\">\r\n                                <a href=\"single.html\">");
#nullable restore
#line 41 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"
                                                 Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n");
#nullable restore
#line 43 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"
                             if (@item.BlogContent.Length > 130)
                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"card-text mb-3\">");
#nullable restore
#line 45 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"
                                                     Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n");
#nullable restore
#line 46 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"card-text mb-3\">");
#nullable restore
#line 50 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"
                                                 Write(item.BlogContent.PadRight(130,' '));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 51 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"
                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                         \r\n                            \r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2411, "\"", 2448, 2);
            WriteAttributeValue("", 2418, "/Blog/BlogDetails/", 2418, 18, true);
#nullable restore
#line 56 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2436, item.BlogId, 2436, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Read More</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 59 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Blog\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n            <!--//left-->\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
