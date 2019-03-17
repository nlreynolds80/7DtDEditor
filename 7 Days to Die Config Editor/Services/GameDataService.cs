using Domain;
using GameData.ConfigFiles;
using GameData.GamePaths;
using Services.Factories;
using Services.Repositories;

namespace Services
{
    public class GameDataService
    {
        private readonly IGameDataRepository _gameDataRepository;
        private readonly IGamePaths _gamePaths;
        private readonly ILinkerFactory _linkerFactory;

        private Entities _entities;
        private EntityGroups _entityGroups;

        public GameDataService(IGameDataRepository gameDataRepository, IGamePaths gamePaths, ILinkerFactory linkerFactory)
        {
            _gameDataRepository = gameDataRepository;
            _gamePaths = gamePaths;
            _linkerFactory = linkerFactory;
        }

        public Result<Entities> GetEntities()
        {
            if (_entities == null)
            {
                var config = new EntityClassesFile(_gamePaths);
                _entities = _gameDataRepository.GetConfigData(config);
            }
            return Result.Ok(_entities);
        }

        public Result<EntityGroups> GetEntityGroups()
        {
            if (_entityGroups == null)
            {
                var config = new EntityGroupsFile(_gamePaths);
                _entityGroups = _gameDataRepository.GetConfigData(config);
                _entityGroups = _linkerFactory.GetLinker(_entityGroups).Link(_entities);
            }
            return Result.Ok(_entityGroups);
        }

        public Result Save<T>(T data, string fullPath = null)
        {
            switch (data)
            {
                case Entities d:
                    var entitiesConfig = new EntityClassesFile(_gamePaths);
                    _gameDataRepository.SaveConfigData(entitiesConfig, d, fullPath);
                    break;
                case EntityGroups d:
                    var entityGroupsConfig = new EntityGroupsFile(_gamePaths);
                    _gameDataRepository.SaveConfigData(entityGroupsConfig, d, fullPath);
                    break;
            }

            return Result.Ok();
        }
    }
}
