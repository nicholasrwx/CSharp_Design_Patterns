### Overview:

The Composite Command pattern is designed to be a single command which in turn is a combination of other commands. It wraps several elements into one element which has the same API as a singular element. The **composite command is the one responsible for grouping** and orchestrating multiple commands together, treating them as a single unified command. In this example we demonstrate this pattern by creating a Composite Command object which stores a list of commands and delegates them, one after the other, to the Command cbject. A composite command can only be considered successful if all of the constituents succeed.

### Types participating in this pattern include:

	
- **ICommand**
	- The ICommand Interface ensures that any type which implements it contains concrete methods Call and Undo which return void.

- **Command**
	- The Command type is an abstract class which ensures that any type which implements it contains override methods Call and Undo which return void. In addition, it also requires the implementing class to contain a success boolean with both a setter and a getter.

- **BankAccount**
	* The BankAccount type represents a clients bank account and has two properties balance and overdraftLimit. Additionally, it has two methods, Withdrawl and Deposit, which both take a parameter called amount. Deposit adds the amount to the balance, whereas Withdrawl checks that the amount withdrawn first does not exceed the overdraft limit before withdrawing the amount. The Withdrawl method returns a boolean that is used to flag whether or not the withdrawl was successful. This flag is used when undoing transactions, as we do not want to undo a transaction that was not performed. Both methods notify the user of the transaction that occurred and the final balance after transaction.

- **BankAccountCommand**
	 - The BankAccountCommand type extends the Command type. It contains a constructor which sets a few different private fields and properties. These fields and properties are bankAccount, action, and amount. It also has a property called succeeded which is updated via the Call method on whether or not a deposite or withdrawl was successful, and it is used in the Undo method as to whether or not a transaction should be reversed. Additionally, It contains override methods, Call and Undo, which are required by the abstract Command type. The Call method contains a switch case where the enum members are the cases and the provided action is our switch value. If the case is Deposit then the BankAccount Deposit method is run. If the case is Withdrawl then the BankAccount Withdrawl method is run. Otherwise, an out of range exception is thrown. The Undo method reverses and rolls back changes provided the transaction was a success.
	  This object satisfies the condition of the Command Pattern because it represents an instruction to perform a particular action and it stores all the information for the action to be taken. It is persisted in a list ( but could be modified to persist in a db ), which makes it easy to roll back the transactions.
	
- **CompositeBankAccountCommand**
	- The CompositeBankAccountCommand type is an abstract class that is a collection of commands. It extends List of type T ( Where T is BankAccountCommand ) and implements ICommand. This type contains virtual Call and Undo methods. The Call method loops through all the commands and executes each commands Call method. The Undo method, loops through a reversed list of commands, and runs each commands Undo method if the command was a success. This type takes an IEnumerable as a parameter because it extends a List of T, It is passed along to the base class through the instructor. This type allows you to pass multiple transactions through as a single command and process or undo them. The methods can be overridden when the current functionality doesn't work for a specific type of command. This object satisfies the condition of a Composite Command Pattern because it stores a list of commands, which can all be executed in a single call. This treats them all like a single unified command.

- **MoneyTransferCommand**
	- The MoneyTransferCommand type extends the CompositeBankAccountCommand type and overrides its virtual Call method. It has a constructor which takes 3 parameters... from, to, and amount. In this constructor the AddRange method is called since we inherit from a List and we add the deposite and withdrawl BankAccountCommands for a money transfer this way using the constructor param values. The behavior in the Call method is altered here. Unlike the base class Call method we don't want to call subsequent commands here if the previous command failed. Therefore, a check is performed to see if the last command is null or success. If it is not null or success, then it has failed and we undo the command.

### Sources:
[Design Patterns in C# and .NET - Command: Composite Command](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)