namespace StaticDecoratorComposition;

public class Circle(float radius) : Shape
{
    private float _radius = radius;

    public Circle() : this(0)
    {

    }

    public void Resize(float factor)
    {
        _radius *= factor;
    }

    public override string AsString() => $"A circle with radius {_radius}";
}