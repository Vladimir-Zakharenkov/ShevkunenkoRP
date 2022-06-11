using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Pages.ViewComponents
{
    public class Image : ViewComponent
    {
        private readonly SiteContext _siteContext;
        public Image(SiteContext siteContext) => _siteContext = siteContext;

        public async Task<IViewComponentResult> InvokeAsync(string fileName, string cssClass, bool imageIcon)
        {
            ImageModel image = await _siteContext.ImageModels.FirstOrDefaultAsync(x => x.ImageContentUrl.Segments.Last() == fileName);

            if (image == null)
            {
                image = await _siteContext.ImageModels.FirstOrDefaultAsync(x => x.ImageContentUrl.Segments.Last() == "no-image.png");
            }

            ViewData["CssClass"] = cssClass;
            ViewData["ImageIcon"] = imageIcon;

            return View(image);
        }
    }
}