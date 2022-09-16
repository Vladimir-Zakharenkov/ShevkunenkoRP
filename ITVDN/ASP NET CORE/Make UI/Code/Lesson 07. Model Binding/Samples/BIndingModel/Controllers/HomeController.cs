using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BIndingModel.Controllers
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

        // Метод действия, который запустится, когда пользователь сделает submit формы (отправит POST запрос на сервер).
        // При вызове данного метода, произойдет привязка модели, входящие данные в теле запроса, которые совпадают с названиями аргументов,
        // будут записаны в эти аргументы.
        [HttpPost]
        public IActionResult Registration(string firstName, string lastName, string email, string phoneNumber)
        {
            // Обработка полученных данных

            Debug.WriteLine("First Name = " + firstName);
            Debug.WriteLine("Last Name = " + lastName);
            Debug.WriteLine("Email = " + email);
            Debug.WriteLine("Phone Number = " + phoneNumber);

            return View();
        }
    }
}