using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Site.Pages.ViewComponents
{
    public class ImageById : ViewComponent
    {
        private readonly IImageModelRepository _imageContext;
        public ImageById(IImageModelRepository imageContext) => _imageContext = imageContext;

        public async Task<IViewComponentResult> InvokeAsync(Guid imageId, string cssClass, bool imageIcon)
        {
            ImageModel image = await _imageContext.Images.FirstOrDefaultAsync(y => y.ImageId == imageId);

            if (image == null)
            {
                image = await _imageContext.Images.FirstOrDefaultAsync(x => x.ImageContentUrl.Segments.Last() == "no-image.png");
            }

            ViewData["CssClass"] = cssClass;
            ViewData["ImageIcon"] = imageIcon;

            return View(image);
        }
    }
}