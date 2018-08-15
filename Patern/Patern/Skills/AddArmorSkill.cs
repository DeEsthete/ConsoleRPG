using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class AddArmorSkill : Skill
    {
        public int Armor { get; set; }

        public AddArmorSkill(int id, string name, string desc, int mpPrice, Character owner, Character address, int armor) : base(id, name, desc, mpPrice, owner, address)
        {
            Armor = armor;
        }

        public override void CastSkill()
        {
            if (Owner.Mp >= MpPrice)
            {
                Owner.Mp -= MpPrice;
                EffectAddArmor effect = GameDataManager.GetEffect(4000) as EffectAddArmor;
                effect.Armor = Armor;
                Address.Effects.Add(effect);
            }
            else
            {
                Message.ShowWarning("Не достаточно маны");
            }
        }
    }
}
