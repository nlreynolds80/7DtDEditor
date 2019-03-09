using Domain;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace Tests.Mappers
{
    [TestClass]
    public class EntityMapperTests
    {
        private Mock<IMapper<entity_classesEntity_classDrop, Drop>> _dropMapper;
        private Mock<IMapper<entity_classesEntity_classEffect_group, EffectsGroup>> _effectsMapper;
        private Mock<IMapper<property, Property>> _propertyMapper;

        [TestInitialize]
        public void Initialize()
        {
            _dropMapper = new Mock<IMapper<entity_classesEntity_classDrop, Drop>>();
            _dropMapper.Setup(obj => obj.Convert(It.IsAny<entity_classesEntity_classDrop>())).Returns(new Drop("test"));
            _dropMapper.Setup(obj => obj.Convert(It.IsAny<Drop>())).Returns(new entity_classesEntity_classDrop());

            _effectsMapper = new Mock<IMapper<entity_classesEntity_classEffect_group, EffectsGroup>>();
            _effectsMapper.Setup(obj => obj.Convert(It.IsAny<entity_classesEntity_classEffect_group>())).Returns(new EffectsGroup("test"));
            _effectsMapper.Setup(obj => obj.Convert(It.IsAny<EffectsGroup>())).Returns(new entity_classesEntity_classEffect_group());

            _propertyMapper = new Mock<IMapper<property, Property>>();
            _propertyMapper.Setup(obj => obj.Convert(It.IsAny<property>())).Returns(new Property("test"));
            _propertyMapper.Setup(obj => obj.Convert(It.IsAny<Property>())).Returns(new property());
        }

        [TestMethod]
        public void ConvertToDomain_GivenValidObject_MapsCorrectly()
        {
            //Arrange
            var entityMapper = new EntityMapper(_dropMapper.Object, _effectsMapper.Object, _propertyMapper.Object);
            var xmlEntity = new entity_classesEntity_class()
            {
                drop = new entity_classesEntity_classDrop[1] { new entity_classesEntity_classDrop() },
                effect_group = new entity_classesEntity_classEffect_group[1] { new entity_classesEntity_classEffect_group() },
                property = new property[1] { new property() },
                extends = "test",
                name = "testEntity"
            };

            //Act
            var entity = entityMapper.Convert(xmlEntity);

            //Assert
            Assert.IsInstanceOfType(entity, typeof(Entity));
            Assert.AreEqual(1, entity.Drops.Count);
            Assert.AreEqual(1, entity.Effects.Count);
            Assert.AreEqual(1, entity.Properties.Count);
            Assert.AreEqual("test", entity.Extends);
            Assert.AreEqual("testEntity", entity.Name);
        }

        [TestMethod]
        public void ConvertToDomain_GivenNulls_MapsCorrectly()
        {
            //Arrange
            var entityMapper = new EntityMapper(_dropMapper.Object, _effectsMapper.Object, _propertyMapper.Object);
            var xmlEntity = new entity_classesEntity_class();

            //Act
            var entity = entityMapper.Convert(xmlEntity);

            //Assert
            Assert.IsInstanceOfType(entity, typeof(Entity));
            Assert.AreEqual(0, entity.Drops.Count);
            Assert.AreEqual(0, entity.Effects.Count);
            Assert.AreEqual(0, entity.Properties.Count);
            Assert.IsNull(entity.Extends);
            Assert.IsNull(entity.Name);
        }

        [TestMethod]
        public void ConvertToXml_GivenValidObject_MapsCorrectly()
        {
            //Arrange
            var entityMapper = new EntityMapper(_dropMapper.Object, _effectsMapper.Object, _propertyMapper.Object);
            var entity = new Entity("testEntity") { Extends = "test" };
            entity.SetDrops(new List<Drop>() { new Drop("test") });
            entity.SetEffects(new List<EffectsGroup>() { new EffectsGroup("test") });
            entity.SetProperties(new List<Property>() { new Property("test") });

            //Act
            var xmlEntity = entityMapper.Convert(entity);

            //Assert
            Assert.IsInstanceOfType(xmlEntity, typeof(entity_classesEntity_class));
            Assert.AreEqual(1, xmlEntity.drop.Length);
            Assert.AreEqual(1, xmlEntity.effect_group.Length);
            Assert.AreEqual(1, xmlEntity.property.Length);
            Assert.AreEqual("test", xmlEntity.extends);
            Assert.AreEqual("testEntity", xmlEntity.name);
        }

        [TestMethod]
        public void ConvertToXml_GivenNulls_MapsCorrectly()
        {
            //Arrange
            var entityMapper = new EntityMapper(_dropMapper.Object, _effectsMapper.Object, _propertyMapper.Object);
            var entity = new Entity("testEntity");

            //Act
            var xmlEntity = entityMapper.Convert(entity);

            //Assert
            Assert.IsInstanceOfType(xmlEntity, typeof(entity_classesEntity_class));
            Assert.IsNull(xmlEntity.drop);
            Assert.IsNull(xmlEntity.effect_group);
            Assert.IsNull(xmlEntity.property);
            Assert.IsNull(xmlEntity.extends);
        }
    }
}
