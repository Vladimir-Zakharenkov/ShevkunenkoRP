using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class Card : ViewComponent
    {
        private readonly ICardModelRepository _cardContext;
        public Card(ICardModelRepository context) => _cardContext = context;

        public IViewComponentResult Invoke(string fileName, bool imageIcon)
        {
            CardModel card = _cardContext.GetCardByFileName(fileName);

            if (card == null)
            {
                card = _cardContext.GetCardByFileName("no-image.png");
            }

            ViewData["ImageIcon"] = imageIcon;

            return View(card);
        }
    }
}