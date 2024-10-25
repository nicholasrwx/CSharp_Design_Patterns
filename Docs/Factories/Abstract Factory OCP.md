### **Overview:**

The abstract factory is a class that is used to build and instantiate various different factories. This factory adheres to the open closed principle by using Reflection. Reflection is a technique used to dynamically instantiate types that are in the assembly, bind the type to an existing object, or get the type from an existing object. Reflection replaces the enum we used in the previous Abstract Factory. This allows  us to adhere to the open closed principle because we can keep the factory closed from modification yet still get the latest factory types to instantiate directly from the assembly.

### **Types participating in this pattern include:**

- **HotDrinkMachine**
	- An Abstract Factory used to create factories and manage them in a dictionary via reflection. It additionally provides an interactive way of accessing factories via the command line and allows a user to select which one they would like to use.

- **HotDrinkFactory**
	- A Factory that implements the IHotDrinkFactory Interface which ensures the factory contains a Prepare method used to provide a user instruction on how to prepare a specific amount of a specific drink. The Prepare method also returns a IHotDrink.

- **IHotDrinkFactory**
	- An Interface used to enforce that a factory contains the Prepare Method. It is additionally used to allow different factories which implement the interface to be stored within the same dictionary.

- **IHotDrink**
	- An Interface used to enforce that a drink object contains the Consume Method. It is additionally used to allow different drink objects which implement the interface to be stored within the same list.

- **HotDrink**
	- A Drink Type which implements the IHotDrink Interface. It contains the Consume Method to provide additional commentary to a user on the consumption of a drink.

### **Sources:**
[Design Patterns in C# and .NET - Builder: Abstract Factory OCP](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)