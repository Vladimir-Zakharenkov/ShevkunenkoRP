using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class Card : ViewComponent
    {
        private readonly ICardModelRepository _cardContext;
        public Card(ICardModelRepository context) => _cardContext = context;

        public IViewComponentResult Invoke(string imageName)
        {
            CardModel card = _cardContext.GetCard(imageName);

            if (card == null)
            {
                card = _cardContext.GetCard("no-image");
            }

            return View(card);
        }
    }
}