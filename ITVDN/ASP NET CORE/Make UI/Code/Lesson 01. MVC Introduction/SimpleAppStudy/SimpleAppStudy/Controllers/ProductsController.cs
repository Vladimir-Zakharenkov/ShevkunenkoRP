using Microsoft.AspNetCore.Mvc;
using SimpleAppStudy.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleAppStudy.Controllers
{
    public class ProductsController : Controller
    {
        private ProductReader reader;

        public ProductsController()
        {
            reader = new();
        }

        public IActionResult List()
        {
            List<Product> products = reader.ReadFromFile();

            return View(products);
        }

        public IActionResult Details(int id)
        {
            List<Product> products = reader.ReadFromFile();
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
