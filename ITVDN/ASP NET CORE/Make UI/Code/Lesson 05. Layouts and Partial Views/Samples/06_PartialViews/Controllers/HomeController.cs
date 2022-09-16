using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_PartialViews.Model;
using Microsoft.AspNetCore.Mvc;

namespace Samples.Controllers
{
    public class HomeController : Controller
    {
        ContactsViewModel viewModel;

        public HomeController()
        {
            viewModel = new ContactsViewModel()
            {
                Email = "user@example.com",
                Phone = "+1 234 56 78",
                Aeddress = "Str. Abcd 20"
            };
        }

        public IActionResult Index()
        {
            return View(viewModel);
        }

        public IActionResult Catalog()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View(viewModel);
        }
    }
}