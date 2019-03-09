using Domain;
using GameData.ConfigFiles;
using GameData.GamePaths;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services.Factories;
using System.Collections.Generic;

namespace Tests.Mappers
{
    [TestClass]
    public class MapperFactory_Tests
    {
        private Mock<IMapper<entity_classes, Entities>> _entitiesMapper;
        private Mock<IGamePaths> _gamePaths;

        [TestInitialize]
        public void Initialize()
        {
            _entitiesMapper = new Mock<IMapper<entity_classes, Entities>>();
            _gamePaths = new Mock<IGamePaths>();
        }

        [TestMethod]
        public void GetMapper_EntityClasses_Returns_EntitiesMapper()
        {
            //Arrange
            var mapperFactory = new MapperFactory(_entitiesMapper.Object);
            var config = new EntityClasses(_gamePaths.Object);

            //Act
            var mapper = mapperFactory.GetMapper(config);

            //Assert
            Assert.IsInstanceOfType(mapper, typeof(IMapper<entity_classes, Entities>));
        }
    }
}
