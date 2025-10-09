using System;

namespace GD13_1333_Shomu.Scripts
{
    internal class Map
    {
        private Room[,] rooms;
        private int playerX;
        private int playerY;
        private Random rnd = new Random();

        public Map()
        {
            rooms = new Room[3, 3];
            GenerateMap();
            playerX = 1;
            playerY = 1; 
        }

        private void GenerateMap()
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    int r = rnd.Next(3);
                    if (r == 0)
                        rooms[y, x] = new NormalRoom();
                    else if (r == 1)
                        rooms[y, x] = new TreasureRoom();
                    else
                        rooms[y, x] = new EncounterRoom();
                }
            }
        }

        public Room GetCurrentRoom() => rooms[playerY, playerX];

        public void Move(string direction)
        {
            switch (direction.ToLower())
            {
                case "n":
                    if (playerY > 0) playerY--; else Console.WriteLine("You can't go further north.");
                    break;
                case "s":
                    if (playerY < 2) playerY++; else Console.WriteLine("You can't go further south.");
                    break;
                case "e":
                    if (playerX < 2) playerX++; else Console.WriteLine("You can't go further east.");
                    break;
                case "w":
                    if (playerX > 0) playerX--; else Console.WriteLine("You can't go further west.");
                    break;
                default:
                    Console.WriteLine("Invalid direction.");
                    break;
            }
        }
    }
}
