#pragma checksum "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Blog\BlogDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b10e64bea1578219e0e014a8baf7cf656e80b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetails), @"mvc.1.0.view", @"/Views/Blog/BlogDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25b10e64bea1578219e0e014a8baf7cf656e80b9", @"/Views/Blog/BlogDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema/images/b1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Blog\BlogDetails.cshtml"
  
    ViewData["Title"] = "BlogDetails";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>BlogDetails</h1>\n\n<div class=\"container\">\n    <div class=\"row\">\n        <!--left-->\n        <div class=\"col-lg-8 left-blog-info-w3layouts-agileits text-left\">\n");
#nullable restore
#line 13 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Blog\BlogDetails.cshtml"
             foreach (var item in Model)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"blog-grid-top\">\n                    <div class=\"b-grid-top\">\n                        <div class=\"blog_info_left_grid\">\n                            <a href=\"single.html\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25b10e64bea1578219e0e014a8baf7cf656e80b95652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                        </div>
                        <div class=""blog-info-middle"">
                            <ul>
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 28 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Blog\BlogDetails.cshtml"
                                                                        Write(((DateTime)item.CreateDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </li>
                                <li class=""mx-2"">
                                    <a href=""#"">
                                        <i class=""far fa-thumbs-up""></i> 0 Likes
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-comment""></i> 0 Comments
                                    </a>
                                </li>

                            </ul>
                        </div>
                    </div>

                    <h3>
                        <a href=""single.html"">");
#nullable restore
#line 47 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Blog\BlogDetails.cshtml"
                                         Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("   </a>\n                    </h3>\n                    <p>\n                        ");
#nullable restore
#line 50 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Blog\BlogDetails.cshtml"
                   Write(item.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <a href=\"/Blog/Index/\" class=\"btn btn-primary read-m\">Read More</a>\n                </div>\n");
#nullable restore
#line 54 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Blog\BlogDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 55 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Blog\BlogDetails.cshtml"
       Write(await Component.InvokeAsync("CommentListByBlog", new {id = ViewBag.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            ");
#nullable restore
#line 57 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Blog\BlogDetails.cshtml"
       Write(await Html.PartialAsync("/Views/Comment/PartialCommentAdd.cshtml", new {id = ViewBag.id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </div>\n\n        \n        <aside class=\"col-lg-4 agileits-w3ls-right-blog-con text-right\">\n            <div class=\"right-blog-info text-left\">\n                <div class=\"tech-btm\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25b10e64bea1578219e0e014a8baf7cf656e80b910179", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                ");
#nullable restore
#line 67 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Blog\BlogDetails.cshtml"
           Write(await Html.PartialAsync("~/Views/NewsLetterController1/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                \n                <div class=\"tech-btm\">\n                    ");
#nullable restore
#line 70 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Blog\BlogDetails.cshtml"
               Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                   \n                </div>\n                ");
#nullable restore
#line 73 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Blog\BlogDetails.cshtml"
           Write(await Component.InvokeAsync("WriterLastBlog"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                <div class=""single-gd tech-btm"">
                    <h4>Recent Post</h4>
                    <div class=""blog-grids"">
                        <div class=""blog-grid-left"">
                            <a href=""single.html"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25b10e64bea1578219e0e014a8baf7cf656e80b912731", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                        </div>
                        <div class=""blog-grid-right"">

                            <h5>
                                <a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
                            </h5>
                        </div>
                        <div class=""clearfix""> </div>
                    </div>
                </div>
            </div>

        </aside>
        <!--//right-->
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
