namespace CompositeCommand;

public interface ICommand
{
  public abstract void Call();
  public abstract void Undo();
}
