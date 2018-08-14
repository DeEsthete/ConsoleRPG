using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class EffectAddArmor : Effect
    {
        public int Armor { get; set; }

        public EffectAddArmor(int id, string name, string desc, EffectsTime effectsTime, EffectsType type) : base(id, name, desc, effectsTime, type)
        {
        }

        public override void EffectAction()
        {
            Target.Armor += Armor;
        }
    }
}
