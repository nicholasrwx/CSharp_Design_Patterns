### Overview:

The memento pattern is a pattern often used to track changes that we can later roll back. This is demonstrated in this example by creating a BankAccount type where each transaction that occurs creates a memento which saves the BankAccounts current balance at that point in time. These mementos are later used to rollback the account balance when required. It is similar to a Token used in an Interpreter except it is used to save state at a point in time rather than interpret a string.

A Memento Is:
	
	A token/handle representing the system state. 
	Lets us roll back to the state when the token was generated.
	May or may not directly expose state information.

### Types participating in this pattern include:

- **Memento**
	* The Memento type is an object which serves as a point in time reference to the state of a system or program. It contains a constructor which sets a private property called balance. This memento is used to roll back/forward a BankAccount balance to when a particular deposit took place.

- **BankAccount**
	- The BankAccount type represents a clients bank account. It contains a balance property, a Deposit method, a Restore method, and an override ToString implementation which displays the clients balance. The Deposit method takes an amount parameter and is used to increase the clients account balanace. It additionally creates a Memento of the clients current balance at the time the transaction took place. The Restore method takes a Memento as a parameter and is used to set the clients current balance to the balance contained in the Memento, effectively rolling back or rolling forward the balance to a particular point in time.

### Sources:
[Design Patterns in C# and .NET - Memento: Memento](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)