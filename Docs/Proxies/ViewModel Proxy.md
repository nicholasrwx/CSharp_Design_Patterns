### Overview:

In some cases you might want to wire your object to user interfaces. You may want additional functionality than what your object provides. In order to do this while sticking to the principle of separation of concerns you create a ViewModel. A ViewModel is a proxy over the Model itself, and it typically holds data and any additional functionality you wish to provide to the Model. This structure is of the MVVM architecture ( Model, View, ViewModel ).
### Types participating in this pattern include:

- **Person**
	* The Person type is a Model which strictly contains data that is used by the View and the ViewModel in an MVVM Architecture. It does not contain any additional functionality or behavior. In this example, it is updated by the ViewModel which is essentially a Proxy for the Person Model.

- **PersonViewModel**
	- The PersonViewModel is a type which contains an instance of Person. It replicates the fields of a Person as properties. These properties are proxy properties as they retrieve and update the values of the person object itself. This can easily evolve into a Decorator by way of adding behavior in addition to the proxy architecture ( ex. FullName Property ).

### Sources:
[Design Patterns in C# and .NET - Proxy: ViewModel](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)