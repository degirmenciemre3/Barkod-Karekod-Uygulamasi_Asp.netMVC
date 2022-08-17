using BarcodeLib;
using KarekodBarkodUygulaması.Models;
using KarekodBarkodUygulaması.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using ZXing;
using ZXing.Windows.Compatibility;

namespace KarekodBarkodUygulaması.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        private readonly IWebHostEnvironment _hostEnvironment;
        public ProductController(IProductsRepository repo, IWebHostEnvironment hostEnvironment)
        {
            repository = repo;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index(int productID)
        {
            return View(new ProductsViewModel
            {
                Products = repository.Products.Where(s => s.productID == productID)
            });
        }

        public IActionResult AllProduct(int page =1)
        {
            return View(repository.Products.ToList().ToPagedList(page,4));
        }

        public IActionResult SearchProduct(string ProdSearch)
        {
            return View(new ProductsViewModel
            {
                Products = repository.Products.Where(x => x.productName.Contains(ProdSearch) || x.productBarkod.Contains(ProdSearch))
            });
        }

        public IActionResult CodeScanner()
        {
            return View();
        }

        public async Task<IActionResult> QRCodeScanner([Bind("QRCodeImageFile")] BarcodeScannerViewModel Barkod)
        {
            var file = Barkod.QRCodeImageFile;
            string webRootPath = _hostEnvironment.WebRootPath + "\\img\\productKarekodImg\\ScanQRCodeImg\\";
            string fileName = Path.GetFileNameWithoutExtension(file.FileName);
            string path = Path.Combine(webRootPath + fileName+".png");
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(filestream);
            }
            var reader = new BarcodeReaderGeneric();
            Bitmap image = (Bitmap)Image.FromFile(path);
            Result result;
            using (image)
            {
                LuminanceSource source;
                source = new ZXing.Windows.Compatibility.BitmapLuminanceSource(image);
                result = reader.Decode(source);
                ViewBag.QRCodeText = result.Text;
            }
            return View(new ProductsViewModel
            {
                Products = repository.Products.Where(x=> x.productBarkod == result.Text)
            });
        }


        public async Task<IActionResult> BarcodeScanner([Bind("BarkodImageFile")] BarcodeScannerViewModel Barkod)
        {
            var file = Barkod.BarkodImageFile;
            string webRootPath = _hostEnvironment.WebRootPath + "\\img\\productBarkodImg\\ScanBarcodeImg\\";
            string fileName = Path.GetFileNameWithoutExtension(file.FileName);
            string path = Path.Combine(webRootPath + fileName +".png");
            using (var filestream = new FileStream(path,FileMode.Create))
            {
                await file.CopyToAsync(filestream);
            }
                var reader = new BarcodeReaderGeneric();
            Bitmap image = (Bitmap)Image.FromFile(path);
            Result result;
            using (image)
            {
                LuminanceSource source;
                source = new ZXing.Windows.Compatibility.BitmapLuminanceSource(image);
                result = reader.Decode(source);
                ViewBag.BarcodeText = result.Text;
            }
            return View(new ProductsViewModel
            {
                Products = repository.Products.Where(x => x.productBarkod == result.Text)
            });
        }
    }
}
