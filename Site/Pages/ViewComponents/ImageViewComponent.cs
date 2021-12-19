using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class Image : ViewComponent
    {
        private readonly IImageModelRepository _context;

        public Image(IImageModelRepository context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(string imageName)
        {
            ImageModel image = _context.GetAllImages().FirstOrDefault(x => x.ImageName == imageName);

            return View(image);
        }
    }
}
