namespace GenericValueAdapter;
// In C# you cannot put literals in generic types
// What we are doing with this Adapter is adapting a Literal Value to a Type

// Specifying D as an IInteger and the constraint of new()
// Allows us to use D as a kind of integer rather than a type?
public class Vector<T, D> where D : IInteger, new()
{
    protected T[] data;
    public Vector()
    {
        data = new T[new D().Value];
    }
}
