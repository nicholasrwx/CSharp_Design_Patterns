### Overview:

A fluent builder is a builder that contains a method which returns the builder instance intself.
This allows you to perform method chaining.
You can tell if a builder allows for this by checking the return type of the instance methods.
In OOP this is a common design, and it is called a Fluent Interface.

### Classes and objects participating in this pattern include:

- **FluentBuilder**
	- Provides an fluent interface for continually accessing builder methods to build out the product
	- Designs and keeps track of the representation it creates (Contains a single Instance of the product)

- **Product**
	- Represents the complex object under construction
	- FluentBuilder builds the product's internal representation  
  	  
### Sources:
[Design Patterns in C# and .NET - Builder: Fluent Builder](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)
