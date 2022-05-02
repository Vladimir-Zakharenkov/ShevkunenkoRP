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
        private readonly SiteContext _siteContext;
        public ImageById(SiteContext siteContext) => _siteContext = siteContext;

        public IViewComponentResult Invoke(Guid imageId, string cssClass, bool imageIcon)
        {
            ImageModel image = _siteContext.ImageModels.Find(imageId);

            if (image == null)
            {
                image = _siteContext.ImageModels.FirstOrDefault(x => x.ImageContentUrl.Segments.Last() == "no-image.png");
            }

            ViewData["CssClass"] = cssClass;
            ViewData["ImageIcon"] = imageIcon;

            return View(image);
        }
    }
}