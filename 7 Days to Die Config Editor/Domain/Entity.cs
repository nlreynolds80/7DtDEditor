using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Entity
    {
        public string Name { get; set; }
        public string Extends { get; set; }
        public List<Property> Properties { get; set; } = new List<Property>();
        public List<EffectsGroup> Effects { get; set; } = new List<EffectsGroup>();
        public List<Drop> Drops { get; set; } = new List<Drop>();
    }
}
