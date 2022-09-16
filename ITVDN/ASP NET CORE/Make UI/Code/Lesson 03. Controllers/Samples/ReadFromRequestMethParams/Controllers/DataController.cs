using Microsoft.AspNetCore.Mvc;

namespace ReadFromRequestMethParams.Controllers
{
    public class DataController : Controller
    {

        // Перед запуском метода действия, MVC выполнит поиск значений в контексте на основе имен параметров метода действия,
        // включая Request.Form, RouteData.Values, Request.QueryString

        //
        // GET: /Data/

        public ActionResult Index()
        {
            return View();
        }

        //
        // POST: /Data/Create/

        public ActionResult Create(string message)
        {
            // Чтение данных, которые передаются с помощью POST запроса в теле запроса.
            ViewBag.Text = message; // Request.Form["message"];
            return View("Index");
        }

        //
        // GET: /Data/Catalog/<value>

        public ActionResult Catalog(string id)
        {
            // Чтение данных, которые передаются с помощью GET запроса, как данные в маршруте.
            ViewBag.Text = id; //RouteData.Values["id"];
            return View("Index");
        }

        //
        // GET: /Data/Users?id=<value>

        public ActionResult Users(string id)
        {
            // Чтение данных, которые передаются в адресной строке.
            ViewBag.Text = id; // Request.Query["id"];
            return View("Index");
        }
    }
}