using HybridComponents.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HybridComponents.Controllers
{
    // Данный класс, является гибридным компонентом/контроллером
    // Класс является обычным контроллером,
    // но благодаря атрибуту ViewComponent его можно использовать как компонент в представлениях данного приложения.
    // В данном классе есть как методы действия так и метод Invoke, который нужен для определения логики работы компонента

    [ViewComponent(Name = "ProductCount")]
    public class ProductController : Controller
    {
        private readonly ProductRepository repository;

        public ProductController(ProductRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, double price)
        {
            // В данном коде пропущена валидация данных
            repository.AddProduct(name, price);

            return RedirectToAction("Index", "Home");
        }

        // Метод определяющий логику работы компонента
        public string Invoke()
        {
            return "Products count: " + repository.Products.Count();
        }
    }
}