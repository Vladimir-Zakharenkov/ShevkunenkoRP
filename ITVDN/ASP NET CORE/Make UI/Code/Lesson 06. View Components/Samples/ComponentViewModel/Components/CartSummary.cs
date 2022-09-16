using ComponentViewModel.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ComponentViewModel.Components
{
    public class CartSummary : ViewComponent
    {
        private readonly ProductRepository repository;

        public CartSummary(ProductRepository repository)
        {
            this.repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            CartSummaryViewModel viewModel = new CartSummaryViewModel()
            {
                Sum = repository.Products.Sum(x => x.Price),
                ProductCount = repository.Products.Count()
            };

            return View(viewModel);
        }
    }
}
