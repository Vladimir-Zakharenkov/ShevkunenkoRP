﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReadFromRequest.Controllers
{
    public class DataController : Controller
    {
        //
        // GET: /Data/

        public ActionResult Index()
        {
            return View();
        }

        //
        // POST: /Data/Create/

        public ActionResult Create()
        {
            // Чтение данных, которые передаются с помощью POST запроса в теле запроса.
            ViewBag.Text = Request.Form["message"];
            return View("Index");
        }

        //
        // GET: /Data/Catalog/<value>

        public ActionResult Catalog()
        {
            // Чтение данных, которые передаются с помощью GET запроса, как данные в маршруте.
            ViewBag.Text = RouteData.Values["id"];
            return View("Index");
        }

        //
        // GET: /Data/Users?id=<value>

        public ActionResult Users()
        {
            // Чтение данных, которые передаются в адресной строке.
            ViewBag.Text = Request.Query["id"];
            return View("Index");
        }
    }
}