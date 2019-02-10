using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mappers
{
    public interface IMapper<X, T> 
        where X : class 
        where T : class
    {
        X ConvertFrom(T domainSource);
        T ConvertTo(X xmlSource);
    }
}
