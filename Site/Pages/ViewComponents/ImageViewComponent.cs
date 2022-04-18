using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Site.Pages.ViewComponents
{
    public class Image : ViewComponent
    {
        private readonly SiteContext _siteContext;
        private readonly IImageModelRepository _imageContext;

        public Image(SiteContext siteContext, IImageModelRepository imageContext)
        {
            _siteContext = siteContext;
            _imageContext = imageContext;
        }

        public IViewComponentResult Invoke(string fileName, string cssClass, bool imageIcon)
        {
            //ImageModel image = await _siteContext.ImageModels.FirstOrDefaultAsync(x => x.ImageContentUrl.Segments.Last() == fileName);
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