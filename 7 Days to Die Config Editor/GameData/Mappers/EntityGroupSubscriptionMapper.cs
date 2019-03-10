using Domain;
using System;

namespace GameData.Mappers
{
    public class EntityGroupSubscriptionMapper : IMapper<entitygroupsEntitygroupEntity, EntityGroupSubscription>
    {
        public entitygroupsEntitygroupEntity Convert(EntityGroupSubscription domainSource)
        {
            var xml = new entitygroupsEntitygroupEntity()
            {
                name = domainSource.Name,
                prob = domainSource.Probability
            };
            return xml;
        }

        public EntityGroupSubscription Convert(entitygroupsEntitygroupEntity xmlSource)
        {
            var entity = new Entity(xmlSource.name);
            var entityGroupSubscription = new EntityGroupSubscription(entity, xmlSource.prob);
            return entityGroupSubscription;
        }
    }
}
