using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Points
    {
        public Points(int hitPoints, int manaPoints)
        {
            HitPoints = hitPoints;
            ManaPoints = manaPoints;
        }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }
    }
}
