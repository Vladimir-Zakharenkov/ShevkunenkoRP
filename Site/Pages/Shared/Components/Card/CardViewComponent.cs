using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.Shared.Components.Card
{
    public class Card : ViewComponent
    {
        private readonly ICardModelRepository _context;
        public Card(ICardModelRepository context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(string cardName)
        {
            CardModel card = _context.GetAllCards().Where(x => x.CardName == cardName).FirstOrDefault();

            return View(card);
        }
    }

}
