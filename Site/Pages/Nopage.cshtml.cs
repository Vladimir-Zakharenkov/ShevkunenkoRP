using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    [BindProperties(SupportsGet = true)]
    public class NopageModel : PageModel
    {
        public uint PageNumber { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = 0;

            return RedirectToPage("/Error404");
        }
    }
}