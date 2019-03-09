using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
