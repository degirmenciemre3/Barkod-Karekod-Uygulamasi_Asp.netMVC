#pragma checksum "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "311960463f415a652681c1bf4f1f4b7f20210fb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_QRCodeScanner), @"mvc.1.0.view", @"/Views/Product/QRCodeScanner.cshtml")]
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
#line 1 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\_ViewImports.cshtml"
using KarekodBarkodUygulaması;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\_ViewImports.cshtml"
using KarekodBarkodUygulaması.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\_ViewImports.cshtml"
using KarekodBarkodUygulaması.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"311960463f415a652681c1bf4f1f4b7f20210fb5", @"/Views/Product/QRCodeScanner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"befa7bcebee9ac535a363e499e8f69c95e1f3fb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_QRCodeScanner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
  
    ViewData["Title"] = "QRCodeScanner Product Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .card {
        margin-bottom: 30px;
    }

    .card {
        position: relative;
        display: flex;
        flex-direction: column;
        min-width: 0;
        word-wrap: break-word;
        background-color: #fff;
        background-clip: border-box;
        border: 0 solid transparent;
        border-radius: 0;
    }

        .card .card-subtitle {
            font-weight: 300;
            margin-bottom: 10px;
            color: #8898aa;
        }

    .table-product.table-striped tbody tr:nth-of-type(odd) {
        background-color: #f3f8fa !important
    }

    .table-product td {
        border-top: 0px solid #dee2e6 !important;
        color: #728299 !important;
    }

    .kutu img {
        width: 100%;
        height: 100%;
        object-fit: cover;
    }
</style>
<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"">

<!--Taratılan ürün veritabanında var ise-->
");
#nullable restore
#line 47 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
 if (Model.Products.Count() != 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <!--Ürün detay bilgileri listelenir-->\r\n");
#nullable restore
#line 52 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
         foreach (var p in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h3 class=\"card-title\">");
#nullable restore
#line 56 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
                                      Write(p.productName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-12\">\r\n                            <div class=\"white-box text-center kutu\"");
            BeginWriteAttribute("style", " style=\"", 1553, "\"", 1561, 0);
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=", 1567, "", 1588, 1);
#nullable restore
#line 59 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
WriteAttributeValue("", 1572, p.productImgUrl, 1572, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 1588, "", 1607, 1);
#nullable restore
#line 59 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
WriteAttributeValue("", 1593, p.productName, 1593, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive""></div>
                        </div>
                        <div class=""col-lg-12 col-md-12 col-sm-12"">
                            <h3 class=""box-title mt-5"">Ürün Genel Bilgileri</h3>
                            <div class=""table-responsive"">
                                <table class=""table table-striped table-product"">
                                    <tbody>
                                        <tr>
                                            <td width=""390"">Ürün Açıklaması</td>
                                            <td>");
#nullable restore
#line 68 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
                                           Write(p.productAciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <td width=\"390\">Ürün Fiyatı</td>\r\n                                            <td>");
#nullable restore
#line 72 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
                                           Write(p.productFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <td>Ürün Barkodu</td>\r\n                                            <td>");
#nullable restore
#line 76 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
                                           Write(p.productBarkod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <td>Ürün Stok Adeti</td>\r\n                                            <td>");
#nullable restore
#line 80 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
                                           Write(p.productAdet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <td>Ürün Barkodu</td>\r\n                                            <td><img");
            BeginWriteAttribute("src", " src=", 3130, "", 3157, 1);
#nullable restore
#line 84 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
WriteAttributeValue("", 3135, p.productBarkodImgUrl, 3135, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 3157, "", 3176, 1);
#nullable restore
#line 84 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
WriteAttributeValue("", 3162, p.productName, 3162, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive"" width=""250"" height=""100""></td>
                                        </tr>
                                        <tr>
                                            <td>Ürün Karekodu</td>
                                            <td><img");
            BeginWriteAttribute("src", " src=", 3445, "", 3466, 1);
#nullable restore
#line 88 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
WriteAttributeValue("", 3450, p.karekodImgUrl, 3450, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 3466, "", 3485, 1);
#nullable restore
#line 88 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
WriteAttributeValue("", 3471, p.productName, 3471, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive"" width=""100"" height=""100""></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 97 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 99 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!--Ürün veritabanında yoksa ekrana taratılan barkod ve bilgilendirici mesaj verilir-->
    <div class=""container d-flex justify-content-center mt-5"">
        <div class=""row"">
            <div class=""col-md-12 bg-info rounded"">
                <h1 class=""text-white"">Tarattığınız Ürün Bulunmamakta</h1>
                <h4 class=""text-white"">Tarattığınız Ürün Barkodu : ");
#nullable restore
#line 107 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
                                                              Write(ViewBag.QRCodeText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 111 "C:\Users\User\Desktop\programlama\web-programlama\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Views\Product\QRCodeScanner.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
