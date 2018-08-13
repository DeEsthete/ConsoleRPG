using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Thief : People
    {
        public Thief(int id, string name, string desc, int gold, int level, double experience, double experienceGained, double maxHp, double hp, double maxMp, double mp, double armor, double damage, double hpRegen, double mpRegen, CharacterTypeEnum characterType, Inventar inventar) : base(id, name, desc, gold, level, experience, experienceGained, maxHp, hp, maxMp, mp, armor, damage, hpRegen, mpRegen, characterType, inventar)
        {
        }
    }
}
