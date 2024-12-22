### Overview:


This type of fluent builder allows one fluent builder to inherit from another fluent builder while maintaining access to all methods and properties that are in both fluent builder interfaces. This is done using recursive generics to create a self referential relationship, by applying a self referential constraint to the generic parameter being passed into the class, and then using a derived type that inherits from this class as the generic parameter. This allows you to downcasting the return type of 'this' to the derived type of 'this' which is being passed in as the generic parameter.

This is a very difficult and confusing concept to understand, but it can be done.


### Classes and objects participating in this pattern include:

- **AbstractProduct** (Base Class)
	- Keeps track of the representation it creates (Contains a single Instance of the product). Normally the product instance is contained in a builder class. But, in this case with multiple builders, it's a little cleaner to have it exist in a separate class that is inherited by the parent builder.

- **FluentBuilder** (Parent Fluent Builder Class)
	- Inherits from the abstract product class
	- This class takes a generic parameter that is constrained to it's own type
	- Provides a fluent interface for continually accessing builder methods to build out the product
	-  returns 'this' downcasted to a derived type

- **FluentBuilder** (Child Fluent Builder Class)
	- Inherits from the parent fluent builder class, which takes a generic parameter of the child builder class, which takes a generic parameter
	- This class takes a generic parameter that is constrained to it's own type
	- Provides a fluent interface for continually accessing builder methods to build out the product
	- returns 'this' downcasted to a derived type

- **Builder** (Child Builder Class)
	- This is the farthest derived class
	-  This class is used to satisfy the generic parameter of the Child Fluent Builder Class. 
	- Since the generic parameter for the child fluent builder needs to be a derived type of itself which takes a parameter of the derived type... This becomes our starting point for the recursive generic piece of this logic.
	- This is necessary, because you could not instantiate the child fluent builder without having a derived type to pass to it in the first place.
	- There is no implementation in this class, and is used to expose the fluent builder interfaces. It can exist on its own or be kept on the product class.

- **Product**
	- Represents the complex object under construction
	- The FluentBuilders build the product's internal representation  
	- Contains a Builder that Inherits from the Child Builder Class which takes a generic parameter. This Builder class is used as the type which is passed in as the generic parameter to the Child Fluent Builder. 
	  This Builder is instantiated within the Product Class. 
	  Doing this exposes both of the fluent builders methods when accessing the builder instance within this product class.

### Sources:
[Design Patterns in C# and .NET - Builder: Fluent Builder Inheritance With Recursive Generics](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)
