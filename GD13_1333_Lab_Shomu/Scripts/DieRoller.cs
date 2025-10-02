using System;

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
