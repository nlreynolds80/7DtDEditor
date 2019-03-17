using Domain;

namespace Services.Serializers
{
    public interface ISerializationService
    {
        Result<string> Serialize<T>(T source) where T : class;

        Result<T> Deserialize<T>(string source) where T : class;
    }
}
