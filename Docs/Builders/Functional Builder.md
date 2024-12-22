### Overview:

A functional builder uses a series of functions to build out an object.
This builder has several methods that aid in the process of setting up a list of delegates used to build an instance of an object.

### Classes and objects participating in this pattern include:

- **Alien**
	- The Type of object we are going to build.
	
- **AlienBuilder**
	- The Builder class which contains all the builder implementation used to build out an object with.
	- The Methods in this class are:
		- Called - This method takes a name as a string value and uses it in a lambda which is passed as a parameter to the Do method.
		- Do - This method takes an 'Action' parameter, which is the lambda we setup using the Called method, and pass this action as a parameter to the AddAction method.
		- AddAction - This method uses the parameter of the 'Action' Type, within a 'Func' Type, and then adds the newly created 'Func' to a list of 'Func'.
		- Build - this method runs a LINQ method called Aggregate() agains the list of Type 'Func'. It goes through the list one by one, and executes each different function by passing each one an instance of Alien. It starts with a new instance of Alien, and then modifies it by passing it into each Func in the list. 

- **AlienBuilderExtensions**
	- This class contains extension methods that can be additionally used alongside the AlienBuilder class, as this builder class is sealed, non extensible, and cannot be inherited from.
	- For an extension method to work it needs to be static, and belong to a static class.
	- each method has to be passed it's respective builder type as 'this' for the first parameter in the method.
	- After this has been passed, the Do method is accessed, and passed an alternative lambda. This lambda is added to the List of 'Func'.
	- These extensions can additionally be used in the dot chaining of the builders class methods, as they take the builders type, and return a builders type.

- **FluentAlienBuilder**
	- This builder virtually does the exact same thing as the AlienBuilder, except the parameters inside for the 'Alien' Type and 'AlienBuilder' Type are switched to generics.
	- Additionally the class now takes generic parameters of TSubject and TSelf, where TSelf is constrained to the class type itself, and TSubject is constrained to a type with a constructor.
	- The FluentBuilder, upgraded to use generics, is now reusable as it could work with nearly any 'Type' a person wishes to build


### Sources:
[Design Patterns in C# and .NET - Builder: Functional Builder](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)