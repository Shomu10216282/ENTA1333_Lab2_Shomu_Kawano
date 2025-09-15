using System;

class GameManager 
{
    private int score = 0;
    private void OnPointAcquired()
    {
        score++;
        string gainedMessage = "You gained a point!";
        Console.WriteLine(gainedMessage);
    }

    public void PlayGame()
    {
        Console.WriteLine("Game Started!");
        OnPointAcquired();
        OnPointAcquired();
        OnPointAcquired();
        Console.WriteLine($"Total Score: {score}");
    }
}