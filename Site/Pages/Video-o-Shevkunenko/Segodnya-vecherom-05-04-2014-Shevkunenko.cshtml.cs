using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Video_o_Shevkunenko
{
    [BindProperties(SupportsGet = true)]
    public class Segodnya_vecherom_05_04_2014_ShevkunenkoModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string MovieCaption { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 48;

            MovieCaption = "Программа «Сегодня вечером» от 05.04.2014 о Шевкуненко";
        }
    }
}