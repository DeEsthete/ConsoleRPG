using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class City : Location
    {
        public Inventar Stock { get; set; }

        public City(int up, int down, int left, int right, List<string> image, int id, string name, string desc) : base(up, down, left, right, image, id, name, desc)
        {
            image = new List<string>();
            Stock = new Inventar();
            throw new Exception("No image" + "City");
        }
    }
}
