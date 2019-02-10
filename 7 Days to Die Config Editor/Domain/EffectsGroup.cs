using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EffectsGroup
    {
        public List<PassiveEffect> PassiveEffects { get; set; }
        public List<TriggeredEffect> TriggeredEffects { get; set; }
    }
}
