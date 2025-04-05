public class Food: Entity
{


    

    private string _apple;

    private Snake _snake;

    public Food(int x, int y, Snake snake) : base(x, y)
    {
        _xPosition = x;
        _yPosition = y;
        _snake = snake;


    }


    public void RandomPosition(Snake snake)
    {
        Random random = new();
        bool positionInitialize = false;

        while (!positionInitialize)
        {
            _xPosition = random.Next(1,29);
            _yPosition = random.Next(1,14);
            positionInitialize = true;
            foreach (SnakeSegment segment in snake.GetSegments())
            {
                if (_xPosition == segment.GetXCoord() && _yPosition == segment.GetYCoord())
                {
                    positionInitialize = false;
                }
            }
        }
    }

    public override void Render()
    {
        
        Console.SetCursorPosition(_xPosition,_yPosition);
        Console.Write("$");
    }

    public override void UpdatePosition()
    {
        RandomPosition(_snake);
        Render();

    }

    public  bool Collisions(Snake snake)
    {
        SnakeSegment head = snake.GetHeadSegment();

        if (head.GetXCoord() == _xPosition && head.GetYCoord() == _yPosition)
        {
            return true;
        }
        return false;
    }
}