namespace DetectingDecoratorCycles;

public class ShapeDecorator : IShape
{
    protected internal readonly List<Type> _types = [];
    protected internal IShape _shape;

    public ShapeDecorator(IShape shape)
    {
        this._shape = shape;
        if (_shape is ShapeDecorator sd)
        {
            _types.AddRange(sd._types);
        }
    }

    public virtual string AsString()
    {
        throw new NotImplementedException();
    }
}