using System;
using System.Collections.Generic;
using static GD13_1333_Shomu.Scripts.Player;

namespace GD13_1333_Shomu.Scripts
{
    internal class GameManager
    {
        public void Play()
        {
            Console.WriteLine("=== Welcome to the Dice Dungeon Adventure ===");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine() ?? "Unknown"; 

            Player player = new Player(name, 20);

            Console.WriteLine($"\nWelcome, {name}! Your adventure begins.");
            DungeonManager dungeon = new DungeonManager();
            dungeon.StartDungeon(player);

            Console.WriteLine("\n=== Game Session Ended ===");
        }
    }
}
