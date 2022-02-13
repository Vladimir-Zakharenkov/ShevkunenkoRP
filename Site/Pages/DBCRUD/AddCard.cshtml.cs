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
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly ICardModelRepository _cardContext;
        private readonly IImageModelRepository _imageContext;

        public AddCardModel(ISitemapModelRepository sitemapContext, ICardModelRepository cardContext, IImageModelRepository imageContext)
        {
            _sitemapContext = sitemapContext;
            _cardContext = cardContext;
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; }

        public CardModel Card { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            return Page();
        }

        public IActionResult OnPost()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

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

            if (ModelState.IsValid)
            {
                _cardContext.AddCard(Card);

                return RedirectToPage("ViewCards");
            }

            return Page();
        }
    }
}