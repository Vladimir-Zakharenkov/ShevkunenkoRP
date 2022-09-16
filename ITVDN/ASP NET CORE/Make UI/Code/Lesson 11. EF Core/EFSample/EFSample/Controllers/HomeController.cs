using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFSample.Model;
using Microsoft.AspNetCore.Mvc;

namespace EFSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Products.ToList());
        }
    }
}