using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    class RemoveArmorSkill : Skill
    {
        public int Armor { get; set; }
        public int CountMoves { get; set; }
        public RemoveArmorSkill(int id, string name, string desc, int mpPrice, Character owner, Character address, int armor, int countMoves) : base(id, name, desc, mpPrice, owner, address)
        {
            Armor = armor;
            CountMoves = countMoves;
        }

        public override void CastSkill()
        {
            if (Owner.Mp >= MpPrice)
            {
                Owner.Mp -= MpPrice;
                EffectRemoveArmor effect = GameDataManager.GetEffect(4002) as EffectRemoveArmor;
                effect.Armor = Armor;
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
