using Domain;
using System.Collections.Generic;
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
                var entitySubscriptions = new List<EntityGroupSubscription>();
                foreach(var subscription in entityGroup.EntitySubscriptions)
                {
                    var entity = entities.FirstOrDefault(e => e.Name == subscription.Name);
                    if (entity == null)
                        continue;
                    subscription.SetEntity(entity);
                    entitySubscriptions.Add(subscription);
                }
                entityGroup.SetEntitySubscriptions(entitySubscriptions);
            }
            return _entityGroups;
        }
    }
}
