using Domain;
using Newtonsoft.Json;
using System;

namespace Services.Serializers
{
    public class JsonSerializationService : ISerializationService
    {
        public Result<T> Deserialize<T>(string source) where T : class
        {
            try
            {
                return Result.Ok(JsonConvert.DeserializeObject<T>(source));
            }
            catch(Exception ex)
            {
                return Result.Fail<T>(ex.Message);
            }
        }

        public Result<string> Serialize<T>(T source) where T : class
        {
            try
            {
                return Result.Ok(JsonConvert.SerializeObject(source));
            }
            catch(Exception ex)
            {
                return Result.Fail<string>(ex.Message);
            }
        }
    }
}
