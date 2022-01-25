using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Services;

namespace Site.Pages
{
    public class Main2Model : PageModel
    {
        private readonly IPageModelRepository _pageContext;

        public Main2Model(IPageModelRepository pageContext)
        {
            _pageContext = pageContext;
        }

        public uint PageNumber { get; set; }

        public string LeftBackground { get; set; }
        public string RightBackground { get; set; }


        public IActionResult OnGet(uint? pageNumber)
        {
            if (pageNumber != 2)
            {
                return RedirectToPage("Index", new { pageNumber = 2 });
            }

            PageNumber = _pageContext.GetPage(pageNumber).PageNumber;

            LeftBackground = _pageContext.GetPage(pageNumber).LeftBackground;

            RightBackground = _pageContext.GetPage(pageNumber).RightBackground;

            return Page();
        }
    }
}