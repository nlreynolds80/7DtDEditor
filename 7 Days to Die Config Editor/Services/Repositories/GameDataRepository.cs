using GameData.ConfigFiles;
using Services.Factories;
using Services.Serializers;
using Services.Storage;
using System;

namespace Services.Repositories
{
    public class GameDataRepository : IGameDataRepository
    {
        private readonly IFileStorageService _fileStorageService;
        private readonly IMapperFactory _mapperFactory;
        private readonly ISerializationService _serializationService;
        private readonly IUserSettingsService _userSettingsService;

        public GameDataRepository(IFileStorageService fileStorageService, IMapperFactory mapperFactory, ISerializationService serializationService, IUserSettingsService userSettingsService)
        {
            _fileStorageService = fileStorageService;
            _mapperFactory = mapperFactory;
            _serializationService = serializationService;
            _userSettingsService = userSettingsService;
        }

        public T GetConfigData<X, T>(ConfigFile<X, T> config, string pathOverride = null)
            where X : class
            where T : class
        {
            var path = pathOverride ?? $@"{_userSettingsService.Get().GameInstallLocation}\{config.GamePath}";
            var xml = _fileStorageService.Get(path).Value;
            var xmlclasses = _serializationService.Deserialize<X>(xml);
            return _mapperFactory.GetMapper(config).Convert(xmlclasses);
        }

        public void SaveConfigData<X, T>(ConfigFile<X, T> config, T data, string pathOverride = null)
            where X : class
            where T : class
        {
            var path = pathOverride ?? $@"{_userSettingsService.Get().GameInstallLocation}\{config.GamePath}";
            var xmlclasses = _mapperFactory.GetMapper(config).Convert(data);
            var xml = _serializationService.Serialize(data);
            _fileStorageService.Save(xml, path);
        }
    }
}
