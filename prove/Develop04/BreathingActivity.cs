using System.Dynamic;

public class BreathingActivity: Activity
{

    public BreathingActivity(string title, string description, int duration)
        :base(title, description, duration)
        {
            _duration = duration;
        }

        
    public void BreathingInterval()
    {
        int _cycle = 0;

        int _interval = _duration / 8;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime && _cycle < _interval)
            {
                BreathActivity();
                Console.WriteLine();

                currentTime = DateTime.Now;
                    
                _cycle++;
            }
        int extraTime = _duration % 8;
        Thread.Sleep(extraTime *1000);
    }

    private void BreathActivity()
    {

        for ( int _number = 4; _number >= 1; _number--  )
            {
            Console.Write($"\rBreath in... {_number} ");
            Thread.Sleep(1000);
            }

        Console.Write($"\rBreath in...    ");

        Console.WriteLine();
        

        for (int _number = 4; _number >= 1; _number--)
        {
            Console.Write($"\rBreath out... {_number}");
            Thread.Sleep(1000);
        }

        Console.Write($"\rBreath out...    ");

        Console.WriteLine();
        
    }

}