using Microsoft.AspNetCore.Mvc;

namespace Lesson02.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Add(int x, int y)
        {
            return View(x + y);
        }

        public IActionResult Mul(int x, int y)
        {
            return View("Add", (x * y));
        }

        public IActionResult Div(int x, int y)
        {
            return View("Add", (x / y));
        }

        public IActionResult Sub(int x, int y)
        {
            return View("Add", (x - y));
        }
    }
}
