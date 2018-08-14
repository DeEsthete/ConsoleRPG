using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patern
{
    public class Game //Singleton
    {
        private static Game instance;

        private Game()
        { }

        public static Game getInstance()
        {
            if (instance == null)
                instance = new Game();
            return instance;
        }

        public List<Character> Characters { get; set; }
        public List<Item> Items { get; set; }
        public Character Player { get; set; }
        public Character Enemy { get; set; }
        public List<Location> Locations { get; set; }
        public Location CurrentLocation { get; set; }
        private string answer;

        public void GameWork()//работа самой игры
        {
            bool isWork = true;
            Message.ShowStats(Player);
            Message.ShowAction("ДОБРО ПОЖАЛОВАТЬ");
            Message.ShowEnemyStats(Enemy);
            //Message.DrawImage(CurrentLocation.Image); (НЕ РАБОТАЕТ Т.К. НЕТ БИБЛИОТЕКИ РИСУНКОВ)
            Message.CloseLine();
            Player.Damage = 20;
            while (isWork)
            {
                if (Enemy == null || Enemy.Hp <= 0)
                {
                    Enemy = new Character(0, "Бандит", "Бандит грабящий всех мимо прохожих", 10, 5, 50, 50, 0, 0, 1, 0, CharacterTypeEnum.Enemy, null);
                }
                if (!(CurrentLocation is City))
                {
                    if (CurrentLocation is MonsterLocation)
                    {
                        MonsterLocation monsterLocation = CurrentLocation as MonsterLocation;
                        Enemy = monsterLocation.Enemy;
                    }
                }
                if (Enemy != null)
                {
                    if (Enemy.Hp > 0)
                    {
                        War();
                    }
                }
                answer = Message.ReadLine();
                if (answer == "go")
                {
                    int locationId;
                    answer = Message.ReadLine();
                    if (answer == "up")
                    {
                        locationId = CurrentLocation.UpId;
                    }
                    else if (answer == "down")
                    {
                        locationId = CurrentLocation.DownId;
                    }
                    else if (answer == "left")
                    {
                        locationId = CurrentLocation.LeftId;
                    }
                    else if (answer == "right")
                    {
                        locationId = CurrentLocation.RightId;
                    }
                    else
                    {
                        Message.ShowWarning("НЕ ПРАВИЛЬНАЯ КОМАНДА!!!");
                        continue;
                    }
                    bool isComplete = false;
                    if (locationId == -1)
                    {
                        Message.ShowWarning("Туда пойти нельзя");
                        continue;
                    }
                    foreach (var i in Locations)
                    {
                        if (i.Id == locationId)
                        {
                            CurrentLocation = i;
                            isComplete = true;
                        }
                    }
                    if (isComplete == false)
                    {
                        throw new Exception("При перпеходе не найдена нужная локация!");
                    }
                }
                else if (answer == "open stock")
                {
                    if (CurrentLocation is City)
                    {
                        City city = CurrentLocation as City;
                        List<string> image = new List<string>();
                        foreach (var i in city.Stock.Items)
                        {
                            image.Add(i.Id + "-" + i.Name + " (" + i.Rarity.ToString() + ")");
                        }
                        bool stockIsWork = true;
                        while (stockIsWork)
                        {
                            answer = Message.ReadLine();
                            string[] command = answer.Split(new Char[] { ' ' });
                            int itemId = -1;
                            int itemIndex = -1;
                            try
                            {
                                int.TryParse(command[0], out itemIndex);
                                itemId = city.Stock.Items[itemIndex].Id;
                            }
                            catch
                            {
                                Message.ShowWarning("Не правильно задана комманда, команда должна быть следующего типа: 'цифра команда'");
                                continue;
                            }
                            if (command[1] == "exit")
                            {
                                stockIsWork = false;
                            }
                            else if (command[1] == "take")
                            {
                                RenderItem(city.Stock, Player.Inventar, itemId);
                            }
                            else if (command[1] == "drop")
                            {
                                city.Stock.RemoveItem(itemId);
                            }
                            else if (command[1] == "sell")
                            {
                                city.Stock.Items[itemIndex].Sell(Player);
                            }
                        }
                    }
                }
            }
        }
        public void War()
        {
            bool isWork = true;
            Message.ShowAction("БОЙ");
            Message.ShowStats(Player);
            Message.ShowEnemyStats(Enemy);
            while (isWork)
            {
                Thread.Sleep(500);
                Message.ShowAction("Защита");
                Player.TakeDamage(Enemy.Damage);
                Message.ShowStats(Player);
                answer = Message.ReadLine();
                Thread.Sleep(500);
                if (answer == "a")
                {
                    Message.ShowAction("Атака");
                    Enemy.TakeDamage(Player.Damage);
                    Message.ShowEnemyStats(Enemy);
                    if (Enemy.Hp <= 0)
                    {
                        Message.ShowAction("Победа!!!");
                        Enemy = null;
                        isWork = false;
                    }
                    Thread.Sleep(500);
                }
            }
        }

        #region Methods
        public static void RenderItem(Inventar from, Inventar to, int itemId) //передача предмета из инвентаря в инвентарь
        {
            Item item = FindItem(itemId, from);
            if (from.Items.IndexOf(item) != -1)
            {
                if (to.Items.Count < Inventar.MAX_ITEMS)
                {
                    to.AddItem(item);
                    from.RemoveItem(itemId);
                    Console.WriteLine("Обмен завершен!");
                }
                else
                {
                    Console.WriteLine("У принимателя не достаточно места!");
                }
            }
            else
            {
                Console.WriteLine("У вас нет в инвентаре этой вещи!");
            }
        }

        private static Item FindItem(int itemId, Inventar from)
        {
            foreach (var i in from.Items)
            {
                if (i.Id == itemId)
                {
                    return i;
                }
            }
            return null;
        }
        #endregion
        #region Factories
        public static Weapon FactoryWeapon(WeaponEnum type, int id, string name, Rarity rarity, int price, string desc, int damage)
        {
            switch (type)
            {
                case WeaponEnum.Bow:
                    return new Bow(id, name, rarity, price, desc, damage);
                case WeaponEnum.Staff:
                    return new Staff(id, name, rarity, price, desc, damage);
                case WeaponEnum.Dagger:
                    return new Dagger(id, name, rarity, price, desc, damage);
                case WeaponEnum.Rapier:
                    return new Rapier(id, name, rarity, price, desc, damage);
                case WeaponEnum.Axe:
                    return new Axe(id, name, rarity, price, desc, damage);
                case WeaponEnum.Sword:
                    return new Sword(id, name, rarity, price, desc, damage);
                case WeaponEnum.Mace:
                    return new Mace(id, name, rarity, price, desc, damage);
                case WeaponEnum.Halberd:
                    return new Halberd(id, name, rarity, price, desc, damage);
                case WeaponEnum.Stylet:
                    return new Stylet(id, name, rarity, price, desc, damage);
                case WeaponEnum.Spear:
                    return new Spear(id, name, rarity, price, desc, damage);
                case WeaponEnum.Dart:
                    return new Dart(id, name, rarity, price, desc, damage);
                case WeaponEnum.Saber:
                    return new Saber(id, name, rarity, price, desc, damage);
                case WeaponEnum.Tomahawk:
                    return new Tomahawk(id, name, rarity, price, desc, damage);
                default:
                    return null;
            }
        }

        public static Armor FactoryArmor(ArmorEnum type, int id, string name, Rarity rarity, int price, string desc, int protection)
        {
            switch (type)
            {
                case ArmorEnum.Helmet:
                    return new Helmet(id, name, rarity, price, desc, protection);
                case ArmorEnum.Breastplate:
                    return new Breastplate(id, name, rarity, price, desc, protection);
                case ArmorEnum.Gloves:
                    return new Gloves(id, name, rarity, price, desc, protection);
                case ArmorEnum.Shoes:
                    return new Shoes(id, name, rarity, price, desc, protection);
                case ArmorEnum.Belt:
                    return new Belt(id, name, rarity, price, desc, protection);
                default:
                    return null;
            }
        }

        public static Bijuteria FactoryBijuteria(BijuteriaEnum type, int id, string name, Rarity rarity, string desc, int price, int protection, int hp, int mp, int damage, double hpRegen, double mpRegen, double experienceGained)
        {
            switch (type)
            {
                case BijuteriaEnum.Ring:
                    return new Ring(id, name, rarity, desc, price, protection, hp, mp, damage, hpRegen, mpRegen, experienceGained);
                case BijuteriaEnum.Amulet:
                    return new Amulet(id, name, rarity, desc, price, protection, hp, mp, damage, hpRegen, mpRegen, experienceGained);
                default:
                    return null;
            }
        }
        #endregion
    }
}