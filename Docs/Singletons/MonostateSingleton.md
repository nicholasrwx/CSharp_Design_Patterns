### Overview:

The Monostate pattern is a reverse of the singleton in the way that we do not inhibit access to the constructor and the data is static. This way there can be many instantiations, but all instances point to the same static data. This is achieved because the properties are public, but the private fields they point to are static. Therefore, the data is still accessible by simply removing the static keyword from the properties that point to the static fields.

### Types participating in this pattern include:

- **CEO**
	- contains two private static fields, name and age, as well as two public properties, Name and Age. The public properties were static properties that point to their respective static fields; however, the static keyword is removed for accessibility purposes and to avoid hard coding while maintaining a single data source. This is what is referred to as a monostate.
### Sources:
[Design Patterns in C# and .NET - Singletons: Monostate Singleton](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)