using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Serializers
{
    public class JsonSerializationService : ISerializationService
    {
        public T Deserialize<T>(string source) where T : class
        {
            return JsonConvert.DeserializeObject<T>(source);
        }

        public string Serialize<T>(T source) where T : class
        {
            return JsonConvert.SerializeObject(source);
        }
    }
}
