using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HtmlSelect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string[] source = { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
            SelectList selectList = new SelectList(source, source[2]);
            ViewBag.SelectItems = selectList;

            return View();
        }

        [HttpPost]
        public IActionResult Index(string selectedItem)
        {
            Debug.WriteLine("Selected - " + selectedItem);

            return View("Result", selectedItem);
        }
    }
}