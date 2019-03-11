using Domain;
using System.Linq;

namespace GameData.Mappers
{
    public class EntityGroupMapper : IMapper<entitygroupsEntitygroup, EntityGroup>
    {
        private readonly IMapper<entitygroupsEntitygroupEntity, EntityGroupSubscription> _entityGroupSubscriptionMapper;

        public EntityGroupMapper(IMapper<entitygroupsEntitygroupEntity, EntityGroupSubscription> entityGroupSubscriptionMapper)
        {
            _entityGroupSubscriptionMapper = entityGroupSubscriptionMapper;
        }

        public entitygroupsEntitygroup Convert(EntityGroup domainSource)
        {
            var xml = new entitygroupsEntitygroup()
            {
                name = domainSource.Name,
                entity = domainSource.EntitySubscriptions.Count > 0 ? domainSource.EntitySubscriptions.Select(e => _entityGroupSubscriptionMapper.Convert(e)).ToArray() : null
            };
            return xml;
        }

        public EntityGroup Convert(entitygroupsEntitygroup xmlSource)
        {
            var entityGroup = new EntityGroup(xmlSource.name);
            entityGroup.SetEntitySubscriptions(xmlSource.entity.Select(e => _entityGroupSubscriptionMapper.Convert(e)).ToList());
            return entityGroup;
        }
    }
}
