using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Item : Entity
    {
        public Rarity Rarity { get; set; }
        public int Price { get; set; }
        public int PriceDivider { get; set; }

        public Item(int id, string name, Rarity rarity, int price, string desc) : base(id, name, desc)
        {
            PriceDivider = 2;
            Rarity = rarity;
            Price = price;
        }

        public void Sell(Character owner)
        {
            owner.Inventar.RemoveItem(Id);
            owner.Gold += Price / PriceDivider;
        }
    }
}
