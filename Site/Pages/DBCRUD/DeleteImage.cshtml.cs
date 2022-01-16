using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System;

namespace Site.Pages.DBCRUD
{
    public class DeleteImageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly IImageModelRepository _imageContext;

        public DeleteImageModel(IImageModelRepository imageContext)
        {
            _imageContext = imageContext;
        }

        [BindProperty]
        public uint PageNumber { get; set; } = 1;

        [BindProperty]
        public string PageImage { get; set; } = "main-index";

        [BindProperty]
        public ImageModel Image { get; set; }

        public void OnGet(Guid imageID)
        {
            Image = _imageContext.GetImage(imageID);
        }

        public IActionResult OnPost()
        {
            _imageContext.DeleteImage(Image.ImageId);

            return RedirectToPage("ViewImages");
        }
    }
}