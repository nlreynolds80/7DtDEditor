using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Entity
    {
        public string Name { get; }
        public string Extends { get; set; }
        public List<Property> Properties { get; private set; } = new List<Property>();
        public List<EffectsGroup> Effects { get; private set; } = new List<EffectsGroup>();
        public List<Drop> Drops { get; private set; } = new List<Drop>();

        public Entity(string name)
        {
            Name = name;
        }

        public void SetDrops(List<Drop> drops)
        {
            Drops = drops ?? new List<Drop>();
        }

        public void SetEffects(List<EffectsGroup> effects)
        {
            Effects = effects ?? new List<EffectsGroup>();
        }

        public void SetProperties(List<Property> properties)
        {
            Properties = properties ?? new List<Property>();
        }
    }
}
