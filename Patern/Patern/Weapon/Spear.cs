﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Spear : Weapon
    {
        public Spear(int id, string name, Rarity rarity, int price, string desc, int damage) : base(id, name, rarity, price, desc, damage)
        {
        }
    }
}
