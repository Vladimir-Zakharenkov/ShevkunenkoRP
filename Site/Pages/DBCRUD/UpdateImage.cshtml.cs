using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class UpdateImageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly IImageModelRepository _imageContext;
        public UpdateImageModel(IImageModelRepository imageContext)

        {
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; }

        public ImageModel ImageToUpdate { get; set; }

        public IActionResult OnGet(Guid? imageId)
        {
            PageNumber = 8;

            if (imageId == null || _imageContext.Images.FirstOrDefault(x => x.ImageId == imageId) == null)
            {
                return RedirectToPage("ViewImages");
            }

            ImageToUpdate = _imageContext.GetImage(imageId);

            return Page();
        }

        public IActionResult OnPost()
        {
            PageNumber = 8;

            if (ModelState.IsValid)
            {
                _imageContext.UpdateImage(ImageToUpdate);

                return RedirectToPage("ViewImages");
            }

            return Page();
        }
    }
}