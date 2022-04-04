using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Znakomye_o_Shevkunenko
{
    [BindProperties(SupportsGet = true)]
    public class Marina_KuzmenkoModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 142;
        }
    }
}