using Microsoft.AspNetCore.Mvc;

namespace PocoComponentSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}