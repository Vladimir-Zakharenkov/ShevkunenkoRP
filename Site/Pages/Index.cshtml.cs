using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class IndexModel : PageModel
    {
        public string PageTitle { get; set; }

        public string CardLink { get; set; }
        public void OnGet()
        {
            PageTitle = "яюир оюлърх яепцеъ ьебйсмемйн";
            CardLink = "https://shevkunenko.ru/biografy.htm";
        }
    }
}
