### Overview:

A Proxy is an Interface for accessing a particular resource by essentially replicating an Interface.
This replication provides entirely different behavior without having to alter the existing code.
This is also called a Communication Proxy, which is something that substitutes a different execution model where the invocations only appear to be local but they are not actually local.
Ultimately, a Proxy is a Class that functions as an Interface to a particular resource. That resource may be remote, expensive to construct, or may require logging or some other added functionality.
So you can provide functionality on that object but the nature of that functionality doesn't have to be Intrinsic to the Object itself.

In this example we create a CarProxy which has similar behavior to Car. They both contain Drive Methods. However, when the CarProxy Drive Method is executed, the behavior inside will make a call to the Car Drive Method if a Driver is of age. Otherwise, the CarProxy behavior will run instead when a Driver doesn't meet the age requirements. This is a Protection Proxy because it checks whether or not you have the right to access a particular method or value.

### Types participating in this pattern include:

- **ICar**
	* The ICar Interface ensures that any Object which implements it must contain a Drive Method.

- **Car**
	- The Car Type implements the ICar Interface. The Drive Method is required and returns a string that tells the User that the Driver can drive the Car.
	
- **CarProxy**
	- The CarProxy Type implements the ICar Interface. It contains two private properties, Driver and Car. It also contains a Drive Method that runs a condition which checks to see if the Driver is of legal age to drive. If the Driver is of age, the Car Drive Method is called, otherwise the CarProxy Drive Method finishes by providing the User a message that the user cannot drive.
	
- **Driver**
	- The Driver Type contains an Age property which represents the Drivers age. This age property is used in the condition of the CarProxy which checks a Drivers age first before deciding which Drive Method to complete. 

### Sources:
[Design Patterns in C# and .NET - Proxy: Protection Proxy](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)