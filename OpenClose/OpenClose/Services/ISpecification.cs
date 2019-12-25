using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose.Services
{
    public interface ISpecification<T>
    {
        bool IsTrue(T t);
    }
}
