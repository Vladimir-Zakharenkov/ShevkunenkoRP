using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class ViewCardsModel : PageModel
    {
        private readonly ICardModelRepository _cardContext;

        public ViewCardsModel(ICardModelRepository cardContext)
        {
            _cardContext = cardContext;
        }

        public uint PageNumber { get; set; }

        public IEnumerable<CardModel> AllCards { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = 22;

            AllCards = _cardContext.Cards.ToArray(); ;

            return Page();
        }
    }
}
