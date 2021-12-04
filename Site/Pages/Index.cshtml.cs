using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class IndexModel : PageModel
    {
        public string PageTitle { get; set; }

        public string CardLink { get; set; }
        public void OnGet()
        {
            PageTitle = "���� ������ ������ ����������";
            CardLink = "https://shevkunenko.ru/biografy.htm";
        }
    }
}
