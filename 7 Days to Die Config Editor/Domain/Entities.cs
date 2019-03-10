using System.Collections.Generic;

namespace Domain
{
    public class Entities : Dictionary<string, Entity>
    {
        public void AddRange(IEnumerable<Entity> entities)
        {
            foreach(var entity in entities)
            {
                Add(entity.Name, entity);
            }
        }
    }
}
