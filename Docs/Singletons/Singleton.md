### Overview:

A singleton is a single instance of an object. This is a way to keep data synchronized across a project that shouldn't be duplicated. A new instance can not be created, resulting in out-of-sync objects or unnecessary duplication in memory.

### Types participating in this pattern include:

- **IDatabase**
	- Contains a GetPopulation method, which takes a string parameter and returns an integer. Enforces the use of the GetPopulation method in implementing objects and provides functionality that accesses a data store.

- **SingletonDatabase**
	- Implements the IDatabase interface. It contains a private capitals dictionary, a private initializing constructor, a private instance of SingletonDatabase, a public getter to access the instance, and a GetPopulation method. In the constructor we read the capitals.txt file and store each line as a pair in a dictionary. The first line of a pair is the city name, and the second line of a pair is the city population. The GetPopulation method takes a string name and uses it as a key to access a value in the capitals dictionary. The private instance and private constructor are what prevent any duplication of the instance, as it is created at run time and thus will only allow for a single accessible instance across the entire project. Additionally, the instance is lazy loaded, so it is not created unless someone accesses the instance.

- **Capitals (Text File)**
	- Contains text of cities and populations, which acts as the data store accessed by the GetPopulation method in IDatabase.

### Sources:
[Design Patterns in C# and .NET - Singletons: Singleton](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)