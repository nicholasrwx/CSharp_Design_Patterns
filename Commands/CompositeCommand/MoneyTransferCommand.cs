namespace CompositeCommand;

class MoneyTransferCommand : CompositeBankAccountCommand
{
  public MoneyTransferCommand(BankAccount from, 
    BankAccount to, int amount)
  {
    AddRange(new []
    {
      new BankAccountCommand(from, 
        BankAccountCommand.Action.Withdraw, amount), 
      new BankAccountCommand(to, 
        BankAccountCommand.Action.Deposit, amount)
    });
  }

  public override void Call()
  {
    bool ok = true;
    foreach (var cmd in this)
    {
      if (ok)
      {
        cmd.Call();
        ok = cmd.Success;
      }
      else
      {
        cmd.Success = false;
      }
    }
  }
}