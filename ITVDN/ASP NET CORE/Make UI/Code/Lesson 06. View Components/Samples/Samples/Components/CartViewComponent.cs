using PocoComponentSample.Model;
using System.Linq;

namespace PocoComponentSample.Components
{
    public class CartViewComponent
    {
        private readonly ProductRepository productRepositroy;

        public CartViewComponent(ProductRepository productRepositroy)
        {
            this.productRepositroy = productRepositroy;
        }

        public string Invoke()
        {
            return $"{productRepositroy.Products.Count} products, sum: {productRepositroy.Products.Sum(x => x.Price)}$";
        }
    }
}
