using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System;

namespace Site.Pages.DBCRUD
{
    public class UpdateImageModel : PageModel
    {
        private readonly IImageModelRepository _imageContext;

        public UpdateImageModel(IImageModelRepository imageRepository)
        {
            _imageContext = imageRepository;
        }

        [BindProperty]
        public uint PageNumber { get; set; } = 1;

        [BindProperty]
        public string PageImage { get; set; } = "main-index";

        [BindProperty]
        public ImageModel Image { get; set; }


        public void OnGet(Guid imageId)
        {
            Image = _imageContext.GetImage(imageId);
        }

        public IActionResult OnPost(ImageModel image)
        {
            if (ModelState.IsValid)
            {
                _imageContext.UpdateImage(image);

                return RedirectToPage("ViewImages");
            }
            else
            {
                return Page();
            }
        }
    }
}