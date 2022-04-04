using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Znakomye_o_Shevkunenko
{
    [BindProperties(SupportsGet = true)]
    public class Vladimir_Prigojin3Model : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 132;
        }
    }
}