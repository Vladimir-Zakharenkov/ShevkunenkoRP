using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class AddImageModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IImageModelRepository _imageContext;

        public AddImageModel(ISitemapModelRepository sitemapContext, IImageModelRepository imageContext)
        {
            _sitemapContext = sitemapContext;
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; }

        public ImageModel Image { get; set; }


        public IActionResult OnGet()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            return Page();
        }

        public IActionResult OnPost()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            if (ModelState.IsValid)
            {
                _imageContext.AddImage(Image);

                return RedirectToPage("ViewImages");
            }

            return Page();
        }
    }
}