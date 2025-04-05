public abstract class MovingEntity: Entity
{


    protected string _direction;

    public MovingEntity(int x, int y, string direction): base(x,y)
    {
        _direction = direction;

    }

    public abstract void Move();
}