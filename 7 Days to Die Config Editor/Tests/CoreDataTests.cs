using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CoreDataTests
    {
        private T Deserialize<T>(string pathToXml) where T : class
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var xmlTextReader = new XmlTextReader(pathToXml))
            {
                return xmlSerializer.Deserialize(xmlTextReader) as T;
            }
        }

        private void Serialize<T>(T source, string path) where T : class
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var file = File.OpenWrite(path))
            {
                xmlSerializer.Serialize(file, source);
            }
        }

        [TestMethod]
        public void entityclasses_CanDeserialize()
        {
            //Arrange
            var pathToXml = @"E:\SteamApps\steamapps\common\7 Days To Die\Data\Config\entityclasses.xml";

            //Act
            var entityClasses = Deserialize<entity_classes>(pathToXml);
            Serialize(entityClasses, @"C:\Users\Nate\Desktop\entityclassestest.xml");

            //Assert
            Assert.IsNotNull(entityClasses);
            Assert.IsTrue(entityClasses.Items.Length > 0);
        }

        [TestMethod]
        public void entitygroups_CanDeserialize()
        {
            //Arrange
            var pathToXml = @"E:\SteamApps\steamapps\common\7 Days To Die\Data\Config\entitygroups.xml";

            //Act
            var entityGroups = Deserialize<entitygroups>(pathToXml);

            //Assert
            Assert.IsNotNull(entityGroups);
            Assert.IsTrue(entityGroups.Items.Length > 0);
        }

        [TestMethod]
        public void gamestages_CanDeserialize()
        {
            //Arrange
            var pathToXml = @"E:\SteamApps\steamapps\common\7 Days To Die\Data\Config\gamestages.xml";

            //Act
            var gameStages = Deserialize<gamestages>(pathToXml);

            //Assert
            Assert.IsNotNull(gameStages);
            Assert.IsTrue(gameStages.Items.Length > 0);
        }

        [TestMethod]
        public void spawning_CanDeserialize()
        {
            //Arrange
            var pathToXml = @"E:\SteamApps\steamapps\common\7 Days To Die\Data\Config\spawning.xml";

            //Act
            var spawning = Deserialize<spawning>(pathToXml);

            //Assert
            Assert.IsNotNull(spawning);
            Assert.IsTrue(spawning.Items.Length > 0);
        }
    }
}
