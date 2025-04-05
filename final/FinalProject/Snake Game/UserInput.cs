public class UserInput 
{

    private string _up;

    private string _down;

    private string _left;

    private string _right;

    

    public UserInput()
    {
        _up = "Up";

        _down = "Down";

        _left = "Left";

        _right = "Right";

    }

    public string DirectionInput()
    {

        
        {
            ConsoleKey key = Console.ReadKey(true).Key;
        
            switch (key)
            {
                case ConsoleKey.W: return _up;
                case ConsoleKey.S: return _down;
                case ConsoleKey.A: return _left;
                case ConsoleKey.D: return _right;
            }
        }
        return null;



    }

    public void Pause()
    {
        
    }

    public void Resume()
    {


    }



}