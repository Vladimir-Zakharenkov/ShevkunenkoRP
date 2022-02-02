using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    public class AddImageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IImageModelRepository _imageContext;

        public AddImageModel(ISitemapModelRepository sitemapContext, IImageModelRepository imageContext)
        {
            _sitemapContext = sitemapContext;
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; }

        [BindProperty]
        public ImageModel Image { get; set; }


        public IActionResult OnGet(uint? pageNumber = 9)
        {
            PageNumber = _sitemapContext.GetPage(pageNumber).PageNumber;

            return Page();
        }

        public IActionResult OnPost(uint? pageNumber = 9)
        {
            PageNumber = _sitemapContext.GetPage(pageNumber).PageNumber;

            if (ModelState.IsValid)
            {
                _imageContext.AddImage(Image);

                return RedirectToPage("ViewImages");
            }
            else
            {
                return Page();
            }
        }
    }
}