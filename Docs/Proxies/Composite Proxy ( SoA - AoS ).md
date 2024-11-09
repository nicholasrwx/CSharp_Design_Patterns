### Overview:

The Composite Proxy is designed to create an interface which utilizes a Structure of Arrays, yet still behaves like an Array of Structures. It implements a composite pattern where you have an object ( in this case a struct ) contained within the actual object. The object within acts as a proxy for the containing object. The containing object is enumerated and yield returns the proxy object which references single values from within the arrays of the containing object by index. This provides a similar interface as an Array of Structures while having the benefits and efficiencies of a Structure of Arrays.

### Types participating in this pattern include:

- **Creature**
	* The Creature object demonstrates an Array of Structures pattern. It can be setup with an initial size in bytes like an Array. It can then be iterated over using a loop to retrieve values contained at each interval. However, it cycles over each property ( one after the other ) with each change of the index and this is not necessarily easy to deal with when trying to retrieve data for different properties contained within the same Array.

- **Creatures**
	- The Creatures object is a type of composite which demonstrates the use of the Structure of Arrays while having the interface that resembles an Array of Structures. It does this by utilizing an internal proxy object. It contains several arrays and they are all initialized with the same size value. These arrays are accessed via the proxy contained within itself. Creatures is enumerated but yield returns the proxy which references each array in the containing object by index at the same intervals.
	
- **CreatureProxy**
	- The CreatureProxy is a struct that references individual values within the containing Objects ( Creatures ) Arrays by index. It is returned instead of the containing object when Creatures is used in a loop. This allows the user to interact with Creatures in the same manner as they would a Creature as it mimics an Array of Structures interface. 
### Sources:
[Design Patterns in C# and .NET - Proxy: Composite Proxy SoA/AoS](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)
