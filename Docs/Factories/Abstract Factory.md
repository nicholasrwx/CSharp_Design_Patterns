### **Overview:**

The abstract factory is a class that is used to build and instantiate various different factories. It contains an enum used to instantiate all the different factories in the project and store them in a dictionary which is accessible by key using a method provided by the class. This particular factory violates the open closed principle to achieve a certain objective because when new factories are created the enum needs to be updated with the corresponding type that the factory will produce. There are other was to achieve the same goal without violating this principle, like using reflection to dynamically instantiate all the factories instead.

### **Types participating in this pattern include:**

- **ChowMein**
	- An Object which represents a microwaveable food. It implements the IMicrowavedFood Interface which ensures the object contains a Consume Method. The Consume Method has a return type of void and provides commentary about the consumption of chowmein to the user.

- **Pizza**
	- An Object which represents a microwaveable food. It implements the IMicrowavedFood Interface which ensures the object contains a Consume Method. The Consume Method has a return type of void and provides commentary about the consumption of pizza to the user.

- **ChowMeinFactory**
	- A Factory that implements the IMicrowavedFoodFactory which ensures the factory contains a Prepare Method. The Prepare Method provides instructions to the user on how to prepare a particular amount of Chowmein. It then returns a ChowMein object that implements the IMicrowavedFood interface.

- **PizzaFactory**
	- A Factory that implements the IMicrowavedFoodFactory which ensures the factory contains a Prepare MEthod. The Prepare MEthod provides instructions to the user on how to prepare a particular amount of Pizza. It then returns a Pizza object that implements the IMicrowavedFood interface.

- **IMicrowavedFood**
	- An Interface that is implemented by a food object which is primarily used to enforce that the food object contains a Consume method and additionally allows each food object which implements the interface to be stored within the same list.

- **IMicrowavedFoodFactory**
	- An interface that is implemented by a food factory which is primarily used to enforce that the food factory object contains a Prepare method and additionally allows each food factory object which implements the interface to be stored within the same list.

- **MicrowavedFoodMachine**
	- Is considered an Abstract Factory, because it sets up and instantiates actual factory objects. It also manages them by storing them in a dictionary using the name of the food type as the key and the corresponding factory as the value. Additionally, it provides a public method to access the dictionary of factories by key, and returns the corresponding factory.

### **Sources:**
[Design Patterns in C# and .NET - Builder: Abstract Factory](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)