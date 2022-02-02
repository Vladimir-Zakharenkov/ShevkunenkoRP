using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class NopageModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("Error404");
        }
    }
}