using Domain;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Mappers
{
    [TestClass]
    public class PassiveEffectMapperTests
    {
        [TestMethod]
        public void ConvertToDomain_MapsCorrectly()
        {
            //Arrange
            var passiveEffectMapper = new PassiveEffectMapper();
            var xmlSource = new entity_classesEntity_classEffect_groupPassive_effect()
            {
                match_all_tags = "true",
                name = "name",
                operation = "operation",
                tags = "tags",
                value = "value"
            };

            //Act
            var passiveEffect = passiveEffectMapper.Convert(xmlSource);

            //Assert
            Assert.IsInstanceOfType(passiveEffect, typeof(PassiveEffect));
            Assert.AreEqual("true", passiveEffect.MatchAllTags);
            Assert.AreEqual("name", passiveEffect.Name);
            Assert.AreEqual("operation", passiveEffect.Operation);
            Assert.AreEqual("tags", passiveEffect.Tags);
            Assert.AreEqual("value", passiveEffect.Value);
        }

        [TestMethod]
        public void ConvertToXml_MapsCorrectly()
        {
            //Arrange
            var passiveEffectMapper = new PassiveEffectMapper();
            var domainSource = new PassiveEffect("name")
            {
                MatchAllTags = "true",
                Operation = "operation",
                Tags = "tags",
                Value = "value"
            };

            //Act
            var xml = passiveEffectMapper.Convert(domainSource);

            //Assert
            Assert.IsInstanceOfType(xml, typeof(entity_classesEntity_classEffect_groupPassive_effect));
            Assert.AreEqual("name", xml.name);
            Assert.AreEqual("true", xml.match_all_tags);
            Assert.AreEqual("operation", xml.operation);
            Assert.AreEqual("tags", xml.tags);
            Assert.AreEqual("value", xml.value);
        }
    }
}
