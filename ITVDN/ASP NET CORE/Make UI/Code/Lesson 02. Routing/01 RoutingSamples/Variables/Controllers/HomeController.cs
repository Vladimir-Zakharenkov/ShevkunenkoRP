using Microsoft.AspNetCore.Mvc;

namespace Variables.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Параметр x и y будут инициализироваться автоматически.
        // Подробнее о работе данного механизма вы узнаете в уроке посвященном привязке модели. 
        public IActionResult Calc(int x, int y)
        {
            int result = x + y;
            return View(result);
        }
    }
}