using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Video_o_Shevkunenko
{
    [BindProperties(SupportsGet = true)]
    public class Pust_govoryat_16_05_2019Model : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 108;
        }
    }
}