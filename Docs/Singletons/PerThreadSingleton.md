### Overview:

Prior to this we created a singleton with Lazy of type T. This would give us thread safety and laziness. In some cases you may not want thread safety. A per-thread singleton is a way around this because it creates one instance of your class per thread. This is to be used in cases where you would use one instance per thread rather than one instance for the entire application. This works where every time you run a task, an instance of your singleton class is created. So if you run two tasks, you will get two singletons. However, if you try creating multiple singletons within the same task, it will still only create one singleton.

### Types participating in this pattern include:

- **PerThreadSingleton**
	- Contains a private thread Instance, a private constructor, a public Instance that exposes the private thread Instance value, and a public Id that is set in the constructor to the current managed thread Id.

### Sources:
[Design Patterns in C# and .NET - Singletons: Per-Thread Singleton](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)