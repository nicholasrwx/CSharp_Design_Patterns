### Overview:

C#8 Default Interface Members allows us to create a kind of Decorator by directly adding default behavior to Interfaces avoiding the need to use Extension Methods or Wrapper Classes unless absolutely necessary. Instead of creating Delegating Members in the Decorator Class we can use smart casting to access default behavior within an Interface which implements another Interface. If additional storage is required we can inherit it from a single Parent Class or use a Wrapper Class. Also, if additional behavior is required we can create another Interface with default behavior or create Extension Methods.

### Types participating in this pattern include:

- **Dragon**
	- The Dragon Class is the Decorator Class. It Inherits from the Organism Class and it also implements the IBird, ILizard, and ICreature Interfaces. It can be smart casted to an IBird or ILizard which would allow you to access the default behavior setup in either Interface. It contains a property called Age which is a reference to the default Interface property Age contained within ICreature. This value can be modified through the Dragon Class, and accessed via cast to one of the Interface types. Additional storage can be added by using a Base Class or Wrapper Class. Additional Behavior can be added by another Interface or Extension Methods. 
	
- **Organism**
	- The Organism Class is the only Base Class provided to inherit from. It is a good option for additional storage if necessary.
	
- **IBird**
	- The IBird Interface implements the ICreature Interface and has a method called Fly which contains default behavior and uses the Age Property stored in ICreature.
- **ILizard**
	- The ILizard Interface implements the ICreature Interface and has a method called Crawl which contains default behavior and uses the Age Property stored in ICreature.
- **ICreature**
	- The ICreature Interface contains a Property called Age. It is Implemented by IBird, ILizard, and the Dragon Class. It is accessible via the Dragon Class, or via the IBird and ILizard Classes so long as you smart cast to the desired type.

### Sources:
[Design Patterns in C# and .NET - Decorator: Multiple Inheritance with Default Interfaces](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)