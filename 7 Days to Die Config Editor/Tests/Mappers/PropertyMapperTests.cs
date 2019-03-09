using Domain;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Tests.Mappers
{
    [TestClass]
    public class PropertyMapperTests
    {
        [TestMethod]
        public void CovertToDomain_MapsCorrectly()
        {
            //Arrange
            var propertyMapper = new PropertyMapper();
            var xmlSource = new property()
            {
                @class = "class",
                name = "name",
                param1 = "param",
                value = "value",
                property1 = new property[1] { new property() { name = "subname" } }
            };

            //Act
            var domainProperty = propertyMapper.Convert(xmlSource);

            //Assert
            Assert.IsInstanceOfType(domainProperty, typeof(Property));
            Assert.AreEqual("class", domainProperty.Class);
            Assert.AreEqual("name", domainProperty.Name);
            Assert.AreEqual("param", domainProperty.Param);
            Assert.AreEqual("value", domainProperty.Value);
            Assert.AreEqual(1, domainProperty.Properties.Count);
            Assert.AreEqual("subname", domainProperty.Properties.First().Name);
        }

        [TestMethod]
        public void ConvertToXml_MapsCorrectly()
        {
            //Arrange
            var propertyMapper = new PropertyMapper();
            var domainSource = new Property("name")
            {
                Class = "class",
                Param = "param",
                Value = "value"
            };
            domainSource.SetProperties(new List<Property>() { new Property("subname") });

            //Act
            var xmlProperty = propertyMapper.Convert(domainSource);

            //Assert
            Assert.IsInstanceOfType(xmlProperty, typeof(property));
            Assert.AreEqual("class", xmlProperty.@class);
            Assert.AreEqual("name", xmlProperty.name);
            Assert.AreEqual("param", xmlProperty.param1);
            Assert.AreEqual("value", xmlProperty.value);
            Assert.AreEqual(1, xmlProperty.property1.Length);
            Assert.AreEqual("subname", xmlProperty.property1.First().name);
        }
    }
}
