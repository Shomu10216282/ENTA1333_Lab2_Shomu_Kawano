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
        public List<int> Dice { get; private set; }
        public List<int> Rolls { get; private set; }
        public int EvenCount { get; private set; }
        public int OddCount { get; private set; }

        public Player(string name, List<int> diceSet)
        {
            Name = name;
            Points = 0;
            Dice = new List<int>(diceSet);
            Rolls = new List<int>();
            EvenCount = 0;
            OddCount = 0;
        }
        public bool HasDice()
        {
            return Dice.Count > 0;
        }

        public bool UseDie(int sides)
        {
            if (Dice.Contains(sides))
            {
                Dice.Remove(sides);
                return true;
            }
            return false;
        }


        public void RecordRoll(int value)
        {
            Rolls.Add(value);
            if (value % 2 == 0) EvenCount++;
            else OddCount++;
        }

        public int TotalRoll()
        {
            int sum = 0;
            foreach (int r in Rolls) sum += r;
            return sum;
        }

        public double AverageRoll()
        {
            if (Rolls.Count == 0) return 0;
            return (double)TotalRoll() / Rolls.Count;
        }
    }

    internal class ComputerPlayer : Player
    {
        private Random rand = new Random();

        public ComputerPlayer(string name, List<int> diceSet) : base(name, diceSet) { }

        public int ChooseDie()
        {
            List<int> dice = Dice;
            int index = rand.Next(dice.Count);
            int choice = dice[index];
            UseDie(choice);
            return choice;
        }

    }
}
