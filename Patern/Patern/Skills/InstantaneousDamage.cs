using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    class InstantaneousDamage : Skill
    {
        public int Damage { get; set; }
        public int SuccesiveDamage { get; set; }
        public int CountMoves { get; set; }

        public InstantaneousDamage(int id, string name, string desc, int mpPrice, Character owner, Character address, int damage, int succesiveDamage, int countMoves) : base(id, name, desc, mpPrice, owner, address)
        {
            Damage = damage;
            SuccesiveDamage = succesiveDamage;
            CountMoves = countMoves;
        }

        public override void CastSkill()
        {
            if (Owner.Mp >= MpPrice)
            {
                Owner.Mp -= MpPrice;
                Address.TakeDamage(Damage);

                EffectSuccessiveDamage effect = GameDataManager.GetEffect(4002) as EffectSuccessiveDamage;
                effect.Damage = Damage;
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
