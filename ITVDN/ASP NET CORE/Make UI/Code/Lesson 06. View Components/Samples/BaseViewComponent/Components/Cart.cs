using BaseViewComponent.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BaseViewComponent.Components
{
    // При наследовании от класса ViewComponent указывать суффикс ViewComponent в имени класса не обязательно
    public class Cart : ViewComponent
    {
        private readonly ProductRepository productRepositroy;

        public Cart(ProductRepository productRepositroy)
        {
            this.productRepositroy = productRepositroy;
        }

        public string Invoke()
        {
            return $"{productRepositroy.Products.Count} products, sum: {productRepositroy.Products.Sum(x => x.Price)}$";
        }
    }
}
