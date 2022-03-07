using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Lihie_90_e
{
    [BindProperties(SupportsGet = true)]
    public class Blesk_i_nisheta_90hModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string MovieCaption { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 75;

            MovieCaption = "Программа «Лихие 90-е» Блеск и нищета 90-х";
        }
    }
}