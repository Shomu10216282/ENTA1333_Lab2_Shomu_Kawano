using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD13_1333_Lab1_Kawano_Shomu
{
    internal class GameManager
    {
        public void Play()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Name: Shomu Kawano");


            DieRoller roller = new DieRoller();
            int total = roller.Roll();


            Console.WriteLine("Total Score: " + total);

        }
    }
}