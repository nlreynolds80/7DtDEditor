using Domain;
using System.Linq;

namespace GameData.Mappers
{
    public class EntityGroupsMapper : IMapper<entitygroups, EntityGroups>
    {
        private readonly IMapper<entitygroupsEntitygroup, EntityGroup> _entityGroupMapper;

        public EntityGroupsMapper(IMapper<entitygroupsEntitygroup, EntityGroup> entityGroupMapper)
        {
            _entityGroupMapper = entityGroupMapper;
        }

        public entitygroups Convert(EntityGroups domainSource)
        {
            var xml = new entitygroups()
            {
                Items = domainSource.Select(eg => _entityGroupMapper.Convert(eg)).ToArray()
            };
            return xml;
        }

        public EntityGroups Convert(entitygroups xmlSource)
        {
            var entityGroups = new EntityGroups();
            entityGroups.AddRange(xmlSource.Items.Select(eg => _entityGroupMapper.Convert(eg)));
            return entityGroups;
        }
    }
}
