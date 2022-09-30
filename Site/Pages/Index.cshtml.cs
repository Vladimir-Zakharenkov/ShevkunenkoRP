using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class IndexModel : PageModel
    {
        public uint PageNumber { get; set; } = 1;

        public void OnGet()
        {
        }
    }
}