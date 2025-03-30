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
                }
                else
                {
                    Console.Write("");
                }


            }
        
            
        }

    }

    
}