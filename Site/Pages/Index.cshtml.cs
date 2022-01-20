using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Services;

namespace Site.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPageModelRepository _pageContext;

        public IndexModel(IPageModelRepository pageContext)
        {
            _pageContext = pageContext;
        }

        public uint PageNumber { get; set; }

        public string PageImage { get; set; }

        public IActionResult OnGet(uint? id)
        {
            if (id != 1)
            {
                return RedirectToPage("Index", new { id = 1 });
            }

            PageNumber = _pageContext.GetPage(id).PageNumber;
            PageImage = _pageContext.GetPage(id).ImageModel.ImageName;

            return Page();
        }
    }
}