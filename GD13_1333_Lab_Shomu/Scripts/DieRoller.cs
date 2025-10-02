using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD13_1333_Lab_Shomu
{
    class DieRoller
    {
        private int sides;
        private Random rand = new Random();

        public DieRoller(int sides)
        {
            this.sides = sides;
        }

        public int Roll()
        {
            return rand.Next(1, sides + 1);
        }
    }
}
