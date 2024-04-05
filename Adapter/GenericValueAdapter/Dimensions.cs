namespace GenericValueAdapter;

public static class Dimensions
{
    // These are now somewhat an adapter
    // The type implements IInteger which can be represented as an integer value
    public class Two : IInteger
    {
     public int Value => 2;
    }

    public class Three : IInteger
    {
     public int Value => 3;
    }
}