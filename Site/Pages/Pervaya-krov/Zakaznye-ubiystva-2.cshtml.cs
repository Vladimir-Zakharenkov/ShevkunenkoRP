using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Pervaya_krov
{
    [BindProperties(SupportsGet = true)]
    public class Zakaznye_ubiystva_2Model : PageModel
    {
        public uint PageNumber { get; set; }

        public string MovieCaption { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 53;

            MovieCaption = "Программа «Первая кровь» Заказные убийства часть 2";
        }
    }
}
