using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Lihie_90_e
{
    [BindProperties(SupportsGet = true)]
    public class Prodavcy_vozduhaModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string MovieCaption { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 85;

            MovieCaption = "Программа «Лихие 90-е» Продавцы воздуха";
        }
    }
}
