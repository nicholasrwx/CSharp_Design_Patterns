### Overview:

When we call a copy constructor with a preconstructed object, we copy all of its properties recursively. For this to work, every nested object also needs a copy constructor, which can directly copy its members data over to the new copy. A copy constructor lets you specify an object to copy all the data from directly in the constructor call. Copy constructor is a C++ term, as this is where it comes from, and is not widely recognized as a thing in the C# .NET world.

### Types participating in this pattern include:

- **Address**
	- The Address object contains the members StreetName and HouseNumber as well as a ToString method and a Copy Constructor. The copy constructor takes an instance of Address, accesses the member values, and copies them over to the respective members in the new instance.

- **Person**
	- The Person object has a Names array of type string, Address of type Address, ToString method, and Copy Constructor. The copy constructor takes an instance of Person, which subsequently contains an instance of Address. It sets the new instance values of the Names array and Address to the values of the respective members being passed in via the copy constructor. For copying the address, it is set by calling the address copy constructor within the person copy constructor and passing it the instance of the address, which is contained within the instance of the person.
	
### Sources:
[Design Patterns in C# and .NET - Prototypes: Copy Constructor Prototype](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)