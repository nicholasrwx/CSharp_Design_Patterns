### **Overview:**

A Factory method allows you to construct the object.
It can be useful for many different reasons like returning a cached instance, subclassing, loose coupling, etc. Using a Factory Method will depend on the circumstance in which your object needs to be constructed.

### **Types participating in this pattern include:**

- **Star**
	- is a class that contains two different Factory Methods, both of which can construct and return an instance of the containing class. The Client facing data is privatized, and the constuctor is also privatized reducing the possibility that someone can access it. Additionally it has an ToString() method override, to help show if the class was initialized or not.

### **Sources:**
[Design Patterns in C# and .NET - Factory: Factory Method](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)