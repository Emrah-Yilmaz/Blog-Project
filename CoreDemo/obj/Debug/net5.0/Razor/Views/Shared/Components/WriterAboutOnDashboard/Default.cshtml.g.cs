#pragma checksum "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "070929587a5426011a28ecbd70affd6df7057671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterAboutOnDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterAboutOnDashboard/Default.cshtml")]
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
#line 1 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"070929587a5426011a28ecbd70affd6df7057671", @"/Views/Shared/Components/WriterAboutOnDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterAboutOnDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Writer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
     foreach (var item in Model)
   {
       
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Yazar Hakk??nda</h4>
                <div class=""d-flex"">
                    <div class=""d-flex align-items-center mr-4 text-muted font-weight-light"">
                        <i class=""mdi mdi-account-outline icon-sm mr-2""></i>
                        <span>");
#nullable restore
#line 16 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                         Write(item.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                    <div class=""d-flex align-items-center text-muted font-weight-light"">
                        <i class=""mdi mdi-clock icon-sm mr-2""></i>
                        <span>October 3rd, 2018</span>
                    </div>
                </div>
                <div class=""row mt-3"">
                    <div class=""col-6 pr-1"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 972, "\"", 995, 1);
#nullable restore
#line 25 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
WriteAttributeValue("", 978, item.WriterImage, 978, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""mb-2 mw-100 w-100 rounded"" alt=""image"">
                        <img src=""/WriterPanel/assets/images/dashboard/img_4.jpg"" class=""mw-100 w-100 rounded"" alt=""image"">
                    </div>
                    <div class=""col-6 pl-1"">
                        <img src=""/WriterPanel/assets/images/dashboard/img_2.jpg"" class=""mb-2 mw-100 w-100 rounded"" alt=""image"">
                        <img src=""/WriterPanel/assets/images/dashboard/img_3.jpg"" class=""mw-100 w-100 rounded"" alt=""image"">
                    </div>
                </div>
                <div class=""d-flex mt-5 align-items-top"">
                    <img src=""/WriterPanel/assets/images/faces/face3.jpg"" class=""img-sm rounded-circle mr-3"" alt=""image"">
                    <div class=""mb-0 flex-grow"">
                        <h5 class=""mr-2 mb-2"">");
#nullable restore
#line 36 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                         Write(item.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"mb-0 font-weight-light\">");
#nullable restore
#line 37 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                                     Write(item.WriterAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"ml-auto\">\r\n                        <i class=\"mdi mdi-heart-outline text-muted\"></i>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 46 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Writer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
