using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class DonateModel : PageModel
    {
        [BindProperty]
        public uint PageNumber { get; set; } = 3;

        public void OnGet()
        {
        }
    }
}
