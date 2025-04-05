using System.Diagnostics.Contracts;

public class Score 
{
    private int _userScore;

    public Score()
    {
        _userScore = 0;
    }

    public void updateScore()
    {
        _userScore += 100;
    }

    public void ResetScore()
    {
        _userScore = 0;
    }

    public void DisplayScore(int x, int y)
    {
        Console.SetCursorPosition(x,y);
        Console.Write($"Score: {_userScore}");
    }

}