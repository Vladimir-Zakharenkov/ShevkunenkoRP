using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class Image : ViewComponent
    {
        private readonly IImageModelRepository _imageContext;

        public Image(IImageModelRepository imageContext) => _imageContext = imageContext;

        public IViewComponentResult Invoke(string imageName, string cssClass)
        {
            ImageModel image = _imageContext.Images.FirstOrDefault(x => x.ImageName == imageName);

            if (image == null)
            {
                image = _imageContext.Images.FirstOrDefault(x => x.ImageName == "no-image");
            }

            ViewData["CssClass"] = cssClass;

            return View(image);
        }
    }
}