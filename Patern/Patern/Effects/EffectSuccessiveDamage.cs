using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    class EffectSuccessiveDamage : Effect
    {
        public int Damage { get; set; }
        public int CountMoves { get; set; }

        public EffectSuccessiveDamage(int id, string name, string desc, EffectsTime effectsTime, EffectsType type, int countMoves) : base(id, name, desc, effectsTime, type)
        {
        }

        public override void EffectAction()
        {
            Statistics.OnNextTick += TickDamage;
        }

        public void TickDamage()
        {
            int count = 0;
            count++;
            if (count != CountMoves)
            {
                Target.TakeDamage(Damage);
            }
            else
            {
                Statistics.OnNextTick -= TickDamage;
            }
        }
    }
}
