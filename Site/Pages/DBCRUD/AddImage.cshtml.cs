using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;

namespace Site.Pages.DBCRUD
{
    public class AddImageModel : PageModel
    {
        private readonly IImageModelRepository _imageContext;

        public AddImageModel(IImageModelRepository imageContext)
        {
            _imageContext = imageContext;
        }

        [BindProperty]
        public uint PageNumber { get; set; } = 1;

        [BindProperty]
        public string PageImage { get; set; } = "main-index";

        [BindProperty]
        public ImageModel Image { get; set; }

        [BindProperty(SupportsGet = true)]
        public IEnumerable<ImageModel> Images { get; set; }

        public void OnGet()
        {
            Images = _imageContext.Images;
        }

        public IActionResult OnPost()
        {
            _imageContext.AddImage(Image);
            return RedirectToPage("/DBCRUD/AddImage");
        }
    }
}
