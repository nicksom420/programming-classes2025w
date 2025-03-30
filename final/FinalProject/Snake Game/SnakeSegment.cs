public class SnakeSegment: Snake
{

    // Allows me to know which snake segment is the head or the body so that it can be rendered and moved accordingly
    public enum SegmentType 
    {
        Head, // shows what segment is the head
        Body // shows what segment is the body
    }

    private string _body;

    private string _head;

    public int _xPosition { get; set; }

    int _yPosition { get; set; }

    public SegmentType Type { get; set; }

    public SnakeSegment(int x, int y, SegmentType type)
    {

        _head = "@";

        _body = "O";

        _xPosition = x;

        _yPosition = y;

        Type = type;
    }

    public override void Render()
    {
        Console.SetCursorPosition(_xPosition,_yPosition);
        if (Type == SegmentType.Head)
            Console.Write($"{_head}");
        if (Type == SegmentType.Body)
            Console.Write($"{_body}");
    }

    public override void Collisions()
    {
        
    }

    // to update the coordinate of the current segment
    public override void UpdatePosition()
    {
        // in order to update the position we first store the position of the head, then we update the position of the head according to what direction the snake is facing. Then we update from the tail to copy the next segments position. Once we get to the second segment object aka the first body segment we update that according to the previous head position previously stored.
    }

}