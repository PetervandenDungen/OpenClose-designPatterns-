using OpenClose.Classes;
using System.Collections.Generic;

namespace OpenClose.Services.Implementations
{
    public class Filter : IFilter<Product>
    {
        private IEnumerable<Product> _products;

        public Filter(IEnumerable<Product> products)
        {
            _products = products;
        }

        public IEnumerable<Product> FilterProducts(ISpecification<Product> specification)
        {
            foreach (var p in _products)
            {
                if (specification.IsTrue(p))
                {
                    yield return p;
                }

            }
        }
    }
}
