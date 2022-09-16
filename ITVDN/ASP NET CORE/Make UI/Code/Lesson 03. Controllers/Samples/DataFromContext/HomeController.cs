using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DataFromContext
{
    public class HomeController : Controller
    {
        public string Index()
        {
            // Свойства контроллера для доступа к информации о запросе.
            // Request - данные о текущем HTTP запросе.
            // Response - данные о текущем HTTP ответе.
            // RouteData - данные маршрутизации для текущего запроса.
            // HttpContext - получение специфической информации о текущем HTTP запросе.

            string userName = User.Identity.Name;
            var headers = Request.Headers.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First());
            
            return "Data From Context Sample";
        }
    }
}
