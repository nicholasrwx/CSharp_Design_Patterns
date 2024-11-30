var ba = new BankAccount();
var commands = new List<BankAccountCommand>
{
  new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
  new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 1000)
};

WriteLine(ba);

foreach (var c in commands)
  c.Call();

WriteLine(ba);

// Enumerable.Reverse() is used because the Reverse() method is internal to the List<T> API.
// Therefore you can't call the LINQ Method on the List<T> like you normally would.
foreach (var c in Enumerable.Reverse(commands))
  c.Undo();

WriteLine(ba);
