### Overview:

A faceted builder is a type of builder which holds a reference to the object we are building, as-well as references to multiple different sub builders which will be employed to do the work instead. This pattern is useful for configuring large objects in an organized way, and providing a fluent API to do so. Each builder is responsible for a specific set of attributes on the object.

### Classes and objects participating in this pattern include:

- **Worker**
	* The object we wish to build, which is instantiated and contained within the worker builder class. It contains multiple parameters that can be separated into groups. Each group of parameters is handled by its respective sub builder class.

- **WorkerBuilder**
	- The worker builder is a class that contains a reference to the object we are building. It also contains references to multiple different sub builders, designed to handle the construction of a specific section of our referenced object. Additionally, the worker builder contains an implicit conversion operator which allows us to change the resulting value of a derived type ( sub builder ) to the object we have constructed. The Worker Builder is a "Facade" because it doesn't actually do any building.
	
- **WorkerJobBuilder**
	- The worker job builder, is a builder focused specifically on constructing the part of the worker instance which pertains to the workers job information.
	
- **WorkerAddressBuilder**
	- The worker address builder, is a builder focused specifically on constructing the part of the worker instance which pertains to the workers address information.

### Sources:
[Design Patterns in C# and .NET - Builder: Faceted Builder](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)