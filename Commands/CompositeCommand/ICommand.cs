namespace CompositeCommand;

public interface ICommand
{
  public void Call();
  public void Undo();
}
