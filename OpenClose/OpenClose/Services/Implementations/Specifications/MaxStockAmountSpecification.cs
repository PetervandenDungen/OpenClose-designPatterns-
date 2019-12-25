using OpenClose.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose.Services.Implementations.Specifications
{
    public class MaxStockAmountSpecification : ISpecification<Product>
    {
        private int _maxStockAmount;

        public MaxStockAmountSpecification(int maxStockAmount)
        {
            _maxStockAmount = maxStockAmount;
        }

        public bool IsTrue(Product t)
        {
            if (t.StockAmount <= _maxStockAmount)
            {
                return true;
            }

            return false;
        }
    }
}
