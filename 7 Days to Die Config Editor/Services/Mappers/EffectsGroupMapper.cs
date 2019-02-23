using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Mappers
{
    public class EffectsGroupMapper : IMapper<entity_classesEntity_classEffect_group, EffectsGroup>
    {
        private IMapper<entity_classesEntity_classEffect_groupPassive_effect, PassiveEffect> _passiveEffectMapper;
        private IMapper<entity_classesEntity_classEffect_groupTriggered_effect, TriggeredEffect> _triggeredEffectMapper;

        public EffectsGroupMapper(
            IMapper<entity_classesEntity_classEffect_groupPassive_effect, PassiveEffect> passiveEffectMapper, 
            IMapper<entity_classesEntity_classEffect_groupTriggered_effect, TriggeredEffect> triggeredEffectMapper)
        {
            _passiveEffectMapper = passiveEffectMapper;
            _triggeredEffectMapper = triggeredEffectMapper;
        }

        public entity_classesEntity_classEffect_group Convert(EffectsGroup domainSource)
        {
            var xml = new entity_classesEntity_classEffect_group()
            {
                name = domainSource.Name,
                passive_effect = domainSource.PassiveEffects.Count > 0 ? domainSource.PassiveEffects.Select(p => _passiveEffectMapper.Convert(p)).ToArray() : null,
                triggered_effect = domainSource.TriggeredEffects.Count > 0 ? domainSource.TriggeredEffects.Select(t => _triggeredEffectMapper.Convert(t)).ToArray() : null
            };
            return xml;
        }

        public EffectsGroup Convert(entity_classesEntity_classEffect_group xmlSource)
        {
            var effectsGroup = new EffectsGroup(xmlSource.name);
            effectsGroup.SetPassiveEffects(xmlSource.passive_effect?.Select(p => _passiveEffectMapper.Convert(p)).ToList());
            effectsGroup.SetTriggeredEffects(xmlSource.triggered_effect?.Select(t => _triggeredEffectMapper.Convert(t)).ToList());
            return effectsGroup;
        }
    }
}
