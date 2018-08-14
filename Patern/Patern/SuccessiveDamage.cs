using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class SuccessiveDamage : Skill
    {
        public int Damage { get; set; }
        public int CountMoves { get; set; }
        public int MpExpendinture { get; set; }

        public SuccessiveDamage(int id, string name, string desc, int mpPrice, int mpExpenditure, Character owner, int damage, int countMoves) : base(id, name, desc, mpPrice, owner)
        {
            Damage = damage;
            CountMoves = countMoves;
            MpExpendinture = mpExpenditure;
        }

        public override void CastSkill(Character addressee)
        {
            if (Owner.Mp >= MpPrice)
            {
                Owner.Mp -= MpPrice;
                TickDamage();
            }
            else
            {
                Message.ShowWarning("Не достаточно маны");
            }
        }

        public void TickDamage()
        {

        }
    }
}
