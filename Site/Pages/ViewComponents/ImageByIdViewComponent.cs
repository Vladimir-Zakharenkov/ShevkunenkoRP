using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class ImageById : ViewComponent
    {
        private readonly IImageModelRepository _imageContext;
        public ImageById(IImageModelRepository imageContext) => _imageContext = imageContext;

        public IViewComponentResult Invoke(Guid imageId, string cssClass)
        {
            ImageModel image = _imageContext.Images.FirstOrDefault(x => x.ImageId == imageId);

            if (image == null)
            {
                image = _imageContext.Images.FirstOrDefault(x => x.ImageName == "no-image");
            }

            ViewData["CssClass"] = cssClass;

            return View(image);
        }
    }
}
