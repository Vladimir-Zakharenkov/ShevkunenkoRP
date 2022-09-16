using ActionFilterSample.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace ActionFilterSample.Controllers
{
    public class HomeController : Controller
    {
        [Profile]
        public IActionResult Index()
        {
            return View();
        }

        [Profile]
        public IActionResult Action1()
        {
            Thread.Sleep(2000);
            return View();
        }

        [Profile]
        public IActionResult Action2()
        {
            return View();
        }
    }
}