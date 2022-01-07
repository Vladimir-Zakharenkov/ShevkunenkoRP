using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public uint PageNumber { get; set; } = 1;

        [BindProperty]
        public string PageImage { get; set; } = "main-index";

        public void OnGet()
        {
        }
    }
}