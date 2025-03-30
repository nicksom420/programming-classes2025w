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


    public string GetKeyPress()
    {
        
        ConsoleKeyInfo keyInfo = Console.ReadKey(true); 
        
       
        return keyInfo.Key.ToString();
    }

    public void Pause()
    {
        
    }

    public void Resume()
    {


    }



}