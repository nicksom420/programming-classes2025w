public class Eternal:Goal
{
    public Eternal() : base("", "",0) // constructor for creating the goal
    {
        _goalType = "EternalGoal";
    }
    public Eternal(string goal, string description, int points,bool status) :base(goal,description,points) //constructor for loading the goal
    {
        _goalType = "EternalGoal";
    }

    public override void GetValues()
    {
        Console.Clear();
        Animation();
        Console.Write("What is the name of your goal? ");
        _goal = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        Console.Clear();
        Animation();

    }

    public override string FormatSave()
    {
        return $"{_goalType}:{_goal},{_description},{_points}";
    }

    public override string ToString() // formats the goal for listing
    {
        string statusSymbol = _status ? "X" : " "; // Ternary Operator

        return$"[{statusSymbol}] {Capitalize(_goal)} ({Capitalize(_description)})";
    }

    public override void UpdateStatus()
    {
        _status = false;
    }

    public override void UpdateScore()
    {
        _score = _score + _points;
        SetScore(_score);
    }

    public override void RecordEvent(Goal goal)
    {
        UpdateScore();

    }

}