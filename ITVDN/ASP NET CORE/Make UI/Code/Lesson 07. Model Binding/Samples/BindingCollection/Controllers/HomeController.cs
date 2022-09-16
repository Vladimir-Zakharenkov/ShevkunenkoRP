using BindingCollection.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace BindingCollection.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // Метод действия, который вернет представление с формой для заполнения
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegistrationBindingModel model, List<string> addresses)
        {
            // Обработка полученных данных

            Debug.WriteLine("First Name = " + model.FirstName);
            Debug.WriteLine("Last Name = " + model.LastName);
            Debug.WriteLine("Email = " + model.Email);
            Debug.WriteLine("Phone Number = " + model.PhoneNumber);

            foreach (var item in addresses)
            {
                Debug.WriteLine("Address = " + item);
            }

            return View();
        }
    }
}