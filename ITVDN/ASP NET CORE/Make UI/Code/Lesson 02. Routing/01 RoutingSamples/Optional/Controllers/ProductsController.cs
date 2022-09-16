using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _05_Optional.Controllers
{
    public class ProductsController : Controller
    {
        private Dictionary<int, string> products = new Dictionary<int, string>();

        public ProductsController()
        {
            // Конструктор будет срабатывать при каждом обращении к контролеру.
            products.Add(1, "Mobile Phone");
            products.Add(2, "Laptop");
            products.Add(3, "Keyboard");
            products.Add(4, "Mouse");
            products.Add(5, "Pen");
            products.Add(6, "Notebook");
        }

        // Так как id является опциональным параметром используем nulable тип.
        // Если в запросе не будет предоставлено значение для параметра id метод получит значение null
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                // Так как модель является значением строкового типа мы явно приводим ее к типу object
                // Метод View имеет перегрузку принимающую тип данных string, которая позволяет вернуть представление с определенным
                // именем. Для того, чтобы передать представлению модель, нужно использовать перегрузку с параметром object
                return View(products[1] as object);
            }
            else if (!products.ContainsKey((int)id))
            {
                return NotFound();
            }
            else
            {
                return View(products[(int)id] as object);
            }
        }
    }
}