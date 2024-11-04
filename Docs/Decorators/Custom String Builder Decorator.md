### Overview:

The Decorator Pattern is about adding behavior without altering the class itself. The reason behind this is because often times changing code that is already functioning can introduce breaking changes in other parts of the code where it is being used. Therefore to achieve this goal we want to adhere to the OCP ( Open Closed Principal ) and the SRP ( Single Responsibility Principal )  principals, as-well as we need to be able to interact with existing structures so our Decorator Object will have to have traits of the existing Object. There are two ways to achieve this.
First way is to inherit from the required Object if possible. The second way is to build a Decorator, which references the Decorated Object and provides additional behavior. Ultimately, the Decorator Object facilitates the addition of behaviors to Individual Objects without inheriting from them. This example is a basic Decorator Pattern that is capable of housing additional logic but doesn't. This exercise was just to demonstrate a standard setup.

###### NOTE:
	Delegating Members in this exercise were created using resharper. It has a 
	wonderful tool specifically for this purpose.

### Types participating in this pattern include:

- **CodeBuilder**
	* This is the Decorator which houses a StringBuilder and Delegating Members. The Delegating Members are modified to interact with the StringBuilder however in most cases they return the containing class ( CodeBuilder ) where we would normally return the StringBuilder. This is necessary with Fluent Builder types like StringBuilder if we wish to maintain the Fluent Interface while still having access to any additional functionality that is contained within the Decorator. However, Some members don't return a CodeBuilder and these are ones which return int/bool/void/etc.

- **StringBuilder**
	- The StringBuilder is a fundamental class that is from the System.Text namespace. It provides a Fluent Interface which allows the user to easily build, manage, and customize strings. It is a Sealed Class that is not meant to be modified.

### Sources:
[Design Patterns in C# and .NET - Decorator: Custom String Builder](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)