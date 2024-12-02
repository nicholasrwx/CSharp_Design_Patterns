var ba = new BankAccount(100);
var m1 = ba.Deposit(50); // 150
var m2 = ba.Deposit(25); // 175
WriteLine(ba);

// restore to m1
ba.Restore(m1);
WriteLine(ba);

ba.Restore(m2);
WriteLine(ba);
