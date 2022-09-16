using ActionFilterSample.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace ActionFilterSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ExceptionLoging]
        public IActionResult Action1()
        {
            throw new System.Exception("My Test Exception");
            return View();
        }

        [ExceptionLoging]
        public IActionResult Action2()
        {
            throw null;
            return View();
        }
    }
}