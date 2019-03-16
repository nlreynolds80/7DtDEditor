using Domain;
using GameData.ConfigFiles;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services;
using Services.Factories;
using Services.Repositories;
using Services.Serializers;
using Services.Storage;

namespace Tests
{
    [TestClass]
    public class GameDataRepository_Tests
    {
        private GameDataRepository GetGameDataRepository()
        {
            var dropMapper = new DropMapper();
            var passiveEffectMapper = new PassiveEffectMapper();
            var effectRequirementMapper = new EffectRequirementMapper();
            var triggeredEffectMapper = new TriggeredEffectMapper(effectRequirementMapper);
            var effectsMapper = new EffectsGroupMapper(passiveEffectMapper, triggeredEffectMapper);
            var propertyMapper = new PropertyMapper();
            var entityMapper = new EntityMapper(dropMapper, effectsMapper, propertyMapper);
            var entitiesMapper = new EntitiesMapper(entityMapper);

            var entityGroupSubscriptionMapper = new EntityGroupSubscriptionMapper();
            var entityGroupMapper = new EntityGroupMapper(entityGroupSubscriptionMapper);
            var entityGroupsMapper = new EntityGroupsMapper(entityGroupMapper);
            
            var mapperFactory = new MapperFactory(entitiesMapper, entityGroupsMapper);
            var fileStorageService = new LocalFileService();
            var xmlSerializationService = new XmlSerializationService();

            var userSettingsService = new Mock<IUserSettingsService>();
            userSettingsService.Setup(obj => obj.Get()).Returns(new UserSettings() { GameInstallLocation = ".." });

            return new GameDataRepository(fileStorageService, mapperFactory, xmlSerializationService, userSettingsService.Object);
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void GetConfigData_EntityClasses()
        {
            //Arrange
            var testPaths = new TestPaths();
            var configFile = new EntityClassesFile(testPaths);
            var gameDataRepository = GetGameDataRepository();

            //Act
            var entities = gameDataRepository.GetConfigData(configFile);

            //Assert
            Assert.IsNotNull(entities);
            Assert.IsTrue(entities.Count > 0);
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void GetConfigData_EntityGroups()
        {
            //Arrange
            var testPaths = new TestPaths();
            var configFile = new EntityGroupsFile(testPaths);
            var gameDataRepository = GetGameDataRepository();

            //Act
            var entityGroups = gameDataRepository.GetConfigData(configFile);

            //Assert
            Assert.IsNotNull(entityGroups);
            Assert.IsTrue(entityGroups.Count > 0);
        }
    }
}
