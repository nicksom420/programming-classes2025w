using System.Diagnostics.Contracts;

public class Checklist: Goal
{

    private int _bonus;
    private int _bonusRequirement;
    private int _completions;

    public Checklist() :base("","",0,false) // default constructor to set values and make a goal
    {
        _goalType = "ChecklistGoal";
        _completions = 0;
    }

    public Checklist(string goal, string description, int points, bool status, int bonus, int bonusRequirement, int completions)
        :base(goal,description,points) // second constructor for when the goal is loaded from the file
    {
        _goalType = "ChecklistGoal";
        _goal = goal;
        _description = description;
        _points = points;
        _bonusRequirement = bonusRequirement;
        _completions = completions;
        _status = status;
        _bonus = bonus;
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
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _bonusRequirement = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
        Console.Clear();
        Animation();

    }

    public override string FormatSave()
    {
        return $"{_goalType}:{_goal},{_description},{_points},{_bonus},{_bonusRequirement},{_completions}";
    }

    public override string ToString() // formats the goal for listing
    {
        if (_completions == _bonusRequirement)
        {
            _status = true;
        }
        string statusSymbol = _status ? "X" : " "; // Ternary Operator

        return$"[{statusSymbol}] {Capitalize(_goal)} ({Capitalize(_description)}) -- Currently completed: {_completions}/{_bonusRequirement}";
    }

    public override void UpdateStatus()
    {
        _status = true;
    }

    public override void RecordEvent(Goal goal)
    {

        if (_status == true)
        {
            Console.WriteLine("Goal has already been completed");
            
        }
        else
        {
            UpdateScore();
        }
        if (_completions == _bonusRequirement)
            {
                UpdateStatus();
            }
    }

    public override void UpdateScore()
    {
        if (_completions != _bonusRequirement)
        {
            _score = _score + _points;
            _completions++;
            if (_completions == _bonusRequirement)
            {
                _score += _bonus;
            }
        }
    }
}