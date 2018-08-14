using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Character : Entity
    {
        #region MainField
        public int Gold { get; set; }
        public int Level { get; set; } // уровень
        public double Experience { get; set; } //опыт // как только наберется необходимое количество опыта Level++, Experience = 0
        public double ExperienceGained { get; set; } // множитель получаемого опыта
        public double MaxHp { get; set; } // максимально количество хп которое может иметь персонаж
        public double Hp { get; set; } // жизни
        public double MaxMp { get; set; } // максимально клоичество мп которое может иметь персонаж 
        public double Mp { get; set; } // мана
        public double Armor { get; set; } // общее количество брони
        public double Damage { get; set; } // общее количество урона
        public double HpRegen { get; set; } // регенерация хп раз в ход
        public double MpRegen { get; set; } // регенерация мп раз в ход
        public CharacterTypeEnum CharacterType { get; set; } // тип персонажа: игрок/дружественный/враждебный
        public Inventar Inventar { get; set; } // ивентарь привязанный к персонажу

        public List<Skill> Skills { get; set; }
        public List<Effect> Effects { get; set; }
        #endregion
        #region Equipment
        public Helmet Helmet { get; set; }
        public Breastplate Breastplate { get; set; }
        public Amulet Amulet { get; set; }
        public Weapon LeftHandWeapon { get; set; }
        public Weapon RightHandWeapon { get; set; }
        public Gloves Gloves { get; set; }
        public Ring LeftHandRing { get; set; }
        public Ring RightHandRing { get; set; }
        public Belt Belt { get; set; }
        public Shoes Shoes { get; set; }
        #endregion

        #region ctor
        public Character(int id, string name, string desc, int gold, int level, double experience, double experienceGained, double maxHp, double hp, double maxMp, double mp, double armor, double damage, double hpRegen, double mpRegen, CharacterTypeEnum characterType, Inventar inventar) : base(id, name, desc)
        {
            Gold = gold;
            Level = level;
            Experience = experience;
            ExperienceGained = experienceGained;
            MaxHp = maxHp;
            Hp = hp;
            MaxMp = maxMp;
            Mp = mp;
            Armor = armor;
            Damage = damage;
            HpRegen = hpRegen;
            MpRegen = mpRegen;
            CharacterType = characterType;
            Inventar = inventar;
        }

        public Character(int id, string name, string desc, int gold, int level, double maxHp, double hp, double maxMp, double mp, double hpRegen, double mpRegen, CharacterTypeEnum characterType, Inventar inventar) : base(id, name, desc)
        {
            Gold = gold;
            Level = level;
            MaxHp = maxHp;
            Hp = hp;
            MaxMp = maxMp;
            Mp = mp;
            HpRegen = hpRegen;
            MpRegen = mpRegen;
            CharacterType = characterType;
            Inventar = inventar;
        }
        #endregion
        #region Methods
        public void TakeDamage(double damage)
        {
            Hp -= damage;
        }
        #endregion
        #region CalculateMethods
        public void CalculateArmor()
        {
            //реализовать учет выбранного класса
            Armor += Helmet.Protection;
            Armor += Breastplate.Protection;
            Armor += Amulet.Protection;
            Armor += Gloves.Protection;
            Armor += LeftHandRing.Protection;
            Armor += RightHandRing.Protection;
            Armor += Belt.Protection;
            Armor += Shoes.Protection;
        }
        public void CalculateDamage()
        {
            //реализовать учет выбранного класса
            Damage += Amulet.Damage;
            Damage += LeftHandRing.Damage;
            Damage += RightHandRing.Damage;
            Damage += LeftHandWeapon.Damage;
            Damage += RightHandWeapon.Damage;
        }
        public void CalculateHp()
        {
            //реализовать учет выбранного класса
            MaxHp += Amulet.Hp;
            MaxHp += LeftHandRing.Hp;
            MaxHp += RightHandRing.Hp;
        }
        public void CalculateMp()
        {
            //реализовать учет выбранного класса
            MaxMp += Amulet.Mp;
            MaxMp += LeftHandRing.Mp;
            MaxMp += RightHandRing.Mp;
        }
        #endregion
    }
}
