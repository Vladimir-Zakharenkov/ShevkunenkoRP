using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    public class AddImageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly IImageModelRepository _imageContext;
        private readonly IPageModelRepository _pageContext;

        public AddImageModel(IPageModelRepository pageContext, IImageModelRepository imageContext)
        {
            _pageContext = pageContext;
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; }
        public string LeftBackground { get; set; }
        public string RightBackground { get; set; }

        [BindProperty]
        public ImageModel Image { get; set; }


        public IActionResult OnGet(uint? pageNumber)
        {
            if (pageNumber != 1)
            {
                return RedirectToPage("/DBCRUD/AddImage", new { pageNumber = 1 });
            }

            PageNumber = _pageContext.GetPage(pageNumber).PageNumber;

            LeftBackground = _pageContext.GetPage(pageNumber).LeftBackground;

            RightBackground = _pageContext.GetPage(pageNumber).RightBackground;

            return Page();
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
                return Page();
            }
        }
    }
}