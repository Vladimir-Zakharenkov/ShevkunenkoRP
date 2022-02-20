using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    [BindProperties(SupportsGet = true)]
    public class Error404Model : PageModel
    {
        public uint PageNumber { get; set; }

        public void OnGet()
        {
            PageNumber = 4;
        }
    }
}