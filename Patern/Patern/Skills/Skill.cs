using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Skill : Entity
    {
        public Character Owner { get; set; }
        public int MpPrice { get; set; }            //цена маны для начала кастования

        public Skill(int id, string name, string desc, int mpPrice, Character owner) : base(id, name, desc)
        {
            Owner = owner;
            MpPrice = mpPrice;
        }

        public virtual void CastSkill(Character addressee)
        {

        }
    }
}
