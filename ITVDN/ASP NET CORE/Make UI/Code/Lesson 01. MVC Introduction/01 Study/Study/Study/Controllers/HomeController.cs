using Microsoft.AspNetCore.Mvc;
using Study.Models;

namespace Study.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product();

            product.Name = "Test";
            product.Id = 1;

            return View(product);
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
