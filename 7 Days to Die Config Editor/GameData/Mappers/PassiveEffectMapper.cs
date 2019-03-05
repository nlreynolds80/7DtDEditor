using Domain;

namespace GameData.Mappers
{
    public class PassiveEffectMapper : IMapper<entity_classesEntity_classEffect_groupPassive_effect, PassiveEffect>
    {
        public entity_classesEntity_classEffect_groupPassive_effect Convert(PassiveEffect domainSource)
        {
            var xml = new entity_classesEntity_classEffect_groupPassive_effect()
            {
                match_all_tags = domainSource.MatchAllTags,
                name = domainSource.Name,
                operation = domainSource.Operation,
                tags = domainSource.Tags,
                value = domainSource.Value
            };
            return xml;
        }

        public PassiveEffect Convert(entity_classesEntity_classEffect_groupPassive_effect xmlSource)
        {
            var passiveEffect = new PassiveEffect(xmlSource.name)
            {
                MatchAllTags = xmlSource.match_all_tags,
                Operation = xmlSource.operation,
                Tags = xmlSource.tags,
                Value = xmlSource.value
            };
            return passiveEffect;
        }
    }
}
