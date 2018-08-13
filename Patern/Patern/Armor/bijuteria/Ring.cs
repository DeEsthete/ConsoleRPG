using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Ring : Bijuteria
    {
        public Ring(int id, string name, Rarity rarity, string desc, int price, int protection, int hp, int mp, int damage, double hpRegen, double mpRegen, double experienceGained) : base(id, name, rarity, desc, price, protection, hp, mp, damage, hpRegen, mpRegen, experienceGained)
        {
        }
    }
}
