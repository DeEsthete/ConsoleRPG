using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    class ObjectLibrary
    {
        public void Library()
        {
            //Map
            Character bandit = new Character(0, "Бандит", "Бандит грабящий всех мимо прохожих", 10, 5, 50, 50, 0, 0, 1, 0, CharacterTypeEnum.Enemy, null);

            City startCity = new City(1, 2, 3, 4, null, 1000, "Теохмор", "Стартовый город всех рас");

            FlatlandLocation flatlandLocation1 = new FlatlandLocation(2, 1000, -1, -1, null, 1, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation2 = new FlatlandLocation(3, 1, -1, -1, null, 2, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation3 = new FlatlandLocation(4, 2, -1, -1, null, 3, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation4 = new FlatlandLocation(5, 3, -1, -1, null, 4, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation5 = new FlatlandLocation(6, 4, -1, -1, null, 5, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation6 = new FlatlandLocation(7, 5, -1, -1, null, 6, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation7 = new FlatlandLocation(8, 6, -1, -1, null, 7, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation8 = new FlatlandLocation(9, 7, -1, -1, null, 8, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation9 = new FlatlandLocation(1002, 8, -1, -1, null, 9, "Равнины", "Равнины главное место обитание бандитов", bandit);
            City VillageFields1 = new City(-1, 9, -1, -1, null, 1002, "Деревня полей", "Деревушка вблизи Теохмора");

            FlatlandLocation flatlandLocation10 = new FlatlandLocation(-1, -1, 1000, 11, null, 10, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation11 = new FlatlandLocation(-1, -1, 10, 12, null, 11, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation12 = new FlatlandLocation(-1, -1, 11, 13, null, 12, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation13 = new FlatlandLocation(-1, -1, 12, 14, null, 13, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation14 = new FlatlandLocation(-1, -1, 13, 15, null, 14, "Равнины", "Равнины главное место обитание бандитов", bandit);
            FlatlandLocation flatlandLocation15 = new FlatlandLocation(-1, -1, 14, 1003, null, 15, "Равнины", "Равнины главное место обитание бандитов", bandit);
            City startOrdinLand = new City(-1, -1, 15, 71, null, 1003, "Начало земель ордена", "");

            //Weapon
            Weapon weapon = new Bow(2001, "Стартовый лук", Rarity.Common, 100, "Самый обычный лук", 14);
            Weapon weapon1 = new Bow(2002, "Лук для охоты", Rarity.Uncommon, 500, "Лук предназначенный для охоты на животных", 21);
            Weapon weapon2 = new Staff(2003, "Посох ученика", Rarity.Common, 120, "Посох предназначенный для обучения новых магов", 8);
            Weapon weapon3 = new Staff(2004, "Посох из дуба", Rarity.Uncommon, 480, "Посох изготовленный из древесины дуба, не обладает особыми качествами", 19);
            Weapon weapon4 = new Dagger(2005, "Деревянный кинжал", Rarity.Common, 110, "Кинжал изготовленный из древесины, в нынешнее время мало кем используется", 12);
            Weapon weapon5 = new Dagger(2006, "Нож плотника", Rarity.Uncommon, 560, "Нож который используют плотники для изготовления своей продукции", 24);
            Weapon weapon6 = new Rapier(2007, "Затупленная рапира", Rarity.Common, 280, "Рапира оставленная из-за не пригодности в бою", 14);
            Weapon weapon7 = new Rapier(2008, "Рапира осадных войск", Rarity.Uncommon, 690, "Рапира изготовленная в большом количестве для оснащения осадных войск империи Стэммер", 30);
            Weapon weapon8 = new Axe(2009, "Деревянный топор", Rarity.Common, 100, "Топор изготовленный из дерева, часто используется не только для рубки дерева но и бою", 10);
            Weapon weapon9 = new Axe(2010, "Каменный топор", Rarity.Uncommon, 400, "Стал известен в народе как оружие восстания эльфов, потому что именно топоры всегда были у них под рукой", 22);
            Weapon weapon10 = new Sword(2011, "Учебный мечь", Rarity.Common, 140, "Изготовлен из дерева, используется в основном для обучения", 16);
            Weapon weapon11 = new Sword(2012, "Каменный мечь", Rarity.Uncommon, 510, "Основное оружие охранны границ империи Стэммер, после восстания эльфов", 30);
            Weapon weapon12 = new Mace(2013, "Каменная булава", Rarity.Uncommon, 480, "Редко но все же используемое оружие охраников империи Стеммер", 35);
            Weapon weapon13 = new Mace(2014, "Булава брооненосца", Rarity.Rare, 1010, "Оружее используемое элитными войсками империи Стеммер именнуемыми как 'Броненосец'", 55);
            Weapon weapon14 = new Halberd(2015, "Алибарда стражника у ворот", Rarity.Uncommon, 460, "Алибарда стражников охраняющих городские ворота или важные городские месте", 30);
            Weapon weapon15 = new Halberd(2016, "Алибарда тюремщика", Rarity.Uncommon, 490, "Алибарда тюремщика", 33);
            Weapon weapon16 = new Stylet(2017, "Стилет правосудия", Rarity.Uncommon, 510, "Стилет используемый охотниками ночи для убийства обидчиков леса", 35);
            Weapon weapon17 = new Stylet(2018, "Стилет охраника леса", Rarity.Uncommon, 490, "Стилет используемый охотниками ночи для защиты леса", 30);
            Weapon weapon18 = new Spear(2019, "Копье для охоты", Rarity.Common, 210, "Копье используемое в основном людьми для охоты на разную живность леса", 15);
            Weapon weapon19 = new Spear(2020, "Копье друида", Rarity.Uncommon, 360, "копье которым пользуются друиды для более простого пермещения по лесу", 21);
        }
    }
}
