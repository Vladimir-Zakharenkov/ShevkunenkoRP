using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class DetailsCardModel : PageModel
    {
        private readonly ICardModelRepository _cardContext;

        public DetailsCardModel(ICardModelRepository cardContext)
        {
            _cardContext = cardContext;
        }

        public uint PageNumber { get; set; }

        public CardModel Card { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = 23;

            Card = _cardContext.GetCardById(Card.CardId);

            if (Card == null)
            {
                return RedirectToPage("ViewCards");
            }

            return Page();
        }
    }
}