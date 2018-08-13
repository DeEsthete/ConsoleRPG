using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Entity
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        public string Description { get; set; }
        public string Name { get; set; }

        public Entity(int id, string name, string desc)
        {
            Description = desc;
        }
    }
}
