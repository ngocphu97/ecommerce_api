#pragma checksum "/Users/vlamtu/Projects/ecommerce_api.git/ThuongMaiDienTuAPI/WebMobileMVC/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea0d5684a521152e0b9ffe4cc4e46dbb182360c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "/Users/vlamtu/Projects/ecommerce_api.git/ThuongMaiDienTuAPI/WebMobileMVC/Views/_ViewImports.cshtml"
using WebMobileMVC;

#line default
#line hidden
#line 2 "/Users/vlamtu/Projects/ecommerce_api.git/ThuongMaiDienTuAPI/WebMobileMVC/Views/_ViewImports.cshtml"
using WebMobileMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea0d5684a521152e0b9ffe4cc4e46dbb182360c4", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Header.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Footer.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 36, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n");
            EndContext();
            BeginContext(36, 1285, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95b922fd79524cf4aaac1192629bf3db", async() => {
                BeginContext(42, 1272, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""description"" content="""">
    <meta name=""keywords"" content="""">
    <meta name=""author"" content="""">
    <title>Cam Phone Store</title>
    <!-- Mobile Specific Meta Tag -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <!-- Favicon -->
    <link rel=""icon"" type=""image/x-icon"" href=""/assets/images/favicon.ico"">
    <!-- Bootsrap CSS -->
    <link rel=""stylesheet"" media=""screen"" href=""/assets/css/bootstrap.min.css"">
    <!-- Font Awesome CSS -->
    <link rel=""stylesheet"" media=""screen"" href=""/assets/css/font-awesome.min.css"">
    <!-- Feather Icons CSS -->
    <link rel=""stylesheet"" media=""screen"" href=""/assets/css/feather-icons.css"">
    <!-- Pixeden Icons CSS -->
    <link rel=""stylesheet"" media=""screen"" href=""/assets/css/pixeden.css"">
    <!-- Social Icons CSS -->
    <link rel=""stylesheet"" media=""screen"" href=""/assets/css/socicon.css"">
    <!-- PhotoSwipe CSS -->
    <link rel=""stylesheet"" media=""screen"" href=""");
                WriteLiteral("/assets/css/photoswipe.css\">\r\n    <!-- Izitoast Notification CSS -->\r\n    <link rel=\"stylesheet\" media=\"screen\" href=\"/assets/css/izitoast.css\">\r\n    <!-- Main Style CSS -->\r\n    <link rel=\"stylesheet\" media=\"screen\" href=\"/assets/css/style.css\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1321, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1323, 2907, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11a0e07b85e440a1aacccd2997e7f3ac", async() => {
                BeginContext(1329, 1247, true);
                WriteLiteral(@"
    <!-- Start Page Preloader -->
    <div id=""loading"">
        <div id=""loading-center"">
            <div id=""loading-center-absolute"">
                <div class=""object"" id=""object_four""></div>
                <div class=""object"" id=""object_three""></div>
                <div class=""object"" id=""object_two""></div>
                <div class=""object"" id=""object_one""></div>
            </div>
        </div>
    </div>
    <!-- End Page Preloader -->
    <!-- Start TopBar -->
    <div class=""topbar"">
        <div class=""topbar-column"">
            <a href=""#"">Kênh người bán</a>
        </div>
        <div class=""topbar-column"">
            <a href=""account-notification.html""><i class=""icon-bell""></i> Thông Báo&nbsp;</a>
            <a class=""social-button sb-facebook shape-none sb-dark soc-border"" href=""#"" target=""_blank""><i class=""socicon-facebook""></i></a>
            <a class=""social-button sb-twitter shape-none sb-dark"" href=""#"" target=""_blank""><i class=""socicon-twitter""></i></a>
   ");
                WriteLiteral("         <a class=\"social-button sb-instagram shape-none sb-dark\" href=\"#\" target=\"_blank\"><i class=\"socicon-instagram\"></i></a>\r\n        </div>\r\n    </div>\r\n    <!-- End TopBar -->\r\n    <!-- Start NavBar (Header) -->\r\n    ");
                EndContext();
                BeginContext(2576, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52e0e06a418842d4b9c610edee47c9e8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2608, 81, true);
                WriteLiteral("\r\n    <!-- End NavBar (Header) -->\r\n    <div class=\"offcanvas-wrapper\">\r\n        ");
                EndContext();
                BeginContext(2690, 12, false);
#line 60 "/Users/vlamtu/Projects/ecommerce_api.git/ThuongMaiDienTuAPI/WebMobileMVC/Views/Shared/_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2702, 41, true);
                WriteLiteral("\r\n        <!-- Start Footer -->\r\n        ");
                EndContext();
                BeginContext(2743, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e1eded32c184c9ea26325a0c411ec6f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2775, 1448, true);
                WriteLiteral(@"
        <!-- End Footer -->
    </div>
    <!-- Start Back To Top -->
    <a class=""scroll-to-top-btn"" href=""#"">
        <i class=""icon-arrow-up""></i>
    </a>
    <!-- End Back To Top -->
    <div class=""site-backdrop""></div>
    <!-- Modernizr JS -->
    <script src=""/assets/js/modernizr.min.js""></script>
    <!-- JQuery JS -->
    <script src=""/assets/js/jquery.min.js""></script>
    <!-- Popper JS -->
    <script src=""/assets/js/popper.min.js""></script>
    <!-- Bootstrap JS -->
    <script src=""/assets/js/bootstrap.min.js""></script>
    <!-- CountDown JS -->
    <script src=""/assets/js/count.min.js""></script>
    <!-- Gmap JS -->
    <script src=""/assets/js/gmap.min.js""></script>
    <!-- ImageLoader JS -->
    <script src=""/assets/js/imageloader.min.js""></script>
    <!-- Isotope JS -->
    <script src=""/assets/js/isotope.min.js""></script>
    <!-- NouiSlider JS -->
    <script src=""/assets/js/nouislider.min.js""></script>
    <!-- OwlCarousel JS -->
    <script src=""/assets/j");
                WriteLiteral(@"s/owl.carousel.min.js""></script>
    <!-- PhotoSwipe UI JS -->
    <script src=""/assets/js/photoswipe-ui-default.min.js""></script>
    <!-- PhotoSwipe JS -->
    <script src=""/assets/js/photoswipe.min.js""></script>
    <!-- Velocity JS -->
    <script src=""/assets/js/velocity.min.js""></script>
    <!-- Main JS -->
    <script src=""/assets/js/script.js""></script>
    <script src=""/assets/js/custom.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4230, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
