using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductReader _reader;

        public ProductsController()
        {
            _reader = new ProductReader();
        }

        // Products/List
        public IActionResult List(string data)
        {
            List<Product> products = _reader.ReadFromFile();

            if (data != null)
            {
                List<Product> CathegoryProducts = new List<Product>();
                foreach (var product in products) 
                {
                    if (product.Cathegory == data)
                    {
                        CathegoryProducts.Add(product);
                    }
                }

                products = CathegoryProducts;
            }

            return View(products);
        }

        // Products/Details/1
        public IActionResult Details(int id)
        {
            List<Product> products = _reader.ReadFromFile();
            Product product = products.Where(x => x.Id == id).FirstOrDefault();

            if (product != null)
            {
                return View(product);
            }
            else
            {
                return NotFound();
            }
        }
    }
}