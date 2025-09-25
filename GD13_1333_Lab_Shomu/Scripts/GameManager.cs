using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD13_1333_Lab_Shomu
{

    internal class GameManager
    {
        private Player human;
        private Player computer;

        public void Play()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Name: Shomu Kawano");

            Console.Write("Enter your name");
            string playerName = Console.ReadLine();
            human = new Player(playerName);
            computer = new Player("Computer");

            Random rand = new Random();
            bool playerFirst = rand.Next(2) == 0;

            Console.WriteLine(playerFirst
                ? $"{human.Name} goes first!"
                : $"{computer.Name} goes first!");
            Console.WriteLine();

            if (playerFirst)
            {
                HumanTurn();
                ComputerTurn();
            }
            else
            {
                ComputerTurn();
                HumanTurn();
            }

            DecideWinner();
            Console.WriteLine("Thanks for playing!");
        }

        private void HumanTurn()
        {
            Console.WriteLine($"{human.Name}'s turn!");
            Console.Write("Choose your die (enter number of sides, e.g., 6, 12, 20): ");
            int sides = int.Parse(Console.ReadLine());
            DieRoller die = new DieRoller(sides);
            human.CurrentRoll = die.Roll();
            Console.WriteLine($"{human.Name} rolled {human.CurrentRoll}.\n");
        }

        private void ComputerTurn()
        {
            Console.WriteLine("Computer's turn!");
            int sides = 6;
            DieRoller die = new DieRoller(sides);
            computer.CurrentRoll = die.Roll();
            Console.WriteLine($"Computer rolled {computer.CurrentRoll}.\n");
        }

        private void DecideWinner()
        {
            Console.WriteLine("Round Result");
            Console.WriteLine($"{human.Name}: {human.CurrentRoll}");
            Console.WriteLine($"{computer.Name}: {computer.CurrentRoll}");

            if (human.CurrentRoll > computer.CurrentRoll)
            {
                Console.WriteLine($"{human.Name} wins this round!");
                human.Points++;
            }
            else if (computer.CurrentRoll > human.CurrentRoll)
            {
                Console.WriteLine("Computer wins this round!");
                computer.Points++;
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }

            Console.WriteLine("Points => {human.Name}: {human.Points}, Computer: {computer.Points}");
        }


    }
}
