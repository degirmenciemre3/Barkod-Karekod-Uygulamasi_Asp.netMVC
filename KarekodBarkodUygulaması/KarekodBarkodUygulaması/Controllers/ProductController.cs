using KarekodBarkodUygulaması.Models;
using KarekodBarkodUygulaması.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarekodBarkodUygulaması.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        public ProductController(IProductsRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index(int productID)
        {
            return View(new ProductsViewModel
            {
                Products = repository.Products.Where(s => s.productID == productID)
            });
        }
    }
}
