#pragma checksum "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "055319a78205c8d4da49a8a0bc16c7ddc3aa1ce5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"055319a78205c8d4da49a8a0bc16c7ddc3aa1ce5", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n\t\t<div class=\"container\">\r\n\t\t\t\t<h3 class=\"tittle\">Giriş Sayfası</h3>\r\n\t\t\t\t<div class=\"row inner-sec\">\r\n\t\t\t\t\t<div class=\"login p-5 bg-light mx-auto mw-100\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Login\Index.cshtml"
             using (Html.BeginForm("Index","Login",FormMethod.Post))
			{

				

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Login\Index.cshtml"
           Write(Html.Label("Mail Adresiniz"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Login\Index.cshtml"
           Write(Html.TextBoxFor(x => x.WriterMail, new{@class="form-control", @id="exampleInputEmail1", @placeholder="example@gmail.com", @required=""}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<small id=\"emailHelp\" class=\"form-text text-muted\">We\'ll never share your email with anyone else.</small>\r\n");
#nullable restore
#line 20 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Login\Index.cshtml"
           Write(Html.Label("Şifreniz"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Login\Index.cshtml"
           Write(Html.TextBoxFor(x => x.WriterPassword, new{@class="form-control", @id="exampleInputEmail1", @placeholder="********", @required=""}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<button type=\"submit\" class=\"btn btn-primary submit mb-4\">Giriş Yap</button>\r\n\t\t\t\t<h2>");
#nullable restore
#line 24 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Login\Index.cshtml"
               Write(ViewBag.p);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t\t\t<p><a href=\"/Register/Index/\"> Don\'t have an account?</a></p>\r\n");
#nullable restore
#line 26 "C:\Users\emrah\OneDrive\Belgeler\GitHub\Blog-Project\CoreDemo\Views\Login\Index.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
