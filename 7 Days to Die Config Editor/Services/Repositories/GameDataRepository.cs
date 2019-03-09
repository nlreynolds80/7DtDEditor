using GameData.ConfigFiles;
using GameData.GamePaths;
using Services.Factories;
using Services.Serializers;
using Services.Storage;

namespace Services.Repositories
{
    class GameDataRepository : IGameDataRepository
    {
        private readonly IFileStorageService _fileStorageService;
        private readonly IMapperFactory _mapperFactory;
        private readonly ISerializationService _serializationService;

        public T GetConfigData<X, T>(ConfigFile<X, T> config) where X : class where T : class
        {
            var xml = _fileStorageService.Get(config.GamePath);
            var rawdata = _serializationService.Deserialize<X>(xml);
            return _mapperFactory.GetMapper(config).Convert(rawdata);
        }

        public GameDataRepository(IFileStorageService fileStorageService, ISerializationService serializationService, IMapperFactory mapperFactory)
        {
            _fileStorageService = fileStorageService;
            _mapperFactory = mapperFactory;
            _serializationService = serializationService;
        }
    }
}
