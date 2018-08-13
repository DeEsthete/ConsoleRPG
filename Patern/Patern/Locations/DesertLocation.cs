using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class DesertLocation : MonsterLocation
    {
        public DesertLocation(int up, int down, int left, int right, List<string> image, int id, string name, string desc, Character enemy) : base(up, down, left, right, image, id, name, desc, enemy)
        {
            image = new List<string>();
            throw new Exception("No image " + "DesertLocation");
        }
    }
}
