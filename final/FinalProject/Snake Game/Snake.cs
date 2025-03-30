public class Snake: MovingEntity
{
    private List<SnakeSegment> _segments = new();

    public Snake() 
    {

        _direction = "Up";

        _segments = new List<SnakeSegment>();


    }

    public string GetDirection()
    {
        return _direction;
    }

    public void SetDirection(string direction)
    {
        //Prevents the snake from reversing directions or do 180 degree turns
        if (_direction == "Up" && _direction != "Down")
            _direction = direction;
        else if (_direction == "Down" && _direction != "Up")
            _direction = direction;
        else if (_direction == "Left" && _direction != "Right")
            _direction = direction;
        else if (_direction == "Right" && _direction != "Left")
            _direction = direction;
    }
 
    public void Grow()
    {
        throw new NotImplementedException();
    }

    public override void Collisions()
    {
        throw new NotImplementedException();
    }

    public override void Render()
    {
        foreach (SnakeSegment segment in _segments)
            segment.Render();
            
    }

    // loops through all the segments to the coordinates can be updated
    public override void Move()
    {
        
    }

    // prints the results and deletes old segments once moved.
    public override void UpdatePosition()
    {
        throw new NotImplementedException();
    }
}