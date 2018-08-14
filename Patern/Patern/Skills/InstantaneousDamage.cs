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

        public InstantaneousDamage(int id, string name, string desc, int mpPrice, Character owner, Character address, int damage) : base(id, name, desc, mpPrice, owner, address)
        {
            Damage = damage;
        }

        public override void CastSkill()
        {
            if (Owner.Mp >= MpPrice)
            {
                Owner.Mp -= MpPrice;
                Address.TakeDamage(Damage);
            }
            else
            {
                Message.ShowWarning("Не достаточно маны");
            }
        }
    }
}
