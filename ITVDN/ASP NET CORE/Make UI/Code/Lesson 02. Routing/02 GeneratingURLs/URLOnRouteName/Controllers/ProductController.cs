﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _02_URLOnRouteName.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details(int id)
        {
            return View(id);
        }
    }
}