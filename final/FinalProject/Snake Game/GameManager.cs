public class GameManager 
{

    private bool _gameRun;

    private UserInput _userInput;
    private Snake _snake; // this is an instance that also has access to snake segment since it inherits from entity
    private Map _map;

    public GameManager()
    {
        _userInput = new UserInput();

        _snake = new Snake();

        _map = new Map();

        _gameRun = true;

    }

    public void StartLoop()
    {
        //Render the map so the game can start
        _map.RenderMap();

        // loop until collision or quit
        while(_gameRun == true)
        {
            



        }



    }

    

}