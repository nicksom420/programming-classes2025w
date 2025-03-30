public abstract class Entity
{
    protected int _size;

    protected int _position;

    public abstract void Render();

    public abstract void Collisions();

    public abstract void UpdatePosition();
}