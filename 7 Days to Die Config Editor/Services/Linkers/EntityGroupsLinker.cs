using Domain;
using System.Linq;

namespace Services.Linkers
{
    public class EntityGroupsLinker : ILinker<EntityGroups>
    {
        private readonly EntityGroups _entityGroups;

        public EntityGroupsLinker(EntityGroups entityGroups)
        {
            _entityGroups = entityGroups;
        }

        public EntityGroups Link(Entities entities)
        {
            foreach(var entityGroup in _entityGroups)
            {
                foreach(var subscription in entityGroup.EntitySubscriptions)
                {
                    var entity = entities.FirstOrDefault(e => e.Name == subscription.Name);
                    if (entity == null) continue;
                    subscription.SetEntity(entity);
                }
            }
            return _entityGroups;
        }
    }
}
