using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.ViewComponents
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
            CardModel card = _context.GetAllCards().FirstOrDefault(x => x.CardName == cardName);

            return View(card);
        }
    }
}
