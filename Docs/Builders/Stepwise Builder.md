
### Overview:


A stepwise builder is a builder pattern that is designed to return polymorphic types in a specific order. The builder contains a private class that implements one or more interfaces.
Each interface contains the signature of a method with the return type of the next desired Interface that is required in the building process. This creates an ordered "step by step" builder used to construct the final product. The builder additionally contains a create method that returns a instance of the private class. The private class instance contains a single instance of the object a user wishes to build, and all interface method implementation.

### Classes and objects participating in this pattern include:

- **SpaceShipBuilder**
	- Contains a create method that returns an instance of a private class
	- Contains a private class that implements one or more interfaces
	- The private class also contains a single instance of the product being built
	- The private class contains a build method that returns the finished product


- **SpaceShip**
	- The concrete product that is built

- **SpaceShipType**
	- A enum used to determine the the type of concrete product that will be built as-well as some error handling ( This isn't essential to the build pattern... this is used for determining a specific property value on the concrete product )

- **ISpecifySpaceShipType**
	- Interface that is implemented in the private class contained in the builder class
	- Contains the signature of a method that will be used to set the type of spaceship to be built.
	- The return value is that of the next interface which contains the next desired method for building out the concrete product.
 
- **ISpecifyWarpSpeed**
	- Interface that is implemented in the private class contained in the builder class
	- Contains the signature of a method that will be used to set the warp speed of a spaceship to be built.
	- The return value is that of the next interface which contains the next desired method for building out the concrete product.

- **IBuildSpaceShip**
	- Interface that is implemented in the private class contained in the builder class
	- Contains the signature of a method that will be used to return the final concrete product of a built spaceship. The one instantiated within the private class.
	- The return value is the concrete type that has been built and stored within the private class of the builder.


### Sources:
[Design Patterns in C# and .NET - Builder: Stepwise Builder](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)
