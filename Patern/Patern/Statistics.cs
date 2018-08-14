using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Statistics
    {
        public int StrokeNumber { get; set; }

        public int Turn()
        {
            StrokeNumber++;
            return StrokeNumber;
        }
    }
}
