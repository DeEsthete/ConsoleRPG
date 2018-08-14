using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public static class Statistics
    {
        public delegate void TickDamage();
        public static event TickDamage OnNextTick;

        public static int StrokeNumber { get; set; }
        public static CastSkill CastDel { get; set; }

        public static int Turn()
        {
            StrokeNumber++;
            OnNextTick?.Invoke();
            return StrokeNumber;
        }
    }
}
