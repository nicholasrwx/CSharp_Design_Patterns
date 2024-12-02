### Overview:

In this example we look at how array backed properties can serve as an item to be iterated over. This can be useful for calculating an average, or managing various different properties relating to a single object. Giving us the ability to cycle through them seamlessly rather than having to access them individually, yet at the same time allowing you the option to do so if desired. This isn't really an iterator, but does relate to iteration and can be very useful.

### Types participating in this pattern include:

- **Creature**
	* The creature type implements the IEnumerable interface of type int and contains several different properties which their values are stored in an array and used to calculate a stats average. The properties are Strength, Agility, Intelligence, and AverageStat. The backing field is the length of the 3 main properties and is used by AverageState, an Indexer, and the GetEnumerator method so the array can be used in a foreach loop, property values can be accessed individually, or calculated effectively without breaking future changes.
### Sources:
[Design Patterns in C# and .NET - Iterator: Array Backed Properties Iterator](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)