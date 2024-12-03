### Overview:

The memento pattern is a pattern often used to track changes that we can later roll back. In addition to creating mementos, we should also have a way to Undo and Redo state changes rather then having to manually Restore them.

A Memento Is:
	
	A token/handle representing the system state. 
	Lets us roll back to the state when the token was generated.
	May or may not directly expose state information.

### Types participating in this pattern include:

- **Memento**
	* The Memento type is an object which serves as a point in time reference to the state of a system or program. It contains a constructor which sets a private property called balance. This memento is used to roll back/forward a BankAccount balance to when a particular deposit took place.

- **BankAccount**
	- The BankAccount type represents a clients bank account. It contains a balance property, a Deposit method, a Restore method, and an override ToString implementation which displays the clients balance. In addition to these, we add a private List of Memento property called changes, a current property to indicate which Memento we are currently on, and two new methods called Undo and Redo. The changes List stores all the mementos that are created. The current property is effectively a pointer to the current memento in the list. The Undo method is designed to return the previous memento where the previous memento is current - 1. The Redo Method is designed to return the next memento where the next memento is current + 1.
### Sources:
[Design Patterns in C# and .NET - Memento: Undo and Redo](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)