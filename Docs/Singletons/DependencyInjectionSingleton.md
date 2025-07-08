### Overview:

Creating a singleton isn't the best approach, as accessing it and modifying it can create issues, especially when switching between live and test databases. In a previous example we used a record finder method to access a live singleton database when testing. This created issues as accessing it was hardcoded, and values changing within the live database would break tests. To work around this, we can use dependency injection to initialize a singleton. We can use Autofac to build a container that creates a single instance, whether it be a test database or something else. This allows us to easily switch between databases without breaking things.

### Types participating in this pattern include:

- **ConfigurableRecordFinder**
	- takes an IDatabase as a dependency, a database field, and contains a GetTotalPopulation method. The GetTotalPopulation method uses the IDatabase dependency to access values. The IDatabase dependency allows you to swap out databases easily instead of hard coding a specific database call.

- **DummyDatabase**
	- DummyDatabase implements the IDatabase interface and contains a method called GetPopulation, which returns a dictionary of key-value pairs. This is a substitute database for the singleton database, as they are both IDatabases.

### Sources:
[Design Patterns in C# and .NET - Singletons: Dependency Injection Singleton](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)