using System;

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

        //Lab3
        //int d6 = rand.Next(1, 7);   
        //int d8 = rand.Next(1, 9);   
        //int d12 = rand.Next(1, 13); 
        //int d20 = rand.Next(1, 21); 
        //Console.WriteLine("Rolling dice...");
        //Console.WriteLine($"d6:  {d6}");
        //Console.WriteLine($"d8:  {d8}");
        //Console.WriteLine($"d12: {d12}");
        //Console.WriteLine($"d20: {d20}");
        //return d6 + d8 + d12 + d20;
    }
}