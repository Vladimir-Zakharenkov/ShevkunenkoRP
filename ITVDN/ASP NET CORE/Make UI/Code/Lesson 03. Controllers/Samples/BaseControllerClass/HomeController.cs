using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace BaseControllerClass
{
    public class HomeController : Controller
    {
        // Создание ответа с помощью метода View базового класса Controller
        public ViewResult Index() => View("Result", "Hello world. Index method.");

        // Создание ответа с помощью создания экземпляра класса ViewResult
        public ViewResult Test() => new ViewResult()
        {
            ViewName = "Result",
            ViewData = new ViewDataDictionary(
            new EmptyModelMetadataProvider(),
            new ModelStateDictionary())
            {
                Model = "Hello world. Test method."
            }
        };
    }
}
