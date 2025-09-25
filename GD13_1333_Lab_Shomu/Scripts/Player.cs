using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD13_1333_Lab_Shomu
{
    internal class Player
    {
        public string Name { get; private set; }
        public int CurrentRoll { get; set; }
        public int Points { get; set; }

        public Player(string name)
        {
            Name = name;
            CurrentRoll = 0;
            Points = 0;
        }
    }
}
