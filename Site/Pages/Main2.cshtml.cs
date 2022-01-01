using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class Main2Model : PageModel
    {
        [BindProperty]
        public uint PageNumber { get; set; } = 2;

        public void OnGet()
        {
        }
    }
}
