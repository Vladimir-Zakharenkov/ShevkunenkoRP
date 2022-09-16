﻿using ActionFilterSample.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace ActionFilterSample.Controllers
{
    public class HomeController : Controller
    {
        [ResultProfile]
        public IActionResult Index()
        {
            return View();
        }

        [ResultProfile]
        public IActionResult Action1()
        {
            Thread.Sleep(2000);
            return View();
        }

        [ResultProfile]
        public IActionResult Action2()
        {
            return View();
        }
    }
}