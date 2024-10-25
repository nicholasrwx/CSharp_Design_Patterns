### **Overview:**

A Factory is a class designed specifically for the creation / construction of another object. When there is a-lot of complex logic going into constructing an object, it makes sense to separate the construction logic from the client facing logic and values.

### **Types participating in this pattern include:**

- **Count**
	- The object in which we will construct. It contains the client facing logic and values only.

- **Count Factory**
	- The Factory is designed to perform some complex logic used in the construction of the Count object. Its Factory Methods take in values, and uses them to create what is needed to construct the count object, and then return a new instance of that count object. Additionally, it keeps the construction logic separate from the client logic.

### **Sources:**
[Design Patterns in C# and .NET - Factory: Factory](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)