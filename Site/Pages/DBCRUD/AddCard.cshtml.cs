using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class AddCardModel : PageModel
    {
        private readonly ICardModelRepository _cardContext;
        private readonly IImageModelRepository _imageContext;
        private readonly IMovieModelRepository _movieContext;

        public AddCardModel(ICardModelRepository cardContext, IImageModelRepository imageContext, IMovieModelRepository movieContext)
        {
            _cardContext = cardContext;
            _imageContext = imageContext;
            _movieContext = movieContext;
        }

        public uint PageNumber { get; set; }

        public CardModel Card { get; set; }

        public void OnGet()
        {
            PageNumber = 25;
        }

        public IActionResult OnPost()
        {
            PageNumber = 25;

            if (_imageContext.Images.FirstOrDefault(x => x.ImageName == Card.ImageName) == null)
            {
                ModelState.AddModelError("Card.ImageName", "ViewComponent с таким параметром не существует");

                return Page();
            }

            if (_cardContext.Cards.FirstOrDefault(x => x.ImageName == Card.ImageName) != null)
            {
                ModelState.AddModelError("Card.ImageName", "Карточка с такой картинкой уже существует");

                return Page();
            }

            if (Card.CardMovie == true & _movieContext.Movies.FirstOrDefault(x => x.MovieCaption == Card.MovieCaption) == null)
            {
                ModelState.AddModelError("Card.MovieCaption", "Фильма с таким названием не существует");

                return Page();
            }

            if (ModelState.IsValid)
            {
                _cardContext.AddCard(Card);

                return RedirectToPage("ViewCards");
            }

            return Page();
        }
    }
}