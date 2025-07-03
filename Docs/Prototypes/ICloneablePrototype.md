### Overview:

The ICloneable Prototype is a copy of an object using the clone method provided by the ICloneable interface. In the documentation it states that ICloneable will create an entirely new instance of the object you are implementing it on and cloning. However, it doesn't state whether it is a shallow copy or a deep copy. This example demonstrates how ICloneable works, that it creates a shallow copy, and that if you desired, you could force a deep copy, but it is inefficient to do this, and it is bad to use this interface because it is misleading and can cause issues when prototyping.

A shallow copy is simply a copy of an object where it doesn't copy the data recursively; rather, its members are copied via reference. A deep copy will make a copy of the object as well as a copy of its members, effectively creating an entirely new object.

### Types participating in this pattern include:

- **ICloneable**

- The ICloneable interface requires an object to implement the clone method. The clone method allows you to create a copy of the object itself. The copy is shallow.

- **Address**

- The Address object contains the members StreetName and HouseNumber as well as a ToString method, which displays these values when called. It is used as a member type within the Person object describing the person's address. When a Person object is cloned, the Address object contained within is referenced instead of copied, which demonstrates ICloneable behavior.

- **Person**

- The Person object implements the ICloneable interface and has a Names array, Address of type Address, Clone method, and ToString method. It contains the information of a person, and it is displayed on screen when ToString is called. It is cloneable; however, cloning the person results in a shallow copy with the Name and Address members containing references to the original Person object. Thus, altering the copy will also alter the original object

### Sources:
[Design Patterns in C# and .NET - Prototypes: ICloneable Prototype](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)