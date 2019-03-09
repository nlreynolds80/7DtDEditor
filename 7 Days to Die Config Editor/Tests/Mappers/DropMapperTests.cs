using Domain;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Mappers
{
    [TestClass]
    public class DropMapperTests
    {
        [TestMethod]
        public void ConvertoToDomain_MapsCorrectly()
        {
            //Arrange
            var dropMapper = new DropMapper();
            var xmlSource = new entity_classesEntity_classDrop()
            {
                name = "name",
                @event = "event",
                count = "count",
                tool_category = "toolcat",
                tag = "tag"
            };

            //Act
            var drop = dropMapper.Convert(xmlSource);

            //Assert
            Assert.IsInstanceOfType(drop, typeof(Drop));
            Assert.AreEqual("name", drop.Name);
            Assert.AreEqual("event", drop.Event);
            Assert.AreEqual("count", drop.Count);
            Assert.AreEqual("toolcat", drop.ToolCategory);
            Assert.AreEqual("tag", drop.Tag);
        }

        [TestMethod]
        public void ContertToXml_MapsCorrectly()
        {
            //Arrange
            var dropMapper = new DropMapper();
            var domainSource = new Drop("name")
            {
                Event = "event",
                Count = "count",
                ToolCategory = "toolcat",
                Tag = "tag"
            };

            //Act
            var drop = dropMapper.Convert(domainSource);

            //Assert
            Assert.IsInstanceOfType(drop, typeof(entity_classesEntity_classDrop));
            Assert.AreEqual("name", drop.name);
            Assert.AreEqual("event", drop.@event);
            Assert.AreEqual("count", drop.count);
            Assert.AreEqual("toolcat", drop.tool_category);
            Assert.AreEqual("tag", drop.tag);
        }
    }
}
