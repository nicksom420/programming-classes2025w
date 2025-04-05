public abstract class Entity
{
    protected int _xPosition;

    protected int _yPosition;

    public Entity(int xPosition, int yPosition)
    {
        _xPosition = xPosition;
        _yPosition = yPosition;


    }

    public abstract void Render();

    public abstract void UpdatePosition();
}