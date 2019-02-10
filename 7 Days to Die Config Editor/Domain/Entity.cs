using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Entity
    {
        public List<Property> Properties { get; set; }
        public List<EffectsGroup> Effects { get; set; }
        public List<Drop> Drops { get; set; }
        public string Name { get; set; }
        public string Extends { get; set; }
    }
}
