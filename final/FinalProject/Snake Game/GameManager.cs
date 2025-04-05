using System.Net.Quic;

public class GameManager 
{

    private bool _gameRun;
    private bool _quit;
    private UserInput _userInput;
    private Snake _snake; // this is an instance that also has access to snake segment since it inherits from entity
    private Map _map;
    private Food _food;
    private Thread _inputThread;
    private Score _score;
    private bool _collisionDetection;

    private bool _foodCollisionDetection;

    private bool _wallCollisionDetection;

    public GameManager()
    {
        _userInput = new UserInput();

        _snake = new Snake(15,7,"Up");

        _map = new Map();

        _food = new Food(0,0,_snake);

        _score = new Score();

        _gameRun = true;

        _inputThread = new Thread(new ThreadStart(UserInputThread));
        _inputThread.Start();

        Console.CursorVisible = false;

        _quit = false;

    }

    public void UserInputThread() 
    {
        while(_gameRun)
        {
            string direction = _userInput.DirectionInput();
                if (!string.IsNullOrEmpty(direction))
                {
                    _snake.SetDirection(direction); 

                }
                

        }

    }

    public void StartLoop()
    {   
        while (_quit == false)
        {

            _snake = new Snake(15,7,"Up");
            _inputThread = new Thread(new ThreadStart(UserInputThread));
            _inputThread.Start();

            _gameRun = true;
            Console.Clear();
            Console.SetCursorPosition(0,0);

           
            _map.RenderMap();
            _food.RandomPosition(_snake);
            _food.Render();
            _score.ResetScore();
            _score.DisplayScore(40,8);

            
            while(_gameRun == true)
            {
                
                _snake.Render();
                _snake.Move();
                _collisionDetection = _snake.Collisions();
                _foodCollisionDetection = _food.Collisions(_snake);
                _wallCollisionDetection = _map.Collisions(_snake);
                if (_collisionDetection == true)
                {
                    _gameRun = false;
                }
                if (_foodCollisionDetection == true)
                {
                    _snake.Grow();
                    _food.UpdatePosition();
                    _score.updateScore();
                    _score.DisplayScore(40,8);
                }
                if (_wallCollisionDetection == true)
                {
                    _gameRun = false;
                }
                Thread.Sleep(450);
            }

            Console.Clear();
            Console.SetCursorPosition(15,7);
            Console.Write("GameOver");
            Console.SetCursorPosition(15,8);
            Console.Write("Press Enter to restart or Esc to quit");

            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            }
            while (key != ConsoleKey.Enter && key != ConsoleKey.Escape);
            
                if (key == ConsoleKey.Escape)
                {
                    _quit = true;
                }
        }
    }

}

    

