using Domain;
using Newtonsoft.Json;

namespace Services.Serializers
{
    public class JsonSerializationService : ISerializationService
    {
        public Result<T> Deserialize<T>(string source) where T : class
        {
            return Result.Ok(JsonConvert.DeserializeObject<T>(source));
        }

        public Result<string> Serialize<T>(T source) where T : class
        {
            return Result.Ok(JsonConvert.SerializeObject(source));
        }
    }
}
