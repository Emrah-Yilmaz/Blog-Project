#pragma checksum "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb21c23aa7738c9f5139927c203cb1053f9dfd1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb21c23aa7738c9f5139927c203cb1053f9dfd1c", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb21c23aa7738c9f5139927c203cb1053f9dfd1c3980", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\">Yazar Ekibimize Katıl </h3>\r\n        <div class=\"inner-sec\">\r\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n\r\n");
#nullable restore
#line 18 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml"
                 using (Html.BeginForm("Index", "Register", FormMethod.Post))
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-row\">\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            ");
#nullable restore
#line 24 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.Label("Ad Soyad"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 25 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterName, new{@class="form-control", @placeholder="Adınız..."}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 26 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterName,"",new{@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6 mb-3\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml"
                   Write(Html.Label("Mail Adresi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 30 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterMail, new{@class="form-control", @placeholder="ornek@gmail.com"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 31 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml"
                   Write(Html.ValidationMessageFor(x => x.WriterMail,"", new{@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-row\">\r\n                        <div class=\"form-group col-md-6\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml"
                   Write(Html.Label("Şifreniz"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                        ");
#nullable restore
#line 37 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterPassword, new{@class="form-control", @placeholder="**************", Type="password"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 38 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml"
                   Write(Html.ValidationMessageFor(x => x.WriterPassword,"",new{@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <button type=""submit"" class=""btn btn-primary submit mb-4"">Kayıt Ol!</button>
                    <p>
                        <a href=""#"" id=""btn1"">Tüm şartları okudum ve kabul ediyorum</a>
                    </p>
");
#nullable restore
#line 45 "C:\Users\emrahyilmaz_cloud1\Desktop\MyProject\Blog-Project-main\CoreDemo\Views\Register\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<script>\r\n    $(\'#btn1\').click( function(){\r\n    swal(\"Hello world!\");\r\n\r\n    });\r\n</script>\r\n");
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
