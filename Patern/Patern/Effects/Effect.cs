using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Effect : Entity
    {
        public Character Target { get; set; }
        public EffectsTime TimeType { get; set; }
        public EffectsType Type { get; set; }

        public Effect(int id, string name, string desc, EffectsTime effectsTime, EffectsType type) : base(id, name, desc)
        {
            TimeType = effectsTime;
            Type = type;
        }

        public virtual void EffectAction()
        {

        }
    }
}
