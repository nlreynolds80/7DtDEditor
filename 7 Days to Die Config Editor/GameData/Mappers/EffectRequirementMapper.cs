using Domain;

namespace GameData.Mappers
{
    public class EffectRequirementMapper : IMapper<entity_classesEntity_classEffect_groupTriggered_effectRequirement, EffectRequirement>
    {
        public entity_classesEntity_classEffect_groupTriggered_effectRequirement Convert(EffectRequirement domainSource)
        {
            var xml = new entity_classesEntity_classEffect_groupTriggered_effectRequirement()
            {
                name = domainSource.Name,
                tags = domainSource.Tags
            };
            return xml;
        }

        public EffectRequirement Convert(entity_classesEntity_classEffect_groupTriggered_effectRequirement xmlSource)
        {
            var effectRequirement = new EffectRequirement(xmlSource.name)
            {
                Tags = xmlSource.tags
            };
            return effectRequirement;
        }
    }
}
