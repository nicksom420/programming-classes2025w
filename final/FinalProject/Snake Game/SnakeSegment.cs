public class SnakeSegment: MovingEntity
{

    // Allows me to know which snake segment is the head or the body so that it can be rendered and moved accordingly
    public enum SegmentType 
    {
        Head, // shows what segment is the head
        Body // shows what segment is the body
    }

    private Snake _snake;

    private string _body;

    private string _head;

    private SegmentType Type { get; set; }

    private int _previousX;

    private int _previousY;

    public SnakeSegment(int x, int y, string direction, Snake snake, SegmentType type)
        : base(x, y, direction)
    {

        _head = "@";

        _body = "O";

        _xPosition = x;

        _yPosition = y;

        Type = type;

        _snake = snake;

    }

    public bool IsHead() => Type == SegmentType.Head;
    public bool IsBody() => Type == SegmentType.Body;

    public override void Render()
    {
        Console.SetCursorPosition(_previousX,_previousY);
        Console.Write(" ");

        Console.SetCursorPosition(_xPosition,_yPosition);
        Console.Write(Type == SegmentType.Head ? _head : _body);   
    }

    public int GetXCoord()
    {
        return _xPosition;
    }

    public int GetYCoord()
    {
        return _yPosition;
    }


    public override bool Collisions()
    {
        throw new NotImplementedException();
    }

    public override  void UpdatePosition()
    {
    
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }

    // to update the coordinate of the current segment
    public void UpdateCoordinates(string direction, int index)
    {

        _previousX = _xPosition;
        _previousY = _yPosition;

        if (Type == SegmentType.Head)
        {
            switch(direction)
            {
                case "Up":
                    _yPosition--;
                    break;
                case "Down":
                    _yPosition++;
                    break;
                case "Left":
                    _xPosition--;
                    break;
                case "Right":
                    _xPosition++;
                    break;
            }
        }
        else if (Type == SegmentType.Body)
        {
            SnakeSegment previousSegment = _snake.GetSegments()[index-1];

            _xPosition = previousSegment._previousX;
            _yPosition = previousSegment._previousY;
        }
    }   
}

