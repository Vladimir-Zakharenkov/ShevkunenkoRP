using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class Test2Model : PageModel
    {
        public int Square { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Number { get; set; }

        public void OnGet()
        {
            Square = Number * Number;
        }
    }
}
