namespace GenericValueAdapter;

public class Vector<TSelf, T, D> where D : IInteger, new() where TSelf : Vector<TSelf, T, D>, new()
{
  protected T[] data;

  public Vector()
  {
    data = new T[new D().Value];
  }

  public Vector(params T[] values)
  {
    var requiredSize = new D().Value;
    data = new T[requiredSize];

    var providedSize = values.Length;

    for (int i = 0; i < Math.Min(requiredSize, providedSize); ++i)
      data[i] = values[i];
  }

  // This is a factory method that honors the Vector hierarchy using recursive generics.
  // This is to avoid certain inheritance issues that can arise when instantiating a derived class.
  // The resulting type can be the Vector class itself, and issues with constructor propogation
  // Can occure when passing extra params to derived class. ( 19:10 for further clarification )
  public static TSelf Create(params T[] values)
  {
    var result = new TSelf();
    var requiredSize = new D().Value;
    result.data = new T[requiredSize];

    var providedSize = values.Length;

    for (int i = 0; i < Math.Min(requiredSize, providedSize); ++i)
      result.data[i] = values[i];

    return result;
  }

  public T this[int index]
  {
    get => data[index];
    set => data[index] = value;
  }

  public T X
  {
    get => data[0];
    set => data[0] = value;
  }
}
