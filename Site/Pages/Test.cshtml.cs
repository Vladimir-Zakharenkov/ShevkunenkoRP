using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class TestModel : PageModel
    {
        public string TestText { get; set; }
        public void OnGet()
        {
            TestText = "ТестТекст";
        }
    }
}
