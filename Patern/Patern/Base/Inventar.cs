using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Inventar
    {
        public static readonly int MAX_ITEMS = 9;
        public List<Item> Items { get; set; }

        public Inventar()
        {
            Items = new List<Item>();
        }

        public void ShowInventar() //вывести инвентарь на экран
        {
            Message.WriteLine("-------------Инвентарь------------");
            foreach (var item in Items)
            {
                Message.Write("Имя: ");
                Message.Write(item.Name + "   ");
                Message.Write("Редкость: ");
                Message.WriteLine(item.Rarity.ToString());
            }
            Message.WriteLine("----------------------------------");
        }

        public void AddItem(Item item) //добавить вещь
        {
            if (Items.Count <= MAX_ITEMS)
            {
                Items.Add(item);
            }
            else
            {
                Message.WriteLine("Инвентарь переполнен");
            }
        }

        public void RemoveItem(int itemId) //удалить вещь
        {
            bool isOk = false;
            foreach(var i in Items)
            {
                if (i.Id == itemId)
                {
                    Items.Remove(i);
                    isOk = true;
                }
            }
            if (!isOk)
            {
                Message.ShowWarning("Предмет не найден!");
            }
        }
    }
}
