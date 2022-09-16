using Microsoft.AspNetCore.Mvc;

namespace _01_URLOnActionName.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Свойство Url полученное по наследству от базового класса Controller содержит IUrlHelper,
            // который содержит методы для построение URL в MVC приложениях.
            string url1 = Url.Action("Item");                           // создание URL по имени метода действия
            string url2 = Url.Action("Item", new { id = 1 });           // создание URL по имени метода действия с указанием параметра id
            string url3 = Url.Action("Index", "Test");                  // создание URL по имени метода действия и контроллера
            string url4 = Url.Action("List", "Test", new { id = 1 });   // URL по имени метода, контроллера и указания параметров

            string[] model = { url1, url2, url3, url4 };

            return View(model);
        }

        public IActionResult Item()
        {
            return View();
        }
    }
}