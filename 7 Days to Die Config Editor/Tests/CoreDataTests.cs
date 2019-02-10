using System;
using System.IO;
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
            using (var fileStream = new FileStream(pathToXml, FileMode.Open))
            {
                return xmlSerializer.Deserialize(fileStream) as T;
            }
        }

        [TestMethod]
        public void entityclasses_CanDeserialize()
        {
            //Arrange
            var pathToXml = @"E:\SteamApps\steamapps\common\7 Days To Die\Data\Config\entityclasses.xml";

            //Act
            var entityClasses = Deserialize<entity_classes>(pathToXml);

            //Assert
            Assert.IsNotNull(entityClasses);
            Assert.IsTrue(entityClasses.Items.Length > 0);
        }
    }
}
