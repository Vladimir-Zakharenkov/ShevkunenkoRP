using Microsoft.AspNetCore.Mvc;

namespace _02_URLOnRouteName.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Создание URL на основе зарегистрированного маршрута по имени маршрута
            string url = Url.RouteUrl("ViewProduct", new {
                controller = "product",
                action = "details",
                id = 100
            });

            return View(url as object);
        }
    }
}