using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    public class AddImageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
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


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _imageContext.AddImage(Image);

                return RedirectToPage("ViewImages");
            }
            else
            {
                return base.Page();
            }
        }
    }
}
