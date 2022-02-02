using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System;

namespace Site.Pages.DBCRUD
{
    public class DeleteImageModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IImageModelRepository _imageContext;

        public DeleteImageModel(ISitemapModelRepository sitemapContext, IImageModelRepository imageContext)
        {
            _sitemapContext = sitemapContext;
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; } = 1;

        [BindProperty]
        public ImageModel Image { get; set; }

        public IActionResult OnGet(Guid imageID, uint? pageNumber = 10)
        {
            if (_imageContext.GetImage(imageID) == null)
            {
                return RedirectToPage("/DBCRUD/ViewImages");
            }

            PageNumber = _sitemapContext.GetPage(pageNumber).PageNumber;

            Image = _imageContext.GetImage(imageID);

            return Page();
        }

        public IActionResult OnPost()
        {
            _imageContext.DeleteImage(Image.ImageId);

            return RedirectToPage("/DBCRUD/ViewImages");
        }
    }
}