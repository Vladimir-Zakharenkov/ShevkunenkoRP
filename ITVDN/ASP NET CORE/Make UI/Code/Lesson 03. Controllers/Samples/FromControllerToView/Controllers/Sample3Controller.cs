using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromControllerToView.Models;
using Microsoft.AspNetCore.Mvc;

namespace FromControllerToView.Controllers
{
    public class Sample3Controller : Controller
    {
        public IActionResult Index()
        {
            Data model = new Data()
            {
                Text = "String from Database",
                Date = DateTime.Now
            };

            // Передача информации в представление через модель.
            return View(model);
        }
    }
}