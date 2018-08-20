using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    class SleepSkill : Skill
    {
        public int CountMoves { get; set; }
        public SleepSkill(int id, string name, string desc, int mpPrice, Character owner, Character address, int countMoves) : base(id, name, desc, mpPrice, owner, address)
        {
            CountMoves = countMoves;
        }

        public override void CastSkill()
        {
            if (Owner.Mp >= MpPrice)
            {
                Owner.Mp -= MpPrice;
                EffectSleep effect = GameDataManager.GetEffect(4003) as EffectSleep;
                effect.CountMoves = CountMoves;

                effect.EffectAction();
                Address.Effects.Add(effect);
            }
            else
            {
                Message.ShowWarning("Не достаточно маны");
            }
        }
    }
}
