using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.SlideShow
{
    public class Foto_iz_filmovModel : PageModel
    {
        public uint PageNumber { get; set; }
        public void OnGet()
        {
            PageNumber = 29;
        }
    }
}