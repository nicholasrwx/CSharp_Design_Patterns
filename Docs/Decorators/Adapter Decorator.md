### Overview:

The Adapter Decorator is a Decorator pattern used to provide additional functionality while applying the Adapter pattern to satisfy interface and implementation conditions. In this example we use a Decorator to provide concatenation ability, by way of implicit and direct operations, to a StringBuilder which does not allow for the use of them. This is necessary because you cannot inherit from the StringBuilder type, so you need the Decorator to provide additional members. These members are special because they allow you to append to a StringBuilder implicitly when declaring a string variable as-well as directly via the += operator.
###### NOTE:
	Delegating members in this exercise were created using resharper. It has a 
	wonderful tool specifically for this purpose.
### Types participating in this pattern include:

- **MyStringBuilder**
	* This is the Decorator which is the StringBuilders containing object. It houses a StringBuilder, delegating members that interact with the StringBuilder, and additional functionality that makes use of the delegating members. The additional functionality allows the MyStringBuilder type to be used with the  = and += operators which is essentially an adapter while passing that information along to the actual StringBuilder by way of delegating members. This allows us to extend the functionality without modifying a sealed class avoiding OCP ( open closed principal ) violation. The delegating members work with the StringBuilder, and return a StringBuilder, however the additional functionality returns the MyStringBuilder ( containing class ). Unless you call the delegating members within the decorator directly, you will get the MyStringBuilder class as a return type.
	
- **StringBuilder**
	- The StringBuilder is a fundamental class that is from the System.Text namespace. It provides a fluent interface which allows the user to easily build, manage, and customize strings. It is a sealed class that is not meant to be modified.

### Sources:
[Design Patterns in C# and .NET - Decorator: Adapter-Decorator](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)