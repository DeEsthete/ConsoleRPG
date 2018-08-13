using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class MonsterLocation : Location
    {
        public Character Enemy { get; private set; }
        public MonsterLocation(int up, int down, int left, int right, List<string> image, int id, string name, string desc, Character enemy) : base(up, down, left, right, image, id, name, desc)
        {
            Enemy = enemy;
        }
    }
}
