public class Snake: MovingEntity
{
    private List<SnakeSegment> _segments = new(); 

    private string _direction;

    private UserInput _input;

    public Snake(int startX, int startY, string direction) : base(startX, startY, direction) 
    {
        _direction = direction;

        _segments.Add(new SnakeSegment(startX, startY, direction, this, SnakeSegment.SegmentType.Head));
        _segments.Add(new SnakeSegment(startX,startY+1,"", this, SnakeSegment.SegmentType.Body));
        _segments.Add(new SnakeSegment(startX,startY+2,"", this, SnakeSegment.SegmentType.Body));
        _segments.Add(new SnakeSegment(startX,startY+3,"", this, SnakeSegment.SegmentType.Body));
        _segments.Add(new SnakeSegment(startX,startY+4,"", this, SnakeSegment.SegmentType.Body));
        

    }

    public List<SnakeSegment> GetSegments()
    {
        return _segments;
    }


    public SnakeSegment GetHeadSegment()
    {
        foreach (SnakeSegment segment in _segments)
        {
            if (segment.IsHead())
            {
                return segment;

            }
        }
        return null;
    }

    

    public string GetDirection()
    {
        return _direction;
    }

    public void SetDirection(string direction) 
    {
        // Prevents the snake from reversing directions (180-degree turns)
        if (_direction == "Up" && direction != "Down")
            _direction = direction;
        else if (_direction == "Down" && direction != "Up")
            _direction = direction;
        else if (_direction == "Left" && direction != "Right")
            _direction = direction;
        else if (_direction == "Right" && direction != "Left")
            _direction = direction;
    }

 
    public void Grow()
    {
        // Get the last segment (tail)
        SnakeSegment lastSegment = _segments[_segments.Count - 1];
        
        // Add a new segment at the tail's previous position
        _segments.Add(new SnakeSegment(lastSegment.GetPreviousX(), lastSegment.GetPreviousY(), lastSegment.GetDirection(), this, SnakeSegment.SegmentType.Body));
    }

    public bool Collisions()
    {
        SnakeSegment head = _segments[0];

        for (int i = 1; i < _segments.Count; i++)
        {
            SnakeSegment bodySegment = _segments[i];

            if (head.GetXCoord() == bodySegment.GetXCoord() && head.GetYCoord() == bodySegment.GetYCoord())
            {
                return true;
            }
        }
        return false;
        
    }

    public override void Render()
    {
        foreach (SnakeSegment segment in _segments)
            segment.Render();
            
    }

    // loops through all the segments to the coordinates can be updated
    public override void Move()
    {
        for (int i = 0; i < _segments.Count; i++)
        {
            SnakeSegment currentSegment = _segments[i];

            if (i == 0)
            {
                currentSegment.UpdateCoordinates(_direction, i);
            }
            else
            {
                currentSegment.UpdateCoordinates(_direction, i);
            }
        }
    }

    // prints the results and deletes old segments once moved.
    public override void UpdatePosition()
    {
        throw new NotImplementedException();
    }
}