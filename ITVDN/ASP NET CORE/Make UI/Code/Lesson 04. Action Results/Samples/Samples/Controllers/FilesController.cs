using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace ActionResultsSamples.Controllers
{
    public class FilesController : Controller
    {
        private readonly IWebHostEnvironment environment;

        public FilesController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        // FileContentResult
        public IActionResult Sample1()
        {
            byte[] fileContent = System.IO.File.ReadAllBytes("App_Data/document.pdf");
            // Если указать имя третим параметром - браузер будет сохранять файл даже если поддерживает формат и может его открыть.
            // Если имя не указано - браузер скачивает и сохраняет файл в том случае если не поддерживает формат и не может его прочесть.
            return File(fileContent, "application/pdf", "Saved PDF File.pdf");
        }

        // FileStreamResult
        public IActionResult Sample2()
        {
            FileStream fileStream = System.IO.File.OpenRead("App_Data/document.pdf");
            return File(fileStream, "application/pdf");
        }

        // PhysicalFileResult
        public IActionResult Sample3()
        {
            // environment.ContentRootPath - абсольютный путь к директории в котором хранится контент приложения.
            return PhysicalFile(environment.ContentRootPath + @"\App_Data\document.pdf", "application/pdf");
        }
    }
}