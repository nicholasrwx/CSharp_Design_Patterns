namespace CompositeCommand;

public abstract class Command
{
  public abstract void Call();
  public abstract void Undo();
  public bool Success;
}
