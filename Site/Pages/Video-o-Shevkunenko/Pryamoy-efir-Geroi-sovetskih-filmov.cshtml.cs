using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Video_o_Shevkunenko
{
    [BindProperties(SupportsGet = true)]
    public class Pryamoy_efir_Geroi_sovetskih_filmovModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 37;
        }
    }
}