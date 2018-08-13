using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Location : Entity
    {
        public int UpId { get; set; }
        public int DownId { get; set; }
        public int LeftId { get; set; }
        public int RightId { get; set; }
        public List<string> Image { get; set; }

        public Location(int up, int down, int left, int right, List<string> image, int id, string name, string desc) : base(id, name, desc)
        {
            //if (image.Count != 10)
            //{
            //    throw new Exception("Не правильно задан image");
            //}
            //else
            //{
            //    foreach(var i in image)
            //    {
            //        if (i.Count() != 16)
            //        {
            //            throw new Exception("Не правильно задан image");
            //        }
            //    }
            //}
            UpId = up;
            DownId = down;
            LeftId = left;
            RightId = right;
            Image = image;
        }
    }
}
