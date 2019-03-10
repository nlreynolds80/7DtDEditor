using System.Collections.Generic;

namespace Domain
{
    public class EntityGroups : Dictionary<string, EntityGroup>
    {
        public void AddRange(IEnumerable<EntityGroup> entityGroups)
        {
            foreach (var entityGroup in entityGroups)
            {
                Add(entityGroup.Name, entityGroup);
            }
        }
    }
}
