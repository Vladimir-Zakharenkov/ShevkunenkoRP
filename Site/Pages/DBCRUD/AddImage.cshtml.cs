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
        private readonly IImageModelRepository _imageContext;
        public AddImageModel(IImageModelRepository imageContext)
        {
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; }

        public ImageModel Image { get; set; }


        public void OnGet()
        {
            PageNumber = 9;
        }

        public IActionResult OnPost()
        {
            PageNumber = 9;

            if (ModelState.IsValid)
            {
                _imageContext.AddImage(Image);

                return RedirectToPage("ViewImages");
            }

            return Page();
        }
    }
}