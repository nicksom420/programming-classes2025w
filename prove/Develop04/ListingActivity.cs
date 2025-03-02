public class ListingActivity: Activity
{

    private Random _random = new();
    public ListingActivity(string title, string description, int duration)
        :base(title, description,duration)
        {

        }

    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"

    };

    public void Listing()
    {
        int count = 0;

        int _promptIndex = _random.Next(_prompts.Count);
        string _randomPrompt = _prompts[_promptIndex];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_randomPrompt} --- ");
        for ( int _number = 5; _number >= 1; _number--  )
            {
            Console.Write($"\r You may begin in: {_number} ");
            Thread.Sleep(1000);
            }
        Console.Write($"\r You may begin in:      ");
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Console.WriteLine();
        Console.Write("> ");

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            
            currentTime = DateTime.Now;
            ConsoleKeyInfo keyInfo = Console.ReadKey();

           if (keyInfo.Key == ConsoleKey.Enter)
           {
                count++;
                Console.WriteLine();
                Console.Write("> ");

           }
    
        }

        if (currentTime >= futureTime)
        {
            string response = Console.ReadLine(); 
            if (!string.IsNullOrWhiteSpace(response))
            {
                count++;
                if (DateTime.Now < futureTime)
                {
                    Console.Write("> ");
                }
            }
            
    }
        Console.WriteLine($"You listed {count} items!");
        Console.WriteLine();
    }

}