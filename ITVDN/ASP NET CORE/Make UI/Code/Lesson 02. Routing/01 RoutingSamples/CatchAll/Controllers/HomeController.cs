using Microsoft.AspNetCore.Mvc;

namespace CatchAll.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Values(string data)
        {
            string[] splited = data.Split("/");
            int result = 0;

            foreach (string item in splited)
            {                
                if (int.TryParse(item, out int converted))
                {
                    result += converted;
                }
            }

            return View(result);
        }
    }
}