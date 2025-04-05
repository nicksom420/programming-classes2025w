public class GameManager 
{

    private bool _gameRun;
    private UserInput _userInput;
    private Snake _snake; // this is an instance that also has access to snake segment since it inherits from entity
    private Map _map;
    private Food _food;
    private SnakeSegment _snakeSegment;
    private Thread _inputThread;

    private bool _collisionDetection;

    public GameManager()
    {
        _userInput = new UserInput();

        _snake = new Snake(15,7,"Up");

        _map = new Map();

        _food = new Food(0,0);

        _gameRun = true;

        _inputThread = new Thread(new ThreadStart(UserInputThread));
        _inputThread.Start();

    }

    public void UserInputThread() //might need to use lock
    {
        while(_gameRun)
        {
            string direction = _userInput.DirectionInput();
                if (!string.IsNullOrEmpty(direction))
                {
                    _snake.SetDirection(direction); 
                    Console.SetCursorPosition(40,6);
                    Console.Write(direction);

                }
                Thread.Sleep(100);

        }

    }

    public void StartLoop()
    {
        //Render the map so the game can start
        _map.RenderMap();

        _food.RandomPosition();
        _food.Render();

        // loop until collision or quit
        while(_gameRun == true)
        {
                _snake.Render();
                _snake.Move();
                _collisionDetection = _snake.Collisions();
                if( _collisionDetection == true)
                {
                    _gameRun = false;
                }
                Thread.Sleep(600);
        }

        Console.Clear();
        Console.SetCursorPosition(15,7);
        Console.Write("GameOver");
    }
}

    

