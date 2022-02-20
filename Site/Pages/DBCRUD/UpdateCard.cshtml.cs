using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class UpdateCardModel : PageModel
    {
        private readonly ICardModelRepository _cardContext;
        private readonly IImageModelRepository _imageContext;
        private readonly IMovieModelRepository _movieContext;

        public UpdateCardModel(
            ICardModelRepository cardContext,
            IImageModelRepository imageContext,
            IMovieModelRepository movieContext)

        {
            _cardContext = cardContext;
            _imageContext = imageContext;
            _movieContext = movieContext;
        }

        public uint PageNumber { get; set; }

        public CardModel CardToUpdate { get; set; }

        public IActionResult OnGet(Guid? cardId)
        {
            PageNumber = 24;

            if (cardId == null || _cardContext.Cards.FirstOrDefault(x => x.CardId == cardId) == null)
            {
                return RedirectToPage("ViewCards");
            }

            CardToUpdate = _cardContext.GetCardById(cardId);

            return Page();
        }

        public IActionResult OnPost()
        {
            PageNumber = 24; ;

            if (_imageContext.Images.FirstOrDefault(x => x.ImageName == CardToUpdate.ImageName) == null)
            {
                ModelState.AddModelError("CardToUpdate.ImageName", "ViewComponent с таким параметром не существует");

                return Page();
            }

            if (CardToUpdate.CardMovie == true & _movieContext.Movies.FirstOrDefault(x => x.MovieCaption == CardToUpdate.MovieCaption) == null)
            {
                ModelState.AddModelError("CardToUpdate.MovieCaption", "Фильма с таким названием не существует");

                return Page();
            }

            //if (_cardContext.Cards.FirstOrDefault(x => x.ImageName == CardToUpdate.ImageName) != null)
            //{
            //    ModelState.AddModelError("CardToUpdate.ImageName", "Карточка с такой картинкой уже существует");

            //    return Page();
            //}

            if (ModelState.IsValid)
            {
                _cardContext.UpdateCard(CardToUpdate);

                return RedirectToPage("ViewCards");
            }

            return Page();
        }
    }
}
