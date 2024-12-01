namespace HandmadeInterpreter;

public class Integer : IElement
{
  public Integer(int value)
  {
    Value = value;
}
   
  public int Value { get; }
}
