using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;

namespace Site.Pages
{
    public class TestModel : PageModel
    {
        private readonly ICardModelRepository _context;
        public TestModel(ICardModelRepository context)
        {
            _context = context;
        }
        public string TestText { get; set; }

        public IEnumerable<CardModel> CardModel { get; set; }

        public void OnGet()
        {
            TestText = "ТестТекст";
        }
    }
}
