using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Services;

namespace Site.Pages
{
    public class DonateModel : PageModel
    {
        private readonly IPageModelRepository _pageContext;

        public DonateModel(IPageModelRepository pageContext)
        {
            _pageContext = pageContext;
        }

        public uint PageNumber { get; set; }

        public string LeftBackground { get; set; }
        public string RightBackground { get; set; }


        public IActionResult OnGet(uint? pageNumber)
        {
            if (pageNumber != 3)
            {
                return RedirectToPage("Index", new { pageNumber = 3 });
            }

            PageNumber = _pageContext.GetPage(pageNumber).PageNumber;

            LeftBackground = _pageContext.GetPage(pageNumber).LeftBackground;

            RightBackground = _pageContext.GetPage(pageNumber).RightBackground;

            return Page();
        }
    }
}