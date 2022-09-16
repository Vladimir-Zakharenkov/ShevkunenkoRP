using System.Collections.Generic;

namespace BaseViewComponent.Model
{
    public class ProductRepository
    {
        public List<Product> Products { get; set; }

        public ProductRepository()
        {
            Products = new List<Product>()
            {
                new Product() { Id = 1, Name ="Product 1", Price = 100.00  },
                new Product() { Id = 2, Name ="Product 2", Price = 50.25  },
                new Product() { Id = 3, Name ="Product 3", Price = 130.10  },
                new Product() { Id = 4, Name ="Product 4", Price = 170.50  }
            };
        }
    }
}
