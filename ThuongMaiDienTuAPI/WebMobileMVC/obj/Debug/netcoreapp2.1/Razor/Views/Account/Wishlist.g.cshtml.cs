#pragma checksum "/Users/vlamtu/Projects/ecommerce_api.git/ThuongMaiDienTuAPI/WebMobileMVC/Views/Account/Wishlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c772410da999e7d5b1f1cbbabee1341d10f53f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Wishlist), @"mvc.1.0.view", @"/Views/Account/Wishlist.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Wishlist.cshtml", typeof(AspNetCore.Views_Account_Wishlist))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c772410da999e7d5b1f1cbbabee1341d10f53f1", @"/Views/Account/Wishlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Wishlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "/Users/vlamtu/Projects/ecommerce_api.git/ThuongMaiDienTuAPI/WebMobileMVC/Views/Account/Wishlist.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 6693, true);
            WriteLiteral(@"
<!-- Start Page Title -->
<div class=""page-title"">
    <div class=""container"">
        <div class=""column"">
            <h1>Sản phẩm đã thích</h1>
        </div>
        <div class=""column"">
            <ul class=""breadcrumbs"">
                <li><a href=""index-1.html"">Trang chủ</a></li>
                <li class=""separator"">&nbsp;</li>
                <li>Sản phẩm đã thích</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Title -->
<!-- Start My Wishlist -->
<div class=""container padding-top-1x padding-bottom-3x"">
    <div class=""row"">
        <div class=""col-lg-4"">
            <aside class=""user-info-wrapper"">
                <div class=""user-cover account-details"">
                    <div class=""info-label"" data-toggle=""tooltip"" title=""You currently have 530 Reward Points to spend""><i class=""icon-medal""></i>530 Điểm</div>
                </div>
                <div class=""user-info"">
                    <div class=""user-avatar""><a class=""edit-avatar"" href=""#");
            WriteLiteral(@"""></a><img src=""/assets/images/account/user-ava.jpg"" alt=""User""></div>
                    <div class=""user-data"">
                        <h4>Tony Stark</h4><span>Joined February 06, 2018</span>
                    </div>
                </div>
            </aside>
            <nav class=""list-group"">
                <a class=""list-group-item"" href=""account-profile.html""><i class=""icon-head""></i>Thông tin tài khoản</a>
                <a class=""list-group-item"" href=""account-bank.html""><i class=""icon-columns""></i>Ngân hàng</a>
                <a class=""list-group-item with-badge"" href=""account-orders.html""><i class=""icon-bag""></i>Đơn hàng<span class=""badge badge-primary badge-pill"">6</span></a>
                <a class=""list-group-item with-badge  active"" href=""account-wishlist.html""><i class=""icon-heart""></i>Sản phẩm đã thích<span class=""badge badge-primary badge-pill"">3</span></a>
                <a class=""list-group-item with-badge"" href=""account-notification.html""><i class=""icon-bell""></i>Thôn");
            WriteLiteral(@"g báo<span class=""badge badge-primary badge-pill"">4</span></a>
                <a class=""list-group-item"" href=""account-changepass.html""><i class=""icon-repeat""></i>Đổi mật khẩu</a>
            </nav>
        </div>
        <div class=""col-lg-8"">
            <div class=""padding-top-2x mt-2 hidden-lg-up""></div>
            <!-- Wishlist Table-->
            <div class=""table-responsive wishlist-table margin-bottom-none"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Product Name</th>
                            <th class=""text-center""><a class=""btn btn-sm btn-outline-danger"" href=""#"">Empty Wishlist</a></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <div class=""product-item"">
                                    <a class=""product-thumb"" href=""shop-single-1.html""><img src=""/asset");
            WriteLiteral(@"s/images/shop/cart/01.jpg"" alt=""Product""></a>
                                    <div class=""product-info"">
                                        <h4 class=""product-title""><a href=""shop-single-1.html"">iPhone X Black</a></h4>
                                        <div class=""text-lg text-medium text-muted"">$649.00</div>
                                        <div>
                                            Availability:
                                            <div class=""d-inline text-success"">In Stock</div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                            <td class=""text-center""><a class=""remove-from-cart"" href=""#"" data-toggle=""tooltip"" title=""Remove item""><i class=""icon-cross""></i></a></td>
                        </tr>
                        <tr>
                            <td>
                                <div class=""product-item"">
   ");
            WriteLiteral(@"                                 <a class=""product-thumb"" href=""shop-single-1.html""><img src=""/assets/images/shop/cart/02.jpg"" alt=""Product""></a>
                                    <div class=""product-info"">
                                        <h4 class=""product-title""><a href=""shop-single-1.html"">Panasonic TX-32</a></h4>
                                        <div class=""text-lg text-medium text-muted"">$800.00</div>
                                        <div>
                                            Availability:
                                            <div class=""d-inline text-warning"">2 - 3 Days</div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                            <td class=""text-center""><a class=""remove-from-cart"" href=""#"" data-toggle=""tooltip"" title=""Remove item""><i class=""icon-cross""></i></a></td>
                        </tr>
                        ");
            WriteLiteral(@"<tr>
                            <td>
                                <div class=""product-item"">
                                    <a class=""product-thumb"" href=""shop-single-1.html""><img src=""/assets/images/shop/cart/03.jpg"" alt=""Product""></a>
                                    <div class=""product-info"">
                                        <h4 class=""product-title""><a href=""shop-single-1.html"">Acer Aspire 15.6 i3</a></h4>
                                        <div class=""text-lg text-medium text-muted"">$549.00</div>
                                        <div>
                                            Availability:
                                            <div class=""d-inline text-danger"">Out Of Stock</div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                            <td class=""text-center""><a class=""remove-from-cart"" href=""#"" data-toggle=""tooltip"" titl");
            WriteLiteral(@"e=""Remove item""><i class=""icon-cross""></i></a></td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <hr class=""mb-4"">
            <div class=""custom-control custom-checkbox"">
                <input class=""custom-control-input"" type=""checkbox"" id=""inform_me"" checked>
                <label class=""custom-control-label"" for=""inform_me"">Inform me when item from my wishlist is available</label>
            </div>
        </div>
    </div>
</div>
<!-- End My Wishlist -->");
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
