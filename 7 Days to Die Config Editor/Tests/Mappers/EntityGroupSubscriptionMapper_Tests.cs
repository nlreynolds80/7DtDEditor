using Domain;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Mappers
{
    [TestClass]
    public class EntityGroupSubscriptionMapper_Tests
    {
        [TestMethod]
        public void ConvertToDomain_GivenValidObject_MapsCorrectly()
        {
            //Arrange
            var mapper = new EntityGroupSubscriptionMapper();
            var xmlSource = new entitygroupsEntitygroupEntity()
            {
                name = "test",
                prob = "0.5"
            };

            //Act
            var entityGroupSubscription = mapper.Convert(xmlSource);

            //Assert
            Assert.IsInstanceOfType(entityGroupSubscription, typeof(EntityGroupSubscription));
            Assert.AreEqual("test", entityGroupSubscription.Name);
            Assert.AreEqual("0.5", entityGroupSubscription.Probability);
        }

        [TestMethod]
        public void ConvertToXml_GivenValidObject_MapsCorrectly()
        {
            //Arrange
            var mapper = new EntityGroupSubscriptionMapper();
            var entity = new Entity("test");
            var entityGroupSubscription = new EntityGroupSubscription(entity, "0.5");

            //Act
            var xml = mapper.Convert(entityGroupSubscription);

            //Assert
            Assert.IsInstanceOfType(xml, typeof(entitygroupsEntitygroupEntity));
            Assert.AreEqual("test", xml.name);
            Assert.AreEqual("0.5", xml.prob);
        }
    }
}
