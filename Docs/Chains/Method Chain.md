### Overview:

A Method Chain is a type of chain of responsibility that works across a linked list in such a way that it calls the next method on the next object in the chain. Every method down the chain has the ability to behave differently. It can continue the traversal of the linked list and perform certain logic, reverse/override logic performed, or end the traversal of the linked list entirely. This is considered a Chain of Responsibility since each method from each different modifier that is linked gets a chance to implement certain behavior on a creature or terminate the processing chain. In this example we demonstrate this by creating a CreatureModifier which contains a reference to another CreatureModifier ( this is our linked list ) and we traverse the linked list using the Handle method.

A Chain Of Responsibility is:
	
	A chain of components who all get a chance to process a command
	or a query, optionally having default processing implementation
	and an ability to terminate the processing chain.

### Types participating in this pattern include:

- **Creature**
	* This type is a Creature which can be modified by a variety of different modifiers. It has three properties... Name, Attack, and Defense. These properties can change depending on which modifier touches it and the rules behind the Chain of Responsibility that is being processed.

- **CreatureModifier**
	- The CreatureModifier has 2 fields. The first field contains a Creature the second field contains a CreatureModifier. It also contains 2 methods. The first one is the Add method which allows a user to add a CreatureModifier to the nested CreatureModifier field if it isn't null, otherwise it will set the null field in the current context to an instance of a CreatureModifier. The second one is the Handle method which is a virtual method that is overridden in a derived class so the behavior can be different across all the different modifiers. The CreatureModifier is a base class for all modifiers and is essentially a linked list of CreatureModifier's. Therefore, it can be treated as our root object for any kind of modifiers we want to add on top of the Creature.
	
- **IncreaseDefenseModifier**
	- The IncreaseDefenseModifier extends CreatureModifier and contains a constructor that passes a Creature object to the base class. It also contains a single Handle override method. This override notifies the client that it will increase the defense, increases the creatures defense by 3, and then calls the base Handle method in CreatureModifier which continues the tree traversal by checking for another modifier in the chain, and if there is one then it calls the next modifiers Handle method.
	
- **DoubleAttackModifier**
	- The DoubleAttackModifier extends CreatureModifier and contains a constructor that passes a Creature object to the base class. It also contains a single Handle override method. This override notifies the client that it will double the attack, multiplies the creatures attack by 2, and then calls the base Handle method in CreatureModifier which continues the tree traversal by checking for another modifier in the chain, and if there is one then it calls the next modifiers Handle method.

- **NoBonusesModifier**
	- The NoBonusesModifier extends CreatureModifier and contains a constructor that passes a Creature object to the base class. It also contains a single Handle override method. This override notifies the client that there will be no bonuses, and it terminates the processing of the Chain of Responsibility since it does not call the base Handle method in the CreatureModifier base class.

### Sources:
[Design Patterns in C# and .NET - Chain of Responsibility: Method Chain](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)