using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Serializers
{
    public interface ISerializationService
    {
        string Serialize<T>(T source);
        T Deserialize<T>(string source);
    }
}
