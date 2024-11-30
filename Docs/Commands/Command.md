### Overview:

In this example of the command pattern we demonstrate how to create a list of commands which handle transactions in a clients bank account. Instead of sending and modifying information, by directly calling methods, we put in commands and store them in a list or preferably a database. This would make it easier to roll back transactions. Whereas if you are simply performing method calls, there is no list/record of this.

**The Command Pattern Is:**

	An object which represents an instruction to perform a particular action.
	Contains all the information necessary for the action to be taken.

**Reasons For This Pattern:**

	Ordinary C# statements are perishable:
		Cannot undo a field/property assignment
		Cannot directly serialize a sequence of actions ( calls )
	Want an object that represents an operation:
		X should change its property Y to Z
		X should do W()
	Uses:
		GUI Commands, Multi-Level Undo/Redo, Macro Recording and More!

### Types participating in this pattern include:

- **BankAccount**
	* The BankAccount type represents a clients bank account and has two properties balance and overdraftLimit. Additionally, it has two methods, Withdrawl and Deposit, which both take a parameter called amount. Deposit adds the amount to the balance, whereas Withdrawl checks that the amount withdrawn first does not exceed the overdraft limit before withdrawing the amount. The Withdrawl method returns a boolean that is used to flag whether or not the withdrawl was successful. This flag is used when undoing transactions, as we do not want to undo a transaction that was not performed. Both methods notify the user of the transaction that occurred and the final balance after transaction.

- **BankAccountCommand**
	-  The BankAccountCommand type implements the ICommand Interface and represents the command pattern. It contains a constructor which sets a few different private fields and properties. These fields and properties are a bankAccount of type BankAccount, an enum called Action with two members ( Deposit and Withdrawl ), A private property called action of type Action, and a private property called amount of type int. It also has a property called succeeded which is updated via the Call method on whether or not a deposite or withdrawl was successful, and it is used in the undo method as to whether or not a transaction should be reversed. Additionally, It contains concrete Call and Undo methods which is required by the ICommand Interface. The Call method contains a switch case where the enum members are the cases and the provided action is our switch value. If the case is Deposit then the BankAccount Deposit method is run. If the case is Withdrawl then the BankAccount Withdrawl method is run. Otherwise, an out of range exception is thrown. The Undo method reverses these method calls under each case to perform the opposite command on the account to roll back changes provided the transaction succeeded in the first place. This object satisfies the condition of the Command Pattern because it represents an instruction to perform a particular action and it stores all the information for the action to be taken. It is persisted in a list ( but could be modified to persist in a db ), which makes it easy to roll back the transactions.

- **ICommand**
	- The ICommand Interface ensures that any type which implements it contains concrete methods Call and Undo which return void.

### Sources:
[Design Patterns in C# and .NET - Command: Command](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)