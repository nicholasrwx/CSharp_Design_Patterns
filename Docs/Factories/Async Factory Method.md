### **Overview:**

An asynchronous factory method is useful in scenarios where the creation of an object involves asynchronous operations, such as I/O operations, network requests, or any task that could introduce latency. The primary goal is to avoid blocking the execution of the program while waiting for these asynchronous operations to complete.

### **Types participating in this pattern include:**

- **Sticker**
	- This class has an asynchronous method which performs an asynchronous task when called. This class needs to be instantiated and the contained async method needs to be awaited. It demonstrates the way one would use a class with an async method that isn't a proper async factory method.
	  
- **PropperSticker**
	- PropperSticker demonstrates a class that contains a proper asynchronous factory method. The Factory method creates and initializes the containing class first. Then it calls the other async method in the class which runs the async task. The benefit here is that you don't expose the contained logic, an instance of the object is always created, and initialization can be done asynchronously.

### **Sources:**
[Design Patterns in C# and .NET - Factory: Asynchronous Factory Method](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)