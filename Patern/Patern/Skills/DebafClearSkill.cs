using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class DebafClearSkill : Skill
    {
        public int CountMoves { get; set; }
        private int count = 0;

        public DebafClearSkill(int id, string name, string desc, int mpPrice, Character owner, Character address) : base(id, name, desc, mpPrice, owner, address)
        {
        }

        public override void CastSkill()
        {
            if (Owner.Mp >= MpPrice)
            {
                Owner.Mp -= MpPrice;

                Statistics.OnNextTick += Tick;
            }
            else
            {
                Message.ShowWarning("Не достаточно маны");
            }
        }

        public void Tick()
        {
            count++;
            if (count <= CountMoves)
            {
                for (int i = 0; i < Address.Effects.Count; i++)
                {
                    if (Address.Effects[i].Type == EffectsType.Negative)
                    {
                        Address.Effects.Remove(Address.Effects[i]);
                    }
                }
            }
            else
            {
                Statistics.OnNextTick -= Tick;
            }
        }
    }
}
