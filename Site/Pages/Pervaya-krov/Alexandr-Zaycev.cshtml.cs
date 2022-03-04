using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Pervaya_krov
{
    [BindProperties(SupportsGet = true)]
    public class Alexandr_ZaycevModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string MovieCaption { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 63;

            MovieCaption = "Программа «Первая кровь» Александр Зайцев";
        }
    }
}
