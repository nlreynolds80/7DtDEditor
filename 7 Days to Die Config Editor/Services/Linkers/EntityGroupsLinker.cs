using Domain;
using System.Linq;

namespace Services.Linkers
{
    public class EntityGroupsLinker : ILinker<EntityGroups>
    {
        public EntityGroups Link(EntityGroups target, Entities entities)
        {
            foreach(var entityGroup in target)
            {
                foreach(var subscription in entityGroup.EntitySubscriptions)
                {
                    var entity = entities.FirstOrDefault(e => e.Name == subscription.Name);
                    if (entity == null) continue;
                    subscription.SetEntity(entity);
                }
            }
            return target;
        }
    }
}
