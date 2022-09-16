using FromControllerToView.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FromControllerToView.Controllers
{
    public class Sample4Controller : Controller
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