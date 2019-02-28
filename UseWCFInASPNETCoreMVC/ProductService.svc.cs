using System.Collections.Generic;

namespace UseWCFInASPNETCoreMVC
{
    public class ProductService : IProductService
    {
        public Product Find()
        {
            return new Product() { Id = "p01", Name = "Name 1", Price = 200 };
        }

        public List<Product> FindAll()
        {

            return new List<Product>()
            {
                new Product() { Id = "p02", Name = "Name 2", Price = 230 },
                new Product() { Id = "p03", Name = "Name 3", Price = 400 },
                new Product() { Id = "p04", Name = "Name 4", Price = 500 }
            };
        }
    }
}
