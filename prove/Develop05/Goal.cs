public abstract class Goal
{

    protected string _goalType;

    protected string _goal;

    public string GetGoalName()
    {
        return _goal;
    }

    public void SetGoalName(string value)
    {
        _goal = value;
    }

    protected string _description;

    protected int _points;

    public int GetPoints()
    {
        return _points;
    }

    protected static int _score;

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int value)
    {
        _score = value;
    }

    protected bool _status;

    public bool GetStatus()
    {
        return _status; 
    }


    public Goal(string goal, string description, int points, bool status)
    {
        _goal = goal;

        _description = description;

        _points = points;

        _status = status;

    }

    public Goal(string goal, string description, int points) // contructor for eternal class since it doesn't have a status
        :this(goal, description,points,false)
        {

        }
 
    abstract public void GetValues();
    
    public abstract string FormatSave();

    public abstract void RecordEvent(Goal goal);

    public abstract void UpdateStatus();

    public abstract void UpdateScore();
    
    public void Animation()
    {
            Console.Write(".");
            Thread.Sleep(250);  

            
            Console.Write("\b \b");
            Console.Write("o");
            Thread.Sleep(250);

         
            Console.Write("\b \b");
            Console.Write("O");
            Thread.Sleep(250);

            
            Console.Write("\b \b");
            Console.Write("o");
            Thread.Sleep(250);

            
            Console.Write("\b \b");
            Console.Write(".");
            Thread.Sleep(250);

            
            Console.Write("\b \b");
        
    }

    public static string Capitalize(string input)
    {
        string capitalized;

        return capitalized = input.Substring(0,1).ToUpper() + input.Substring(1).ToLower();
        
    }

}