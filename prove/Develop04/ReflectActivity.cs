public class ReflectActivity: Activity 
{

    public ReflectActivity(string title, string description, int duration) // Inheritance Constructor
        :base(title,description,duration)
        {

        }

    private List<string> _questions = new List<string>() // List of prompts to be shown to the user
    
    {

    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"

    };

    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless"

    };

    private Random _random = new Random();

    public void Reflection()
    {
        int _promptIndex = _random.Next(_prompts.Count);
        string _randomPrompt = _prompts[_promptIndex];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_randomPrompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        for ( int _number = 5; _number >= 1; _number--  )
            {
            Console.Write($"\r You may begin in: {_number} ");
            Thread.Sleep(1000);
            }
        Console.Clear();

        int _cycle = 0;

        int _interval = _duration / 5;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime && _cycle < _interval)
            {
            Console.WriteLine();
            int _questionIndex = _random.Next(_questions.Count);
            string _randomQuestion = _questions[_questionIndex];
            Console.Write($"> {_randomQuestion} ");
            Animation(5);
            Console.WriteLine();
            currentTime = DateTime.Now;
                    
            _cycle++;
            }
            Console.WriteLine();

        int extraTime = _duration % 5;
        Thread.Sleep(extraTime *1000);

    }



}