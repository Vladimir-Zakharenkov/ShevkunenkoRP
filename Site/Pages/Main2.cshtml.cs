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

        public string PageImage { get; set; }

        public IActionResult OnGet(uint? id)
        {
            if (id != 2)
            {
                return RedirectToPage("Main2", new { id = 2 });
            }

            PageNumber = _pageContext.GetPage(id).PageNumber;
            PageImage = _pageContext.GetPage(id).ImageModel.ImageName;

            return Page();
        }
    }
}