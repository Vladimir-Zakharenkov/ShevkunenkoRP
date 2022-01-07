using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class Error404Model : PageModel
    {
        [BindProperty]
        public uint PageNumber { get; set; } = 4;

        [BindProperty]
        public string PageImage { get; set; } = "main-index";

        public void OnGet()
        {
        }
    }
}
