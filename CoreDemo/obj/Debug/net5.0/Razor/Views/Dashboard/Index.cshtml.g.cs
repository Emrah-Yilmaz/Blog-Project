#pragma checksum "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "861b7cb43501131271d19532c8ff59749fc83bae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861b7cb43501131271d19532c8ff59749fc83bae", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutWriter.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

  <!-- partial -->
      <div class=""container-fluid page-body-wrapper"">

          <div class=""content-wrapper"">
          
            <div class=""page-header"">
              <h3 class=""page-title"">
                <span class=""page-title-icon bg-gradient-primary text-white mr-2"">
                  <i class=""mdi mdi-home""></i>
                </span> Dashboard
              </h3>
              <nav aria-label=""breadcrumb"">
                <ul class=""breadcrumb"">
                  <li class=""breadcrumb-item active"" aria-current=""page"">
                    <span></span>Overview <i class=""mdi mdi-alert-circle-outline icon-sm text-primary align-middle""></i>
                  </li>
                </ul>
              </nav>
            </div>
            <div class=""row"">
              <div class=""col-md-4 stretch-card grid-margin"">
                <div class=""card bg-gradient-danger card-img-holder text-white"">
                  <div class=""card-body"">
                    <img src=""/W");
            WriteLiteral(@"riterPanel/assets/images/dashboard/circle.svg"" class=""card-img-absolute"" alt=""circle-image"" />
                    <h4 class=""font-weight-normal mb-3"">Toplam Blog Sayısı<i class=""mdi mdi-chart-line mdi-24px float-right""></i>
                    </h4>
                    <h2 class=""mb-5"">0</h2>
                    <h6 class=""card-text"">Asp.Net Core Blog Projesi</h6>
                  </div>
                </div>
              </div>
              <div class=""col-md-4 stretch-card grid-margin"">
                <div class=""card bg-gradient-info card-img-holder text-white"">
                  <div class=""card-body"">
                    <img src=""/WriterPanel/assets/images/dashboard/circle.svg"" class=""card-img-absolute"" alt=""circle-image"" />
                    <h4 class=""font-weight-normal mb-3"">Sizin Blog Sayınız <i class=""mdi mdi-bookmark-outline mdi-24px float-right""></i>
                    </h4>
                    <h2 class=""mb-5"">0</h2>
                    <h6 class=""card-text"">Asp.Net Core ");
            WriteLiteral(@"Blog Projesi</h6>
                  </div>
                </div>
              </div>
              <div class=""col-md-4 stretch-card grid-margin"">
                <div class=""card bg-gradient-success card-img-holder text-white"">
                  <div class=""card-body"">
                    <img src=""/WriterPanel/assets/images/dashboard/circle.svg"" class=""card-img-absolute"" alt=""circle-image"" />
                    <h4 class=""font-weight-normal mb-3"">Son 7 Gündeki Blog Sayısı  <i class=""mdi mdi-diamond mdi-24px float-right""></i>
                    </h4>
                    <h2 class=""mb-5"">0</h2>
                    <h6 class=""card-text"">Asp.Net Core Blog Projesi</h6>
                  </div>
                </div>
              </div>
            </div>

            ");
#nullable restore
#line 63 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Dashboard\Index.cshtml"
       Write(await Component.InvokeAsync("BlogListDashboard"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            
            <div class=""row"">
              <div class=""col-12 grid-margin stretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <h4 class=""card-title"">Recent Updates</h4>
                    <div class=""d-flex"">
                      <div class=""d-flex align-items-center mr-4 text-muted font-weight-light"">
                        <i class=""mdi mdi-account-outline icon-sm mr-2""></i>
                        <span>jack Menqu</span>
                      </div>
                      <div class=""d-flex align-items-center text-muted font-weight-light"">
                        <i class=""mdi mdi-clock icon-sm mr-2""></i>
                        <span>October 3rd, 2018</span>
                      </div>
                    </div>
                    <div class=""row mt-3"">
                      <div class=""col-6 pr-1"">
                        <img src=""/WriterPanel/assets/images/dashboard/img_1.jpg"" class=""mb-2 mw-100 w-100 roun");
            WriteLiteral(@"ded"" alt=""image"">
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
                        <h5 class=""mr-2 mb-2"">School Website - Authentication Module.</h5>
                        <p class=""mb-0 font-weight-light"">It is a long established fact that a reader will be distracted by the readable content of a page.</");
            WriteLiteral(@"p>
                      </div>
                      <div class=""ml-auto"">
                        <i class=""mdi mdi-heart-outline text-muted""></i>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            ");
#nullable restore
#line 104 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\CoreBlog\Blog-Project\CoreDemo\Views\Dashboard\Index.cshtml"
       Write(await Component.InvokeAsync("CategoryListDashboard"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            \r\n          </div>  </div>\r\n          <!-- content-wrapper ends -->\r\n         ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
