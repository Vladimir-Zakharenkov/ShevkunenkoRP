using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FromControllerToView.Controllers
{
    public class Sample2Controller : Controller
    {
        public IActionResult Index()
        {
            // ViewBag - обертка над ViewData, которая используется динамические возможности языка C# 4.0
            ViewBag.Text = "String from Database";
            ViewBag.Date = DateTime.Now;
            return View();
        }
    }
}