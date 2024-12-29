namespace GenericValueAdapter;

// Class is used for partial specialization, To perform operator + operations.
// This is an in-between class so we can perform operations on type as opposed to a generic.
// You cannot perform operator + on generics.
public class VectorOfInt<D> : Vector<VectorOfInt<D>, int, D> where D : IInteger, new()
{
  public VectorOfInt()
  {
  }

  public VectorOfInt(params int[] values) : base(values)
  {
  }

  public static VectorOfInt<D> operator +
    (VectorOfInt<D> lhs, VectorOfInt<D> rhs)
  {
    var result = new VectorOfInt<D>();
    var dim = new D().Value;
    for (int i = 0; i < dim; i++)
    {
      result[i] = lhs[i] + rhs[i];
    }

    return result;
  }
}
