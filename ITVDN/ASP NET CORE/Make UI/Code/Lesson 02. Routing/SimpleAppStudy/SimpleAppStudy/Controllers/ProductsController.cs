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

        //public IActionResult List()
        //{
        //    List<Product> products = reader.ReadFromFile();

        //    return View(products);
        //}

        public IActionResult List(string id)
        {
            List<Product> products = reader.ReadFromFile();

            if (id == null)
            {
                return View(products);
            }
            else
            {
                List<Product> category = products.Where(y => y.Category == id).ToList();

                return View(category);
            }

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
