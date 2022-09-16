using ComponentContext.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ComponentContext.Components
{
    public class ProductTable : ViewComponent
    {
        private readonly ProductRepository repository;

        public ProductTable(ProductRepository repository)
        {
            this.repository = repository;
        }

        public IViewComponentResult Invoke(bool showId, bool showTotal)
        {
            ProductTableViewModel viewModel = new ProductTableViewModel()
            {
                Products = repository.Products,
                ShowId = showId,
                ShowTotal = showTotal,
                Total = showTotal ? repository.Products.Sum(x => x.Price) : 0
            };

            return View(viewModel);
        }
    }
}
