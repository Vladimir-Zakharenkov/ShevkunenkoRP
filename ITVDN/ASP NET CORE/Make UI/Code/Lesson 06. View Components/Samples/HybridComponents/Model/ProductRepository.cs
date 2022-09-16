using System.Collections.Generic;
using System.Linq;

namespace HybridComponents.Model
{
    public class ProductRepository
    {
        public List<Product> Products { get; set; }

        public ProductRepository()
        {
            Products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Product 1", Price = 100.00  },
                new Product() { Id = 2, Name = "Product 2", Price = 50.25  },
                new Product() { Id = 3, Name = "Product 3", Price = 130.10  },
                new Product() { Id = 4, Name = "Product 4", Price = 170.50  }
            };
        }

        public void AddProduct(string name, double price)
        {
            Product product = new Product()
            {
                Id = Products.Last().Id + 1,
                Name = name,
                Price = price
            };

            Products.Add(product);
        }
    }
}
