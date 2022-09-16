using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Literal.Controllers
{
    public class ValuesController : Controller
    {
        public IActionResult List()
        {
            string[] data = { "item 1", "item 2", "item 3" };
            return View(data);
        }
    }
}