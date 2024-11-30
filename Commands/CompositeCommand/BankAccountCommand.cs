namespace CompositeCommand;

public class BankAccountCommand : Command
{
  private BankAccount account;

  public enum Action
  {
    Deposit, Withdraw
  }

  private Action action;
  private int amount;
  private bool succeeded;

  public BankAccountCommand(BankAccount account, Action action, int amount)
  {
    this.account = account;
    this.action = action;
    this.amount = amount;
  }

  public override void Call()
  {
    switch (action)
    {
      case Action.Deposit:
        account.Deposit(amount);
        succeeded = true;
        break;
      case Action.Withdraw:
        succeeded = account.Withdraw(amount);
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
  }

  public override void Undo()
  {
    if (!succeeded) return;
    switch (action)
    {
      case Action.Deposit:
        account.Withdraw(amount);
        break;
      case Action.Withdraw:
        account.Deposit(amount);
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
  }
}