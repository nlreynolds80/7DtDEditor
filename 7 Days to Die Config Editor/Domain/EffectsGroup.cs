using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EffectsGroup
    {
        public string Name { get; }
        public List<PassiveEffect> PassiveEffects { get; private set; } = new List<PassiveEffect>();
        public List<TriggeredEffect> TriggeredEffects { get; private set; } = new List<TriggeredEffect>();

        public EffectsGroup(string name)
        {
            Name = name;
        }

        public void SetPassiveEffects(List<PassiveEffect> passiveEffects)
        {
            PassiveEffects = passiveEffects ?? new List<PassiveEffect>();
        }

        public void SetTriggeredEffects(List<TriggeredEffect> triggeredEffects)
        {
            TriggeredEffects = triggeredEffects ?? new List<TriggeredEffect>();
        }
    }
}
