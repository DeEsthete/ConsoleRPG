using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Bijuteria : Armor
    {
        public int Hp { get; set; }
        public int Mp { get; set; }
        public int Damage { get; set; }
        public double HpRegen { get; set; }
        public double MpRegen { get; set; }
        public double ExperienceGained { get; set; }

        public Bijuteria(int id, string name, Rarity rarity, string desc, int price, int protection, int hp, int mp, int damage, double hpRegen, double mpRegen, double experienceGained) : base(id, name, rarity, price, desc, protection)
        {
            Hp = hp;
            Mp = mp;
            Damage = damage;
            HpRegen = hpRegen;
            MpRegen = mpRegen;
            ExperienceGained = experienceGained;
        }
    }
}
