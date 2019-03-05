using Domain;
using System.Linq;

namespace GameData.Mappers
{
    public class TriggeredEffectMapper : IMapper<entity_classesEntity_classEffect_groupTriggered_effect, TriggeredEffect>
    {
        private IMapper<entity_classesEntity_classEffect_groupTriggered_effectRequirement, EffectRequirement> _effectRequirementMapper;

        public TriggeredEffectMapper(IMapper<entity_classesEntity_classEffect_groupTriggered_effectRequirement, EffectRequirement> effectRequirementMapper)
        {
            _effectRequirementMapper = effectRequirementMapper;
        }

        public entity_classesEntity_classEffect_groupTriggered_effect Convert(TriggeredEffect domainSource)
        {
            var xml = new entity_classesEntity_classEffect_groupTriggered_effect()
            {
                action = domainSource.Action,
                buff = domainSource.Buff,
                cvar = domainSource.CVar,
                @event = domainSource.Event,
                operation = domainSource.Operation,
                requirement = domainSource.Requirements.Count > 0 ? domainSource.Requirements.Select(r => _effectRequirementMapper.Convert(r)).ToArray() : null,
                target = domainSource.Target,
                trigger = domainSource.Trigger,
                value = domainSource.Value
            };
            return xml;
        }

        public TriggeredEffect Convert(entity_classesEntity_classEffect_groupTriggered_effect xmlSource)
        {
            var triggeredEffect = new TriggeredEffect()
            {
                Action = xmlSource.action,
                Buff = xmlSource.buff,
                CVar = xmlSource.cvar,
                Event = xmlSource.@event,
                Operation = xmlSource.operation,
                Target = xmlSource.target,
                Trigger = xmlSource.trigger,
                Value = xmlSource.value
            };
            triggeredEffect.SetRequirements(xmlSource.requirement?.Select(r => _effectRequirementMapper.Convert(r)).ToList());
            return triggeredEffect;
        }
    }
}
