#pragma checksum "/Users/vlamtu/Projects/ecommerce_api.git/ThuongMaiDienTuAPI/WebMobileMVC/Views/Product/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b54ccc16166ca74ebe43188f2f964528a1b0379"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b54ccc16166ca74ebe43188f2f964528a1b0379", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "/Users/vlamtu/Projects/ecommerce_api.git/ThuongMaiDienTuAPI/WebMobileMVC/Views/Product/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 1035, true);
            WriteLiteral(@"
<!-- Start Page Title -->
<div class=""page-title"">
    <div class=""container"">
        <div class=""column"">
            <h1>Tất cả sản phẩm</h1>
        </div>
        <div class=""column"">
            <ul class=""breadcrumbs"">
                <li>
                    <a href=""index-1.html"">Trang chủ</a>
                </li>
                <li class=""separator"">&nbsp;</li>
                <li>Tất cả sản phẩm</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Title -->
<!-- Start Page Content -->
<div class=""container padding-top-1x padding-bottom-3x"">
    <div class=""row"">
        <!-- Start Categories Content -->
        <div class=""col-lg-9 order-lg-2"">
            <!-- Start Toolbar -->
            <div class=""shop-toolbar mb-30"">
                <div class=""column"">
                    <div class=""shop-sorting"">
                        <label for=""sorting"">Sắp xếp:</label>
                        <select class=""form-control"" id=""sorting"">
                 ");
            WriteLiteral("           ");
            EndContext();
            BeginContext(1069, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "908de0e1a85a41888068a496ea15bba4", async() => {
                BeginContext(1077, 8, true);
                WriteLiteral("Mặc định");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1094, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1124, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6ed7de35c8046ae8f4b72d862ebcccd", async() => {
                BeginContext(1132, 17, true);
                WriteLiteral("Gía từ thấp - cao");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1158, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1188, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e294d05e6a3431fbd469dbf679aa51f", async() => {
                BeginContext(1196, 17, true);
                WriteLiteral("Gía từ cao - thấp");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1222, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1252, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b2fa9e18c0d4fb8b273ad386420148f", async() => {
                BeginContext(1260, 9, true);
                WriteLiteral("Tên A - Z");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1278, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1308, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac81e8f5d159498fa0719e67129dd635", async() => {
                BeginContext(1316, 9, true);
                WriteLiteral("Tên Z - A");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1334, 26035, true);
            WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""column"">
                    <span class=""text-muted"">Hiển thị: </span><span> 1 - 12 sản phẩm</span>
                </div>
            </div>
            <!-- End Toolbar -->
            <!-- Start Products Grid -->
            <div class=""isotope-grid cols-3"">
                <div class=""gutter-sizer""></div>
                <div class=""grid-sizer""></div>
                <!-- Start Product #1 -->
                <div class=""grid-item"">
                    <div class=""product-card"">
                        <a class=""product-thumb"" href=""shop-single-3.html"">
                            <img src=""/assets/images/shop/products/01.jpg"" alt=""Product"">
                        </a>
                        <h3 class=""product-title""><a href=""shop-single-3.html"">iPhone x</a></h3>
                        <h4 class=""product-price"">
                            <del>$799.99</del>$649.99
    ");
            WriteLiteral(@"                    </h4>
                        <div class=""product-buttons"">
                            <button class=""btn btn-outline-secondary btn-sm btn-wishlist"" data-toggle=""tooltip"" title=""Whishlist"">
                                <i class=""icon-heart""></i>
                            </button>
                            <button class=""btn btn-outline-primary btn-sm"" data-toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Product"" data-toast-message=""successfuly added to cart!"">Thêm vào giỏ</button>
                        </div>
                    </div>
                </div>
                <!-- End Product #1 -->
                <!-- Start Product #2 -->
                <div class=""grid-item"">
                    <div class=""product-card"">
                        <a class=""product-thumb"" href=""#"">
                            <img src=""/assets/images/shop/products/05.jpg"" alt=""Product"">
                        </");
            WriteLiteral(@"a>
                        <h3 class=""product-title""><a href=""#"">Panasonic TX-32</a></h3>
                        <h4 class=""product-price"">$800.00</h4>
                        <div class=""product-buttons"">
                            <button class=""btn btn-outline-secondary btn-sm btn-wishlist"" data-toggle=""tooltip"" title=""Whishlist"">
                                <i class=""icon-heart""></i>
                            </button>
                            <button class=""btn btn-outline-primary btn-sm"" data-toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Product"" data-toast-message=""successfuly added to cart!"">Add to Cart</button>
                        </div>
                    </div>
                </div>
                <!-- End Product #2 -->
                <!-- Start Product #3 -->
                <div class=""grid-item"">
                    <div class=""product-card"">
                        <div class=""rating-stars""");
            WriteLiteral(@">
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star filled""></i>
                        </div>
                        <a class=""product-thumb"" href=""#"">
                            <img src=""/assets/images/shop/products/09.jpg"" alt=""Product"">
                        </a>
                        <h3 class=""product-title""><a href=""#"">Sony HDR-AS50R</a></h3>
                        <h4 class=""product-price"">$549.00</h4>
                        <div class=""product-buttons"">
                            <button class=""btn btn-outline-secondary btn-sm btn-wishlist"" data-toggle=""tooltip"" title=""Whishlist"">
                                <i class=""icon-heart""></i>
                            </button>
                            <button class=""btn btn-outline-pr");
            WriteLiteral(@"imary btn-sm"" data-toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Product"" data-toast-message=""successfuly added to cart!"">Add to Cart</button>
                        </div>
                    </div>
                </div>
                <!-- End Product #3 -->
                <!-- Start Product #4 -->
                <div class=""grid-item"">
                    <div class=""product-card"">
                        <a class=""product-thumb"" href=""#"">
                            <img src=""/assets/images/shop/products/13.jpg"" alt=""Product"">
                        </a>
                        <h3 class=""product-title""><a href=""#"">HP LaserJet Pro 200</a></h3>
                        <h4 class=""product-price"">
                            <del>$249.99</del>$189.99
                        </h4>
                        <div class=""product-buttons"">
                            <button class=""btn btn-outline-secondary btn-sm btn-wishli");
            WriteLiteral(@"st"" data-toggle=""tooltip"" title=""Whishlist"">
                                <i class=""icon-heart""></i>
                            </button>
                            <button class=""btn btn-outline-primary btn-sm"" data-toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Product"" data-toast-message=""successfuly added to cart!"">Add to Cart</button>
                        </div>
                    </div>
                </div>
                <!-- End Product #4 -->
                <!-- Start Product #5 -->
                <div class=""grid-item"">
                    <div class=""product-card"">
                        <a class=""product-thumb"" href=""#"">
                            <img src=""/assets/images/shop/products/17.jpg"" alt=""Product"">
                        </a>
                        <h3 class=""product-title""><a href=""#"">Apple Watch 3</a></h3>
                        <h4 class=""product-price"">$299.00</h4>
               ");
            WriteLiteral(@"         <div class=""product-buttons"">
                            <button class=""btn btn-outline-secondary btn-sm btn-wishlist"" data-toggle=""tooltip"" title=""Whishlist"">
                                <i class=""icon-heart""></i>
                            </button>
                            <button class=""btn btn-outline-primary btn-sm"" data-toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Product"" data-toast-message=""successfuly added to cart!"">Add to Cart</button>
                        </div>
                    </div>
                </div>
                <!-- End Product #5 -->
                <!-- Start Product #6 -->
                <div class=""grid-item"">
                    <div class=""product-card"">
                        <div class=""rating-stars"">
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star filled""></i>
                            <i class=""icon-s");
            WriteLiteral(@"tar filled""></i>
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star""></i>
                        </div>
                        <a class=""product-thumb"" href=""#"">
                            <img src=""/assets/images/shop/products/21.jpg"" alt=""Product"">
                        </a>
                        <h3 class=""product-title""><a href=""#"">Acer Aspire 15.6 i3</a></h3>
                        <h4 class=""product-price"">$649.00</h4>
                        <div class=""product-buttons"">
                            <button class=""btn btn-outline-secondary btn-sm btn-wishlist"" data-toggle=""tooltip"" title=""Whishlist"">
                                <i class=""icon-heart""></i>
                            </button>
                            <button class=""btn btn-outline-primary btn-sm"" data-toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Product"" data-toast-message=""successf");
            WriteLiteral(@"uly added to cart!"">Add to Cart</button>
                        </div>
                    </div>
                </div>
                <!-- End Product #6 -->
                <!-- Start Product #7 -->
                <div class=""grid-item"">
                    <div class=""product-card"">
                        <a class=""product-thumb"" href=""#"">
                            <img src=""/assets/images/shop/products/25.jpg"" alt=""Product"">
                        </a>
                        <h3 class=""product-title""><a href=""#"">Playstation 4</a></h3>
                        <h4 class=""product-price"">
                            <del>$499.99</del>$349.99
                        </h4>
                        <div class=""product-buttons"">
                            <button class=""btn btn-outline-secondary btn-sm btn-wishlist"" data-toggle=""tooltip"" title=""Whishlist"">
                                <i class=""icon-heart""></i>
                            </button>
                            <butto");
            WriteLiteral(@"n class=""btn btn-outline-primary btn-sm"" data-toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Product"" data-toast-message=""successfuly added to cart!"">Add to Cart</button>
                        </div>
                    </div>
                </div>
                <!-- End Product #7 -->
                <!-- Start Product #8 -->
                <div class=""grid-item"">
                    <div class=""product-card"">
                        <a class=""product-thumb"" href=""#"">
                            <img src=""/assets/images/shop/products/02.jpg"" alt=""Product"">
                        </a>
                        <h3 class=""product-title""><a href=""#"">Samsung Galaxy S8</a></h3>
                        <h4 class=""product-price"">$700.00</h4>
                        <div class=""product-buttons"">
                            <button class=""btn btn-outline-secondary btn-sm btn-wishlist"" data-toggle=""tooltip"" title=""Whishlist"">
   ");
            WriteLiteral(@"                             <i class=""icon-heart""></i>
                            </button>
                            <button class=""btn btn-outline-primary btn-sm"" data-toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Product"" data-toast-message=""successfuly added to cart!"">Add to Cart</button>
                        </div>
                    </div>
                </div>
                <!-- End Product #8 -->
                <!-- Start Product #9 -->
                <div class=""grid-item"">
                    <div class=""product-card"">
                        <div class=""rating-stars"">
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star""></i>
                        </div>
        ");
            WriteLiteral(@"                <a class=""product-thumb"" href=""#"">
                            <img src=""/assets/images/shop/products/06.jpg"" alt=""Product"">
                        </a>
                        <h3 class=""product-title""><a href=""#"">Sony VAIO Z8</a></h3>
                        <h4 class=""product-price"">$749.00</h4>
                        <div class=""product-buttons"">
                            <button class=""btn btn-outline-secondary btn-sm btn-wishlist"" data-toggle=""tooltip"" title=""Whishlist"">
                                <i class=""icon-heart""></i>
                            </button>
                            <button class=""btn btn-outline-primary btn-sm"" data-toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Product"" data-toast-message=""successfuly added to cart!"">Add to Cart</button>
                        </div>
                    </div>
                </div>
                <!-- End Product #9 -->
               ");
            WriteLiteral(@" <!-- Start Product #10 -->
                <div class=""grid-item"">
                    <div class=""product-card"">
                        <a class=""product-thumb"" href=""#"">
                            <img src=""/assets/images/shop/products/10.jpg"" alt=""Product"">
                        </a>
                        <h3 class=""product-title""><a href=""#"">JVC Camcorder X5</a></h3>
                        <h4 class=""product-price"">
                            <del>$899.99</del>$749.99
                        </h4>
                        <div class=""product-buttons"">
                            <button class=""btn btn-outline-secondary btn-sm btn-wishlist"" data-toggle=""tooltip"" title=""Whishlist"">
                                <i class=""icon-heart""></i>
                            </button>
                            <button class=""btn btn-outline-primary btn-sm"" data-toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Product"" data-t");
            WriteLiteral(@"oast-message=""successfuly added to cart!"">Add to Cart</button>
                        </div>
                    </div>
                </div>
                <!-- End Product #10 -->
                <!-- Start Product #11 -->
                <div class=""grid-item"">
                    <div class=""product-card"">
                        <a class=""product-thumb"" href=""#"">
                            <img src=""/assets/images/shop/products/14.jpg"" alt=""Product"">
                        </a>
                        <h3 class=""product-title""><a href=""#"">Canon LaserJet X6</a></h3>
                        <h4 class=""product-price"">$200.00</h4>
                        <div class=""product-buttons"">
                            <button class=""btn btn-outline-secondary btn-sm btn-wishlist"" data-toggle=""tooltip"" title=""Whishlist"">
                                <i class=""icon-heart""></i>
                            </button>
                            <button class=""btn btn-outline-primary btn-sm"" data-");
            WriteLiteral(@"toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Product"" data-toast-message=""successfuly added to cart!"">Add to Cart</button>
                        </div>
                    </div>
                </div>
                <!-- End Product #11 -->
                <!-- Start Product #12 -->
                <div class=""grid-item"">
                    <div class=""product-card"">
                        <div class=""rating-stars"">
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star filled""></i>
                            <i class=""icon-star""></i>
                        </div>
                        <a class=""product-thumb"" href=""#"">
                            <img src=""/assets/images/shop/products/18.jpg"" alt=""Product"">
                        </a>
 ");
            WriteLiteral(@"                       <h3 class=""product-title""><a href=""#"">Android Watch X8</a></h3>
                        <h4 class=""product-price"">$255.00</h4>
                        <div class=""product-buttons"">
                            <button class=""btn btn-outline-secondary btn-sm btn-wishlist"" data-toggle=""tooltip"" title=""Whishlist"">
                                <i class=""icon-heart""></i>
                            </button>
                            <button class=""btn btn-outline-primary btn-sm"" data-toast data-toast-type=""success"" data-toast-position=""topRight"" data-toast-icon=""icon-circle-check"" data-toast-title=""Product"" data-toast-message=""successfuly added to cart!"">Add to Cart</button>
                        </div>
                    </div>
                </div>
                <!-- End Product #12 -->
            </div>
            <!-- End Products Grid -->
            <!-- Start Pagination -->
            <nav class=""pagination"">
                <div class=""column text-left"">");
            WriteLiteral(@"
                    <a class=""btn btn-outline-secondary btn-sm"" href=""#""><i class=""icon-arrow-left""></i> Trang trước</a>
                </div>
                <div class=""column"">
                    <ul class=""pages"">
                        <li class=""active""><a href=""#"">1</a></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li>...</li>
                        <li><a href=""#"">10</a></li>
                        <li><a href=""#"">20</a></li>
                        <li><a href=""#"">30</a></li>
                    </ul>
                </div>
                <div class=""column text-right hidden-xs-down"">
                    <a class=""btn btn-outline-secondary btn-sm"" href=""#"">Trang sau <i class=""icon-arrow-right""></i></a>
                </div>
            </nav>
            <!-- End Pagination -->
        </div>
        <!-- End Categories Content -->
        <!-- Start Sidebar -->
        <div class=""col-l");
            WriteLiteral(@"g-3 order-lg-1 hidden-md-down"">
            <aside class=""sidebar"">
                <div class=""padding-top-2x hidden-lg-up""></div>
                <!-- Start Categories Widget -->
                <section class=""widget widget-categories"">
                    <h3 class=""widget-title"">Danh mục</h3>
                    <ul>
                        <li class=""has-children expanded"">
                            <a href=""#"">Mobile Phones</a><span>(1277)</span>
                            <ul>
                                <li>
                                    <a href=""#"">Apple</a><span>(700)</span>
                                    <ul>
                                        <li><a href=""#"">iPhone x 64GB</a></li>
                                        <li><a href=""#"">iPhone 8 128GB</a></li>
                                        <li><a href=""#"">iPhone 7 Red</a></li>
                                        <li><a href=""#"">iPhone 6 Plus</a></li>
                                    </ul>
 ");
            WriteLiteral(@"                               </li>
                                <li>
                                    <a href=""#"">Samsung</a><span>(500)</span>
                                    <ul>
                                        <li><a href=""#"">Samsung Galaxy S8</a></li>
                                        <li><a href=""#"">Samsung Galaxy S7</a></li>
                                        <li><a href=""#"">Samsung Galaxy J5</a></li>
                                        <li><a href=""#"">Samsung Golden A5</a></li>
                                    </ul>
                                </li>
                                <li><a href=""#"">Nokia Mobile</a><span>(37)</span></li>
                                <li><a href=""#"">BlackBerry Phones</a><span>(42)</span></li>
                            </ul>
                        </li>
                        <li class=""has-children"">
                            <a href=""#"">PC & Laptops</a><span>(800)</span>
                            <ul>
 ");
            WriteLiteral(@"                               <li>
                                    <a href=""#"">Apple</a><span>(500)</span>
                                    <ul>
                                        <li><a href=""#"">MacBook Pro 13.3</a></li>
                                        <li><a href=""#"">MacBook Pro 15.6</a></li>
                                        <li><a href=""#"">MacBook Pro 17</a></li>
                                        <li><a href=""#"">MacBook Pro 19</a></li>
                                    </ul>
                                </li>
                                <li>
                                    <a href=""#"">Lenovo</a><span>(250)</span>
                                    <ul>
                                        <li><a href=""#"">Lenovo Core i3</a></li>
                                        <li><a href=""#"">Lenovo Core i5</a></li>
                                        <li><a href=""#"">Lenovo Core i7</a></li>
                                        <li><a href=""#"">L");
            WriteLiteral(@"enovo Core 2 Quad</a></li>
                                    </ul>
                                </li>
                                <li><a href=""#"">Asus</a><span>(50)</span></li>
                            </ul>
                        </li>
                        <li class=""has-children"">
                            <a href=""#"">Tabs & Tablets</a><span>(420)</span>
                            <ul>
                                <li><a href=""#"">iPad 3 1TB</a><span>(180)</span></li>
                                <li><a href=""#"">Samsung Tab Pro</a><span>(140)</span></li>
                                <li><a href=""#"">Lenovo Tab 3TB</a><span>(100)</span></li>
                            </ul>
                        </li>
                        <li class=""has-children"">
                            <a href=""#"">Accessories</a><span>(760)</span>
                            <ul>
                                <li><a href=""#"">Televisions</a><span>(160)</span></li>
                     ");
            WriteLiteral(@"           <li><a href=""#"">Camcorders</a><span>(100)</span></li>
                                <li><a href=""#"">Watches</a><span>(100)</span></li>
                                <li><a href=""#"">Jewelry</a><span>(200)</span></li>
                                <li><a href=""#"">Other</a><span>(200)</span></li>
                            </ul>
                        </li>
                    </ul>
                </section>
                <!-- End Categories Widget -->
                <!--  Start Price Range Widget -->
                <section class=""widget widget-categories"">
                    <h3 class=""widget-title"">Lọc theo gía</h3>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""<3.5tr"">
                        <label class=""custom-control-label"" for=""<3.5tr"">0 - 3.500.000 VND</label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
             ");
            WriteLiteral(@"           <input class=""custom-control-input"" type=""checkbox"" id=""3.5-10tr"">
                        <label class=""custom-control-label"" for=""3.5-10tr"">3.500.000 - 10.000.000 VND</label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id="">10tr"">
                        <label class=""custom-control-label"" for="">10tr"">10.000.000 - 20.000.000 VND</label>
                    </div>
                </section>
                <!--  End Price Range Widget -->
                <!-- Start Brand Filter Widget -->
                <section class=""widget"">
                    <h3 class=""widget-title"">Lọc theo hãng</h3>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""apple"">
                        <label class=""custom-control-label"" for=""apple"">Apple <span class=""text-muted"">(197)</span></label");
            WriteLiteral(@">
                    </div>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""samsung"">
                        <label class=""custom-control-label"" for=""samsung"">Samsung <span class=""text-muted"">(123)</span></label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""sony"">
                        <label class=""custom-control-label"" for=""sony"">Sony <span class=""text-muted"">(148)</span></label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""nokia"">
                        <label class=""custom-control-label"" for=""nokia"">Nokia <span class=""text-muted"">(164)</span></label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
");
            WriteLiteral(@"                        <input class=""custom-control-input"" type=""checkbox"" id=""oppo"">
                        <label class=""custom-control-label"" for=""oppo"">Oppo <span class=""text-muted"">(139)</span></label>
                    </div>
                </section>
                <!-- End Brand Filter Widget -->
                <!-- Start Size Filter Widget -->
                <section class=""widget"">
                    <h3 class=""widget-title"">Lọc theo màu</h3>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""trang"">
                        <label class=""custom-control-label"" for=""trang"">Trắng</label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""den"">
                        <label class=""custom-control-label"" for=""den"">Đen</label>
                    </div>
                ");
            WriteLiteral(@"    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""do"">
                        <label class=""custom-control-label"" for=""do"">Đỏ</label>
                    </div>
                </section>
                <!-- End Size Filter Widget -->
            </aside>
        </div>
        <!-- End Sidebar -->
    </div>
</div>
<!-- End Page Content -->");
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
