### **Overview:**

An inner factory is a class that is contained within the object that it is going to build out and instantiate.
It generally remains on the class ( not on the instance ).
This can be useful when you want to provide factory capabilities to build an object which has a private constructor.

### **Types participating in this pattern include:**

- **Sign**
	- An object that contains values which represent a custom or premade order of signs.

- **Factory**
	- An Inner Factory which contains additional factory methods that allow someone to create a customized order of signs.

### **Sources:**
[Design Patterns in C# and .NET - Factory: Inner Factory](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)