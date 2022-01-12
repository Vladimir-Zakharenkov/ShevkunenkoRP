using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class Card : ViewComponent
    {
        private readonly ICardModelRepository _cardContext;
        public Card(ICardModelRepository context)
        {
            _cardContext = context;
        }

        public IViewComponentResult Invoke(string cardName)
        {
            CardModel card = _cardContext.GetAllCards().FirstOrDefault(x => x.CardName == cardName);

            if (card == null)
            {
                card = _cardContext.GetAllCards().FirstOrDefault(x => x.CardName == "no-card");
            }

            return View(card);
        }
    }
}