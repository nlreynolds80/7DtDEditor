using System;
using Domain;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests.Mappers
{
    [TestClass]
    public class EntityGroupsMapper_Tests
    {
        private Mock<IMapper<entitygroupsEntitygroup, EntityGroup>> _entityGroupMapper;

        [TestInitialize]
        public void Initialize()
        {
            _entityGroupMapper = new Mock<IMapper<entitygroupsEntitygroup, EntityGroup>>();
            _entityGroupMapper.Setup(obj => obj.Convert(It.IsAny<entitygroupsEntitygroup>())).Returns(new EntityGroup("test"));
            _entityGroupMapper.Setup(obj => obj.Convert(It.IsAny<EntityGroup>())).Returns(new entitygroupsEntitygroup());
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void ConvertToDomain_GivenValidObject_MapsCorrectly()
        {
            //Arrange
            var entityGroupsMapper = new EntityGroupsMapper(_entityGroupMapper.Object);
            var xml = new entitygroups()
            {
                Items = new entitygroupsEntitygroup[1]
                {
                    new entitygroupsEntitygroup()
                }
            };

            //Act
            var entityGroups = entityGroupsMapper.Convert(xml);

            //Assert
            Assert.IsInstanceOfType(entityGroups, typeof(EntityGroups));
            Assert.AreEqual(1, entityGroups.Count);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void ConvertToXml_GivenValidObject_MapsCorrectly()
        {
            //Arrange
            var entityGroupsMapper = new EntityGroupsMapper(_entityGroupMapper.Object);
            var entityGroups = new EntityGroups()
            {
                {"test", new EntityGroup("test") }
            };

            //Act
            var xml = entityGroupsMapper.Convert(entityGroups);

            //Assert
            Assert.IsInstanceOfType(xml, typeof(entitygroups));
            Assert.AreEqual(1, xml.Items.Length);
        }
    }
}
