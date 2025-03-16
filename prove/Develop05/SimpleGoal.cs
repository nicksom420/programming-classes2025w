using System.Diagnostics.Contracts;

public class Simple: Goal
{

    public Simple() :base("","",0,false) // Constructor for creating the goal
    {
        _goalType = "SimpleGoal";
    }
    public Simple(string goal, string description, int points, bool status) 
        :base(goal,description,points,status) // Constructor loading the goal
    {
        _goalType = "SimpleGoal";
        _goal = goal;
        _description = description;
        _points = points;
        _status = status;
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
        return $"{_goalType}:{_goal},{_description},{_points},{_status}";
    }

    


    public override string ToString() // formats the goal for listing
    {
        string statusSymbol = _status ? "X" : " "; // Ternary Operator

        return$"[{statusSymbol}] {Capitalize(_goal)} ({Capitalize(_description)})";
    }

    public override void UpdateStatus()
    {
        _status = true;
    }

    public override void UpdateScore()
    {
        _score = _score + _points;
    }

    public override void RecordEvent(Goal goal)
    {
        
        if (goal.GetStatus() == true)
        {
            Console.WriteLine("Simple goal has already been completed");
        }
        else
        {
        goal.UpdateStatus();
        UpdateScore();

        }
    }
}