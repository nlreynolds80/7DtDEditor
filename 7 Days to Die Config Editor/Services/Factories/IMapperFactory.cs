using GameData.ConfigFiles;
using GameData.Mappers;

namespace Services.Factories
{
    public interface IMapperFactory
    {
        IMapper<X, T> GetMapper<X, T>(ConfigFile<X, T> config);
    }
}
