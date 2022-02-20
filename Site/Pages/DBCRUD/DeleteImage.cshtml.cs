using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [Authorize]
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
            PageNumber = 10;

            Image = _imageContext.GetImage(Image.ImageId);

            if (Image == null)
            {
                return RedirectToPage("ViewImages");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            PageNumber = 10;

            _imageContext.DeleteImage(Image.ImageId);

            return RedirectToPage("ViewImages");
        }
    }
}