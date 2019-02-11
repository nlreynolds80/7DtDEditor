using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services.Mappers;

namespace Tests
{
    [TestClass]
    public class TriggeredEffectMapperTests
    {
        private Mock<IMapper<entity_classesEntity_classEffect_groupTriggered_effectRequirement, EffectRequirement>> _effectRequirementMapper;

        [TestInitialize]
        public void Initialize()
        {
            _effectRequirementMapper = new Mock<IMapper<entity_classesEntity_classEffect_groupTriggered_effectRequirement, EffectRequirement>>();
            _effectRequirementMapper.Setup(obj => obj.Convert(It.IsAny<entity_classesEntity_classEffect_groupTriggered_effectRequirement>())).Returns(new EffectRequirement("test"));
            _effectRequirementMapper.Setup(obj => obj.Convert(It.IsAny<EffectRequirement>())).Returns(new entity_classesEntity_classEffect_groupTriggered_effectRequirement() { name = "test" });
        }

        [TestMethod]
        public void ConvertToDomain_MapsCorrectly()
        {
            //Arrange
            var triggeredEffectMapper = new TriggeredEffectMapper(_effectRequirementMapper.Object);
            var xmlSource = new entity_classesEntity_classEffect_groupTriggered_effect()
            {
                action = "action",
                buff = "buff",
                cvar = "cvar",
                @event = "event",
                operation = "operation",
                requirement = new entity_classesEntity_classEffect_groupTriggered_effectRequirement[1] { new entity_classesEntity_classEffect_groupTriggered_effectRequirement() },
                target = "target",
                trigger = "trigger",
                value = "value"
            };

            //Act
            var triggeredEffect = triggeredEffectMapper.Convert(xmlSource);

            //Assert
            Assert.IsInstanceOfType(triggeredEffect, typeof(TriggeredEffect));
            Assert.AreEqual("action", triggeredEffect.Action);
            Assert.AreEqual("buff", triggeredEffect.Buff);
            Assert.AreEqual("cvar", triggeredEffect.CVar);
            Assert.AreEqual("event", triggeredEffect.Event);
            Assert.AreEqual("operation", triggeredEffect.Operation);
            Assert.AreEqual(1, triggeredEffect.Requirements.Count);
            Assert.AreEqual("test", triggeredEffect.Requirements.First().Name);
            Assert.AreEqual("target", triggeredEffect.Target);
            Assert.AreEqual("trigger", triggeredEffect.Trigger);
            Assert.AreEqual("value", triggeredEffect.Value);
        }

        [TestMethod]
        public void ConvertToXml_MapsCorrectly()
        {
            //Arrange
            var triggeredEffectMapper = new TriggeredEffectMapper(_effectRequirementMapper.Object);
            var triggeredEffect = new TriggeredEffect()
            {
                Action = "action",
                Buff = "buff",
                CVar = "cvar",
                Event = "event",
                Operation = "operation",
                Target = "target",
                Trigger = "trigger",
                Value = "value"
            };
            triggeredEffect.SetRequirements(new List<EffectRequirement>() { new EffectRequirement("test") });

            //Act
            var xml = triggeredEffectMapper.Convert(triggeredEffect);

            //Assert
            Assert.IsInstanceOfType(xml, typeof(entity_classesEntity_classEffect_groupTriggered_effect));
            Assert.AreEqual("action", xml.action);
            Assert.AreEqual("buff", xml.buff);
            Assert.AreEqual("cvar", xml.cvar);
            Assert.AreEqual("event", xml.@event);
            Assert.AreEqual("operation", xml.operation);
            Assert.AreEqual(1, xml.requirement.Length);
            Assert.AreEqual("test", xml.requirement.First().name);
            Assert.AreEqual("target", xml.target);
            Assert.AreEqual("trigger", xml.trigger);
            Assert.AreEqual("value", xml.value);
        }
    }
}
