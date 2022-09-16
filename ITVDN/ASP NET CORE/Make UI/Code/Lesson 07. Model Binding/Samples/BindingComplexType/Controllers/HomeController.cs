using BindingComplexType.Model;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BindingComplexType.Controllers
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

        // При получении запроса к методу со сложным типом RegistrationBindingModel, model binder создает экземпляр класса
        // используя конструктор по умолчанию, после чего проходит по всем открытым свойствам экземпляра и производит поиск
        // значений для свойств из источников текущего запроса.
        [HttpPost]
        public IActionResult Registration(RegistrationBindingModel model)
        {
            // Обработка полученных данных

            Debug.WriteLine("First Name = " + model.FirstName);
            Debug.WriteLine("Last Name = " + model.LastName);
            Debug.WriteLine("Email = " + model.Email);
            Debug.WriteLine("Phone Number = " + model.PhoneNumber);

            return View();
        }
    }
}
