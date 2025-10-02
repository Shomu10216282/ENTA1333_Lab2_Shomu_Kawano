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

    }
}