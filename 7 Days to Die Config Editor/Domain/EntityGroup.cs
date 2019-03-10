using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EntityGroup
    {
        public string Name { get; }

        public List<EntityGroupSubscription> EntitySubscriptions { get; private set; } = new List<EntityGroupSubscription>();

        public EntityGroup(string name)
        {
            Name = name;
        }

        public void SetEntitySubscriptions(List<EntityGroupSubscription> entityGroupSubscriptions)
        {
            EntitySubscriptions = entityGroupSubscriptions ?? new List<EntityGroupSubscription>();
        }

        public void AddEntity(Entity entity, string probability)
        {
            if (EntitySubscriptions.Any(es => es.Entity == entity))
                throw new ArgumentException($"Entity {entity.Name} already has a subscription");

            EntitySubscriptions.Add(new EntityGroupSubscription(entity, probability));
        }

        public void RemoveEntity(Entity entity)
        {
            if (!EntitySubscriptions.Any(es => es.Entity == entity))
                throw new ArgumentException($"Entity {entity.Name} not found in subscription");

            var entityGroup = EntitySubscriptions.First(es => es.Entity == entity);
            EntitySubscriptions.Remove(entityGroup);
        }
    }
}
