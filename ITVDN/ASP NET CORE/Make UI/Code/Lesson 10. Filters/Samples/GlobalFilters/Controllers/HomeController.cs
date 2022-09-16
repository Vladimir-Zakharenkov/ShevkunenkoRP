using Microsoft.AspNetCore.Mvc;

namespace ActionFilterSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Action1()
        {
            throw new System.Exception("My Test Exception");
            return View();
        }

        public IActionResult Action2()
        {
            throw null;
            return View();
        }
    }
}