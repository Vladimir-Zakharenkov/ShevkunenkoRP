using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [BindProperties(SupportsGet = true)]
    public class DeleteImageModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IImageModelRepository _imageContext;

        public DeleteImageModel(IImageModelRepository imageContext, ISitemapModelRepository sitemapContext)
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

        public IActionResult OnPost()
        {
            _imageContext.DeleteImage(Image.ImageId);

            return RedirectToPage("ViewImages");
        }
    }
}