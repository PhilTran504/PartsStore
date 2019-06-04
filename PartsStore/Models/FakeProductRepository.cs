using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartsStore.Models
{
    public class FakeProductRepository /* : IProductRepository */
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {ProductName = "Supra Exhaust", Price = 1500},
            new Product {ProductName = "FPGreen Turbo", Price = 1800},
            new Product {ProductName = "Work Wheels", Price = 3200}
        }.AsQueryable<Product>();
    }
}
