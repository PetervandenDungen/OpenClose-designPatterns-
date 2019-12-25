using OpenClose.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose.Repositories
{
    public class ProductRepository
    {
        public IEnumerable<Product> GetAllProducts()
        {
            for (int i = 0; i < 100; i++)
            {
                yield return new Product()
                {
                    ProductId = i,
                    Name = $"Product {i}",
                    Price = Convert.ToDecimal(new Random().NextDouble()),
                    StockAmount = new Random().Next(1, 100),
                    Brand = (Brand)new Random().Next(0, Enum.GetValues(typeof(Brand)).Length)
                };
            }
        }
    }
}
