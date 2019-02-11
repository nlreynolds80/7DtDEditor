using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EffectRequirement
    {
        public string Name { get; }
        public string Tags { get; set; }

        public EffectRequirement(string name)
        {
            Name = name;
        }
    }
}
