using Domain;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace Tests.Mappers
{
    [TestClass]
    public class EffectsGroupMapper_Tests
    {
        private Mock<IMapper<entity_classesEntity_classEffect_groupPassive_effect, PassiveEffect>> _passiveEffectMapper;
        private Mock<IMapper<entity_classesEntity_classEffect_groupTriggered_effect, TriggeredEffect>> _triggeredEffectMapper;

        [TestInitialize]
        public void Initialize()
        {
            _passiveEffectMapper = new Mock<IMapper<entity_classesEntity_classEffect_groupPassive_effect, PassiveEffect>>();
            _passiveEffectMapper.Setup(obj => obj.Convert(It.IsAny<entity_classesEntity_classEffect_groupPassive_effect>())).Returns(new PassiveEffect("passive"));
            _passiveEffectMapper.Setup(obj => obj.Convert(It.IsAny<PassiveEffect>())).Returns(new entity_classesEntity_classEffect_groupPassive_effect() { name = "passive" });

            _triggeredEffectMapper = new Mock<IMapper<entity_classesEntity_classEffect_groupTriggered_effect, TriggeredEffect>>();
            _triggeredEffectMapper.Setup(obj => obj.Convert(It.IsAny<entity_classesEntity_classEffect_groupTriggered_effect>())).Returns(new TriggeredEffect() { Trigger = "trigger" });
            _triggeredEffectMapper.Setup(obj => obj.Convert(It.IsAny<TriggeredEffect>())).Returns(new entity_classesEntity_classEffect_groupTriggered_effect() { trigger = "trigger" });
        }

        [TestMethod]
        public void ConvertToDomain_MapsCorrectly()
        {
            //Arrange
            var effectsGroupMapper = new EffectsGroupMapper(_passiveEffectMapper.Object, _triggeredEffectMapper.Object);
            var xmlSource = new entity_classesEntity_classEffect_group()
            {
                name = "test",
                passive_effect = new entity_classesEntity_classEffect_groupPassive_effect[1] { new entity_classesEntity_classEffect_groupPassive_effect() },
                triggered_effect = new entity_classesEntity_classEffect_groupTriggered_effect[1] { new entity_classesEntity_classEffect_groupTriggered_effect() }
            };

            //Act
            var effectsGroup = effectsGroupMapper.Convert(xmlSource);

            //Assert
            Assert.IsInstanceOfType(effectsGroup, typeof(EffectsGroup));
            Assert.AreEqual("test", effectsGroup.Name);
            Assert.AreEqual(1, effectsGroup.PassiveEffects.Count);
            Assert.AreEqual(1, effectsGroup.TriggeredEffects.Count);
            Assert.AreEqual("passive", effectsGroup.PassiveEffects.First().Name);
            Assert.AreEqual("trigger", effectsGroup.TriggeredEffects.First().Trigger);
        }

        [TestMethod]
        public void ConvertToXml_MapsCorrectly()
        {
            //Arrange
            var effectsGroupMapper = new EffectsGroupMapper(_passiveEffectMapper.Object, _triggeredEffectMapper.Object);
            var effectsGroup = new EffectsGroup("test");
            effectsGroup.SetPassiveEffects(new List<PassiveEffect>() { new PassiveEffect("passive") });
            effectsGroup.SetTriggeredEffects(new List<TriggeredEffect>() { new TriggeredEffect() { Trigger = "trigger" } });

            //Act
            var xml = effectsGroupMapper.Convert(effectsGroup);

            //Assert
            Assert.IsInstanceOfType(xml, typeof(entity_classesEntity_classEffect_group));
            Assert.AreEqual("test", xml.name);
            Assert.AreEqual(1, xml.passive_effect.Length);
            Assert.AreEqual(1, xml.triggered_effect.Length);
            Assert.AreEqual("passive", xml.passive_effect.First().name);
            Assert.AreEqual("trigger", xml.triggered_effect.First().trigger);
        }
    }
}
