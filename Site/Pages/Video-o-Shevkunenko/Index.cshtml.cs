using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Video_o_Shevkunenko
{
    public class IndexModel : PageModel
    {
        public uint PageNumber { get; set; }

        public void OnGet()
        {
            PageNumber = 90;
        }
    }
}