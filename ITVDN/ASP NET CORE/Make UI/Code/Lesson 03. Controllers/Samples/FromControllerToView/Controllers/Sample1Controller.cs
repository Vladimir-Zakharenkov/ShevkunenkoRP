using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FromControllerToView.Controllers
{
    public class Sample1Controller : Controller
    {
        public IActionResult Index()
        {
            // ViewData - коллекция для передачи данныих из контроллера в представление
            ViewData["text"] = "String from Database";
            ViewData["date"] = DateTime.Now;
            
            return View();
        }
    }
}