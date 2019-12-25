using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose.Services
{
    public interface IFilter<T>
    {
        IEnumerable<T> FilterProducts(ISpecification<T> IsTrue);
    }
}
