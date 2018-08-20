using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    class EffectSleep : Effect
    {
        public int CountMoves { get; set; }
        public int count = 0;
        public EffectSleep(int id, string name, string desc, EffectsTime effectsTime, EffectsType type) : base(id, name, desc, effectsTime, type)
        {
        }

        public override void EffectAction()
        {
            Statistics.OnNextTick += Tick;
        }

        public void Tick()
        {
            count++;
            if (count <= CountMoves)
            {
                Target.inTheMind = false;
            }
            else
            {
                Target.inTheMind = true;
                Statistics.OnNextTick -= Tick;
            }
        }
    }
}
