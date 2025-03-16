using System.Formats.Asn1;

class Menu
{
    
    List<Goal> _goals = new List<Goal>();

    private int _option;

    private int _scoreDisplay;
    public int DisplayMenu(int _scoreDisplay)
    {
        Console.WriteLine(" ");
        Console.WriteLine($"You have {_scoreDisplay} points");
        Console.WriteLine(" ");

        Console.WriteLine("Menu Options:");
        Console.WriteLine("     1. Create New Goal");
        Console.WriteLine("     2. List Goals");
        Console.WriteLine("     3. Save Goals");
        Console.WriteLine("     4. Load Goals");
        Console.WriteLine("     5. Record Event");
        Console.WriteLine("     6. Quit");
        Console.Write("Select a choice from the menu: ");

        _option = int.Parse(Console.ReadLine());

        return _option;
        
    }

    public bool GetAndProcessMenuChoice(int option)
    {
        switch(_option)
        {

            case 1: //Create New Goal
                CreateGoal();

                return  true;


            case 2: // List Goals
                ListGoals();

                return  true;

                
            
            case 3: // Save Goals
                Save();

                return  true;


            case 4: // Load Goals
                Load();

                return  true;

    
            case 5: // Record Event
                RecordGoalCompletion();

                return  true;

            case 6: // Quit

                return false;


            default: // If a number not in menu is pressed

                Console.WriteLine("Please select an option between 1 and 6");

                return true;
        }
    }

    public void MenuLoop()
    {
        bool _run = true;

        while (_run == true)
        {
            _option = DisplayMenu(_scoreDisplay);

            _run = GetAndProcessMenuChoice(_option);

        }
    }


    public void CreateGoal()
    {
        Console.Clear();
        Animation();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        Console.Clear();
        Animation();

        if (choice == 1)
        {
            Simple mySimple = new Simple();
            mySimple.GetValues();
            _goals.Add(mySimple);
        }
        else if (choice == 2)
        {
            Eternal myEternal = new Eternal();
            myEternal.GetValues();
            _goals.Add(myEternal);
            
        }
        else if (choice == 3)
        {
            Checklist myChecklist = new Checklist();
            myChecklist.GetValues();
            _goals.Add(myChecklist);


        }
        Console.WriteLine("Goal has been created");
        Thread.Sleep(1000);
        Console.Clear();
        Animation();


    }

    public void ListGoals()
    {
        Console.Clear();
        Animation();
        Console.WriteLine("--------------GOALS--------------");
        int count = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal}");

            count++;
        }

        Console.WriteLine("--------------GOALS--------------");

        
    }

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
    

    public void RecordGoalCompletion()
        {
            int goalNumber;
            int count = 1;
            
            Console.Clear();
            Animation();
            Console.WriteLine("The goals are:");

            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{count}. {Capitalize(goal.GetGoalName())}");
                count++;
            }

            
            Console.Write("Which goal did you accomplish? ");
            goalNumber = int.Parse(Console.ReadLine());
            Goal goalToRecord = _goals[goalNumber - 1];
            if (goalToRecord.GetStatus() == true)
            {
                Console.WriteLine("Goal has already been completed, no points earned");
                _scoreDisplay = goalToRecord.GetScore();
            }
            else
            {
                Console.WriteLine($"Congradulations! You have earned {goalToRecord.GetPoints()} points!");
                goalToRecord.RecordEvent(goalToRecord);
                _scoreDisplay = goalToRecord.GetScore();
            }
            Console.WriteLine($"You now have {_scoreDisplay} points.");
            Thread.Sleep(2000);
            Console.Clear();
            Animation();

        }
        

    public void Save()
    {
        Eternal eternalScore = new();
        Console.Write("What is the filename for the goal file: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(eternalScore.GetScore()); 
        
            foreach (Goal goal in _goals)
            {
                string formattedGoal = goal.FormatSave();
                writer.WriteLine(formattedGoal);


            }
        }
        Console.WriteLine("Goals have been saved!");
        Thread.Sleep(2000);
        Console.Clear();
        Animation();

    }

    public void Load()
    {
        Console.Clear();
        Animation();
        string fileName;

        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                
                string line = reader.ReadLine();

                if (line != null)
                {
                    _scoreDisplay = int.Parse(line);
                }
                           
                while ((line = reader.ReadLine()) != null)
                {
                    string[] goalparts = line.Split(":");

                    string goalType = goalparts[0]; // splits "GoalType:"
                    string goalDetails = goalparts[1]; // splits "goalName,Description...."

                    if (goalType == "SimpleGoal")
                    {
                        string[] details = goalDetails.Split(','); // splits each detail by comma

                        string goalName = details[0];
                        string goalDescription = details[1];
                        int goalPoints = int.Parse(details[2]);
                        bool goalStatus = bool.Parse(details[3]);

                        Simple loadSimple = new Simple(goalName,goalDescription,goalPoints, goalStatus);
                        _goals.Add(loadSimple);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        string[] details = goalDetails.Split(',');

                        string goalName = details[0];
                        string goalDescription = details[1];
                        int goalPoints = int.Parse(details[2]);

                        Eternal loadEternal = new Eternal(goalName,goalDescription,goalPoints,false);
                        _goals.Add(loadEternal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        string[] details = goalDetails.Split(',');

                        string goalName = details[0];
                        string goalDescription = details[1];
                        int goalPoints = int.Parse(details[2]);
                        int goalBonus = int.Parse(details[3]);
                        int goalBonusRequrement = int.Parse(details[4]);
                        int goalCompletions = int.Parse(details[5]);

                        Checklist loadChecklist = new Checklist(goalName,goalDescription,goalPoints,false,goalBonus,goalBonusRequrement,goalCompletions);
                        _goals.Add(loadChecklist);
                    }
                }

            }

        }
        Console.Clear();
        Animation();

    }

    public static string Capitalize(string input)
    {
        string capitalized;

        return capitalized = input.Substring(0,1).ToUpper() + input.Substring(1).ToLower();
        
    }

}