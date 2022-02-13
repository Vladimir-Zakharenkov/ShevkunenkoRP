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
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly ICardModelRepository _cardContext;

        public DetailsCardModel(ISitemapModelRepository sitemapContext, ICardModelRepository cardContext)
        {
            _sitemapContext = sitemapContext;
            _cardContext = cardContext;
        }

        public uint PageNumber { get; set; }

        public CardModel Card { get; set; }

        public IActionResult OnGet()
        {
            Card = _cardContext.GetCardById(Card.CardId);

            if (Card == null)
            {
                return RedirectToPage("ViewCards");
            }

            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            return Page();
        }
    }
}