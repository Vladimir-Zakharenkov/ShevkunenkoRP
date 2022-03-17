using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class Image_Add_UpdateModel : PageModel
    {
        private readonly IImageModelRepository _imageContext;
        public Image_Add_UpdateModel(IImageModelRepository imageContext) => _imageContext = imageContext;

        public uint PageNumber { get; set; }

        public ImageModel Image { get; set; }

        public IActionResult OnGet(Guid? imageId)
        {
            PageNumber = 82;

            if (imageId.HasValue)
            {
                Image = _imageContext.Images.FirstOrDefault(p => p.ImageId == imageId);

                if (Image == null)
                {
                    return RedirectToPage("/DBCRUD/Image-Icons");
                }

                ViewData["Action"] = "Edit";

                return Page();
            }
            else
            {
                ViewData["Action"] = "Add";

                Image = new();

                return Page();
            }
        }

        public IActionResult OnPost()
        {
            PageNumber = 82;

            if (Image.ImageId == Guid.Empty & _imageContext.Images.FirstOrDefault(x => x.ImageContentUrl.Segments.Last() == Image.ImageContentUrl.Segments.Last()) != null)
            {
                ModelState.AddModelError("Image.ImageContentUrl", "Такой файл уже существует");

                return Page();
            }

            if (Image.ImageId == Guid.Empty & _imageContext.Images.FirstOrDefault(x => x.ImageThumbnailUrl.Segments.Last() == Image.ImageThumbnailUrl.Segments.Last()) != null)
            {
                ModelState.AddModelError("Image.ImageThumbnailUrl", "Такой файл уже существует");

                return Page();
            }

            if (ModelState.IsValid)
            {
                if (Image.ImageId == Guid.Empty)
                {
                    _imageContext.AddImage(Image);
                }
                else
                {
                    _imageContext.UpdateImage(Image);
                }

                return RedirectToPage("/DBCRUD/Image-Icons");
            }
            else
            {
                return Page();
            }
        }
    }
}