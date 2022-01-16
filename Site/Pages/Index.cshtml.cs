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

        [BindProperty]
        public uint PageNumber { get; set; }

        [BindProperty]
        public string PageImage { get; set; } = "main-index";

        public void OnGet()
        {
            PageNumber = _pageContext.GetPage(1).PageNumber;
        }
    }
}