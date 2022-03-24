using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class Navigation : PageModel
    {
        public uint PageNumber { get; set; }

        public void OnGet()
        {
            PageNumber = 2;
        }
    }
}