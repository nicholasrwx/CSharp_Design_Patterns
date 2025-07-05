
### Overview:

An explicit interface prototype is a custom interface, which would work as a substitute interface for ICloneable to perform a proper deep copy. Whenever you want to perform a deep copy, you simply call the deep copy method on the type that implements the interface, and it will return a new copy. However, there is still the issue of having to implement this interface for every nested type as well and possibly having to call the deep copy method on nested types within the parent constructor. Which is similar to the copy constructor prototype.

### Types participating in this pattern include:

- **IPrototype**
	- IPrototype is an explicit interface that enforces the use of a generic parameter and a method called DeepCopy, which will be used to prototype the generic parameter.

- **Person**
	- The Person type implements the IPrototype interface and takes a Person as the generic parameter. It contains two members of Name and Address, a ToString method, and a DeepCopy method. The DeepCopy method instantiates a new Person type and is passed Name and Address. Address's DeepCopy method is called directly within the Person constructor as a new Address object is required to instantiate a new Person object.

- **Address**
	- The Address type implements the IPrototype interface and takes an Address as the generic parameter. It contains two members, StreetName and HouseNumber, a ToString method, and a DeepCopy method. The DeepCopy method returns a new Address type and is passed StreetName and HouseNumber.

### Sources:
[Design Patterns in C# and .NET - Prototypes: Explicit Interface Prototype](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)