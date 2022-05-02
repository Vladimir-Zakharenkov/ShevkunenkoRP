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

        public IViewComponentResult Invoke(string fileName, string cssClass, bool imageIcon)
        {
            ImageModel image = _imageContext.Images.FirstOrDefault(x => x.ImageContentUrl.Segments.Last() == fileName);

            if (image == null)
            {
                image = _imageContext.Images.FirstOrDefault(x => x.ImageContentUrl.Segments.Last() == "no-image.png");
            }

            ViewData["CssClass"] = cssClass;
            ViewData["ImageIcon"] = imageIcon;

            return View(image);
        }
    }
}