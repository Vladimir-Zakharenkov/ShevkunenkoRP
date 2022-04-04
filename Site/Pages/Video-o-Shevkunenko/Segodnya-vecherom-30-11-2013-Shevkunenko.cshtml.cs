using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Video_o_Shevkunenko
{
    [BindProperties(SupportsGet = true)]
    public class Segodnya_vecherom_30_11_2013_ShevkunenkoModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 44;
        }
    }
}