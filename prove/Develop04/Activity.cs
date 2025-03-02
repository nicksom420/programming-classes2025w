public class Activity
{

    private string _title;

    private string _description;

    protected int _duration;

    private int _animationDuration;

    public Activity(string title, string description,  int duration)
    {
        _title = title;

        _description = description;

        _duration = duration;

    }

    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like this exersize to last? ");
        _duration = int.Parse(Console.ReadLine());

        return _duration;
    }

    public void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_title}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        
    }

    public void DisplayGoodbye()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_title}");
    }

        public void ActivityOutline(Activity instance)
    {



        instance.DisplayWelcome(); 
        Console.WriteLine();
        instance.GetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        instance.Animation(3);
        
        if (instance is BreathingActivity breathingActivity)
        {
            breathingActivity.BreathingInterval(); 

        }
        if (instance is ReflectActivity reflectActivity)
        {
            reflectActivity.Reflection();
        }
        if (instance is ListingActivity listingActivity)
        {
            listingActivity.Listing();
        }
        Console.WriteLine("Well Done!!!");
        instance.Animation(3);
        Console.WriteLine();
        instance.DisplayGoodbye();
        instance.Animation(3);
        Console.Clear();

    }

            public void Animation(int duration)
    {
        _animationDuration = duration;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_animationDuration);

        while (DateTime.Now < futureTime)
        {
            
            Console.Write(".");
            Thread.Sleep(500);  

            
            Console.Write("\b \b");
            Console.Write("o");
            Thread.Sleep(500);

         
            Console.Write("\b \b");
            Console.Write("O");
            Thread.Sleep(500);

            
            Console.Write("\b \b");
            Console.Write("o");
            Thread.Sleep(500);

            
            Console.Write("\b \b");
            Console.Write(".");
            Thread.Sleep(500);

            
            Console.Write("\b \b");
        }
    }


}