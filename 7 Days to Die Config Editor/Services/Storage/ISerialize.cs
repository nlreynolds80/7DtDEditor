using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ISerialize
    {
        string Serialize<T>(T source);
        T Deserialize<T>(string source);
    }
}
