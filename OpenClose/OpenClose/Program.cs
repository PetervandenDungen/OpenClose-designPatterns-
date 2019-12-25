using OpenClose.Classes;
using OpenClose.Repositories;
using OpenClose.Services.Implementations;
using OpenClose.Services.Implementations.Specifications;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new ProductRepository().GetAllProducts().Take(10);

            foreach (var p in products)
            {
                Console.WriteLine(string.Concat(p.Name, " €", p.Price));
            }

            Console.WriteLine(Environment.NewLine);

            var filter = new Filter(products);
            
            foreach (var p in filter.FilterProducts(new MaxStockAmountSpecification(50))) {
                Console.WriteLine(string.Concat(p.Name, " €", p.Price, " - StockAmount still: ", p.StockAmount));
            }

            Console.WriteLine(Environment.NewLine);

            foreach (var p in filter.FilterProducts(new BrandSpecification(Brand.Volkswagen)))
            {
                Console.WriteLine(string.Concat(p.Name, " €", p.Price, " - Brand: ", p.Brand));
            }

        }
    }
}
