public class Map
{
    
    private string _wall;

    private int _wallWidth;

    private int _wallHeight;

    public Map()
    {
        Console.SetWindowSize(50, 15);

        _wallWidth = 30;

        _wallHeight = 15;

        _wall = "█";
    }

    public void RenderMap()
    {
        
        Console.Clear();
        for (int y = 0; y < _wallHeight; y++)
        { 

            for (int x = 0; x < _wallWidth; x++)
            {

                Console.SetCursorPosition(x, y); 

                if (x == 0 || x == _wallWidth - 1 || y == 0 || y == _wallHeight - 1)
                {
                    Console.Write($"{_wall}");
                    Thread.Sleep(25);
                }
                else
                {
                    Console.Write("");
                }


            }
        
            
        }

    }

    public bool Collisions(Snake snake)
    {
        SnakeSegment head = snake.GetHeadSegment();

        // Check if the head is at the left or right wall (x-coordinate)
        if (head.GetXCoord() == 0 || head.GetXCoord() == 29)
        {
            return true; // Collision with the left or right wall
        }

        // Check if the head is at the top or bottom wall (y-coordinate)
        if (head.GetYCoord() == 0 || head.GetYCoord() == 14)
        {
            return true; // Collision with the top or bottom wall
        }

        return false; // No wall collision

    }

    
}