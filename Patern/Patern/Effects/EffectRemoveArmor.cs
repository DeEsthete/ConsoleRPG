using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class EffectRemoveArmor : Effect
    {
        public int Armor { get; set; }
        public int CountMoves { get; set; }
        private int count = 0;

        public EffectRemoveArmor(int id, string name, string desc, EffectsTime effectsTime, EffectsType type) : base(id, name, desc, effectsTime, type)
        {
        }

        public override void EffectAction()
        {
            Statistics.OnNextTick += Tick;
            Target.Armor -= Armor;
        }
        public void Tick()
        {
            count++;
            if (count > CountMoves)
            {
                Statistics.OnNextTick -= Tick;
            }
        }
    }
}
