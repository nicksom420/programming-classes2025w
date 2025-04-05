public class Food: Entity
{

    private string _apple;

    public Food(int x, int y) : base(x, y)
    {
        _xPosition = x;
        _yPosition = y;
    }


    public void RandomPosition()
    {
        Random random = new();
        _xPosition = random.Next(1, 29);
        _yPosition = random.Next(1,14);

    }

    public override void Render()
    {
        
        Console.SetCursorPosition(_xPosition,_yPosition);
        Console.Write("$");
    }

    public override void UpdatePosition()
    {
        
    }

    public override bool Collisions()
    {
        return false;
    }
}