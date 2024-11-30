namespace Command;

public class BankAccountCommand : ICommand
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
    this.account = account ?? throw new ArgumentNullException(paramName: nameof(account));
    this.action = action;
    this.amount = amount;
  }

  public void Call()
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

  public void Undo()
  {
    // The succeeded check is necessary because sometimes deposits may fail.
    // Therefore you should not need to reverse it, if it did not succeed.
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