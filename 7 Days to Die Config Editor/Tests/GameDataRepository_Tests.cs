﻿using Domain;
using GameData.ConfigFiles;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Factories;
using Services.Repositories;
using Services.Serializers;
using Services.Storage;
using System.Collections.Generic;

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
            var mapperFactory = new MapperFactory(entitiesMapper);
            var fileStorageService = new LocalFileService();
            var xmlSerializationService = new XmlSerializationService();

            return new GameDataRepository(fileStorageService, xmlSerializationService, mapperFactory);
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void GetConfigData_EntityClasses()
        {
            //Arrange
            var testPaths = new TestPaths();
            var configFile = new EntityClasses(testPaths);
            var gameDataRepository = GetGameDataRepository();

            //Act
            var entities = gameDataRepository.GetConfigData(configFile);

            //Assert
            Assert.IsNotNull(entities);
            Assert.IsTrue(entities.Count > 0);
        }
    }
}
