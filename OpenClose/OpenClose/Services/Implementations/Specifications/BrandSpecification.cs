using OpenClose.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose.Services.Implementations.Specifications
{
    public class BrandSpecification : ISpecification<Product>
    {
        private Brand _brand;

        public BrandSpecification(Brand brand)
        {
            _brand = brand;
        }

        public bool IsTrue(Product t)
        {
            if (t.Brand <= _brand)
            {
                return true;
            }

            return false;
        }
    }
}
