using System;
using Domain;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests.Mappers
{
    [TestClass]
    public class EntityGroupMapper_Tests
    {
        private Mock<IMapper<entitygroupsEntitygroupEntity, EntityGroupSubscription>> _entityGroupSubscriptionMapper;

        [TestInitialize]
        public void Initialize()
        {
            _entityGroupSubscriptionMapper = new Mock<IMapper<entitygroupsEntitygroupEntity, EntityGroupSubscription>>();
            _entityGroupSubscriptionMapper.Setup(obj => obj.Convert(It.IsAny<EntityGroupSubscription>())).Returns(new entitygroupsEntitygroupEntity());
            _entityGroupSubscriptionMapper.Setup(obj => obj.Convert(It.IsAny<entitygroupsEntitygroupEntity>()))
                .Returns(new EntityGroupSubscription(new Entity("test"), "0"));
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void ConvertToDomain_GivenValidObject_MapsCorrectly()
        {
            //Arrange
            var entityGroupMapper = new EntityGroupMapper(_entityGroupSubscriptionMapper.Object);
            var xml = new entitygroupsEntitygroup()
            {
                name = "test",
                entity = new entitygroupsEntitygroupEntity[1]
                {
                    new entitygroupsEntitygroupEntity()
                }
            };

            //Act
            var entityGroup = entityGroupMapper.Convert(xml);

            //Assert
            Assert.IsInstanceOfType(entityGroup, typeof(EntityGroup));
            Assert.AreEqual(1, entityGroup.EntitySubscriptions.Count);
            Assert.AreEqual("test", entityGroup.Name);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void ConvertToXml_GivenValidObject_MapsCorrectly()
        {
            //Arrange
            var entityGroupMapper = new EntityGroupMapper(_entityGroupSubscriptionMapper.Object);
            var entityGroup = new EntityGroup("test");

            //Act
            var xml = entityGroupMapper.Convert(entityGroup);

            //Assert
            Assert.IsInstanceOfType(xml, typeof(entitygroupsEntitygroup));
            Assert.AreEqual("test", xml.name);
            Assert.IsNull(xml.entity);
        }
    }
}
