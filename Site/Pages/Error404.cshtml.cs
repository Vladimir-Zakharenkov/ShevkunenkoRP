using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class Error404Model : PageModel
    {
        [BindProperty]
        public uint PageNumber { get; set; } = 4;

        public void OnGet()
        {
        }
    }
}
