using Domain;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Mappers;

namespace Tests
{
    [TestClass]
    public class EffectRequirementMapperTests
    {
        [TestMethod]
        public void ConvertToDomain_MapsCorrectly()
        {
            //Arrange
            var effectRequirementMapper = new EffectRequirementMapper();
            var xmlSource = new entity_classesEntity_classEffect_groupTriggered_effectRequirement()
            {
                name = "name",
                tags = "tags"
            };

            //Act
            var effectRequirement = effectRequirementMapper.Convert(xmlSource);

            //Assert
            Assert.IsInstanceOfType(effectRequirement, typeof(EffectRequirement));
            Assert.AreEqual("name", effectRequirement.Name);
            Assert.AreEqual("tags", effectRequirement.Tags);
        }

        [TestMethod]
        public void ConvertToXml_MapsCorrectly()
        {
            //Arrange
            var effectRequirementMapper = new EffectRequirementMapper();
            var effectRequirement = new EffectRequirement("name") { Tags = "tags" };

            //Act
            var xml = effectRequirementMapper.Convert(effectRequirement);

            //Assert
            Assert.IsInstanceOfType(xml, typeof(entity_classesEntity_classEffect_groupTriggered_effectRequirement));
            Assert.AreEqual("name", xml.name);
            Assert.AreEqual("tags", xml.tags);
        }
    }
}
