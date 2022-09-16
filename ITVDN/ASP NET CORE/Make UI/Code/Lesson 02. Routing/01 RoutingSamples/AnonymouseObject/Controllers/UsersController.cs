using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AnonymouseObject.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index(string name)
        {
            return View(name as object);
        }
    }
}