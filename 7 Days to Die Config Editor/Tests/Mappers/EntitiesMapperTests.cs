using System;
using Domain;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests.Mappers
{
    [TestClass]
    public class EntitiesMapperTests
    {
        private Mock<IMapper<entity_classesEntity_class, Entity>> _entityMapper;

        [TestInitialize]
        public void Initialize()
        {
            _entityMapper = new Mock<IMapper<entity_classesEntity_class, Entity>>();
            _entityMapper.Setup(obj => obj.Convert(It.IsAny<entity_classesEntity_class>())).Returns(new Entity("test"));
            _entityMapper.Setup(obj => obj.Convert(It.IsAny<Entity>())).Returns(new entity_classesEntity_class());
        }

        [TestMethod]
        public void ConvertToDomain_GivenValidObject_MapsCorrectly()
        {
            //Arrange
            var entitiesMapper = new EntitiesMapper(_entityMapper.Object);
            var entityclasses = new entity_classes()
            {
                Items = new object[1] 
                {
                    new entity_classesEntity_class()
                }
            };

            //Act
            var entities = entitiesMapper.Convert(entityclasses);

            //Assert
            Assert.IsInstanceOfType(entities, typeof(Entities));
            Assert.AreEqual(1, entities.Count);
        }

        [TestMethod]
        public void ConvertToXml_GivenValidObject_MapsCorrectly()
        {
            //Arrange
            var entitiesMapper = new EntitiesMapper(_entityMapper.Object);
            var entities = new Entities()
            {
                {"test", new Entity("test") }
            };

            //Act
            var entityclasses = entitiesMapper.Convert(entities);

            //Assert
            Assert.IsInstanceOfType(entityclasses, typeof(entity_classes));
            Assert.AreEqual(1, entityclasses.Items.Length);
        }
    }
}
