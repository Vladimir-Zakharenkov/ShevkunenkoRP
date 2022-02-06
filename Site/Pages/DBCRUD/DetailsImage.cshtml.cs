using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [BindProperties(SupportsGet = true)]
    public class DetailsImageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly IImageModelRepository _imageContext;
        private readonly ISitemapModelRepository _sitemapContext;

        public DetailsImageModel(IImageModelRepository imageContext, ISitemapModelRepository sitemapContext)
        {
            _imageContext = imageContext;
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }

        public ImageModel Image { get; set; }

        public IActionResult OnGet()
        {
            Image = _imageContext.GetImage(Image.ImageId);

            if (Image == null)
            {
                return RedirectToPage("ViewImages");
            }

            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            return Page();
        }
    }
}