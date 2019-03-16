using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Serializers;
using Services.Storage;

namespace Tests
{
    [TestClass]
    public class XmlSerializationServiceTests
    {

        [TestMethod]
        [TestCategory("Unit")]
        public void entityclasses_CanDeserialize()
        {
            //Arrange
            var pathToXml = @"../../TestData/entityclasses.xml";
            var xmlSerializationService = new XmlSerializationService();
            var generalFileService = new LocalFileService();

            //Act
            var xml = generalFileService.Get(pathToXml);
            var entityClasses = xmlSerializationService.Deserialize<entity_classes>(xml.Value);
            //Serialize(entityClasses, @"C:\Users\Nate\Desktop\entityclassestest.xml");

            //Assert
            Assert.IsNotNull(entityClasses);
            Assert.IsTrue(entityClasses.Items.Length > 0);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void entitygroups_CanDeserialize()
        {
            //Arrange
            var pathToXml = @"../../TestData/entitygroups.xml";
            var xmlSerializationService = new XmlSerializationService();
            var generalFileService = new LocalFileService();

            //Act
            var xml = generalFileService.Get(pathToXml);
            var entityGroups = xmlSerializationService.Deserialize<entitygroups>(xml.Value);

            //Assert
            Assert.IsNotNull(entityGroups);
            Assert.IsTrue(entityGroups.Items.Length > 0);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void gamestages_CanDeserialize()
        {
            //Arrange
            var pathToXml = @"../../TestData/gamestages.xml";
            var xmlSerializationService = new XmlSerializationService();
            var generalFileService = new LocalFileService();

            //Act
            var xml = generalFileService.Get(pathToXml);
            var gameStages = xmlSerializationService.Deserialize<gamestages>(xml.Value);

            //Assert
            Assert.IsNotNull(gameStages);
            Assert.IsTrue(gameStages.Items.Length > 0);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void spawning_CanDeserialize()
        {
            //Arrange
            var pathToXml = @"../../TestData/spawning.xml";
            var xmlSerializationService = new XmlSerializationService();
            var generalFileService = new LocalFileService();

            //Act
            var xml = generalFileService.Get(pathToXml);
            var spawning = xmlSerializationService.Deserialize<spawning>(xml.Value);

            //Assert
            Assert.IsNotNull(spawning);
            Assert.IsTrue(spawning.Items.Length > 0);
        }
    }
}
