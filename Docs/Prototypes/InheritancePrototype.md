### Overview:

Prototyping by inheritance works by passing member values in the constructor of a derived class to a base class, both of which implement a deep copy method required by a custom interface. The problem with this is it is costly because you have to pass values in each derived class's initializing constructor all the way up the inheritance hierarchy. This is not easily maintainable or scalable. In order to improve this, we have to modify the deep copy method requirements and how it works. To do so, we add a default deep copy implementation within the interface. Then we create extension methods to avoid always explicitly casting types to access default deep copy functionality. The reason this is good is because we get to reuse base class functionality when creating deep copies rather than adding the same functionality a dozen times all the way up the hierarchy. Adding the same functionality may work, and it isn't difficult, but it's unnecessary repetition and more work to maintain and scale.

### Types participating in this pattern include:

- **IDeepCopyable**
	- Interface that takes a generic parameter and requires implementing types to contain a CopyTo and DeepCopy method. The interface contains a default implementation of DeepCopy, which instantiates a new generic type of T, passes that type into the CopyTo method, then returns it. The CopyTo implementation has to be explicitly written in the interfaces implementing types.

- **Address**
	- Implements IDeepCopyable of type Address and contains two members, StreetName and HouseNumber, a ToString method, an initializing constructor, a default constructor, and a CopyTo method. There is no need for a DeepCopy method, as it has default behavior unless the desire is to override it. In the CopyTo method, we set the target parameter member values to the containing types respective member values.

- **Person**
	- Implements IDeepCopyable of type Person and contains two members, Names and Address, a ToString method, an initializing constructor, a default constructor, and a CopyTo method. There is no need for a DeepCopy method, as it has default behavior unless the desire is to override it. In the CopyTo method, we set the target parameter member values to the containing types respective member values. However, in this case the Names member is a string array, and we call the clone method on it as it is inconsequential, but it needs to be cast to a string array. Additionally, the Address member is a type that we call DeepCopy on and needs to be cast to an IDeepCopyable of type address if we wish to use the deep copy method. However, if we don't want to cast, we can create extension methods to get around this.

- **Employee**
	- Extends the Person type and implements IDeepCopyable of type Employee and contains a single member called Salary, an initializing constructor, a default constructor, and a CopyTo method. The CopyTo method calls the base class (Person) CopyTo method and passes it a target parameter of type Employee. It also sets the target type's salary to the containing type's salary.

- **ExtensionMethods**
	- ExtensionMethods is a static class that is used to bypass having to cast Address to an IDeepCopyable of type Address after a deep copy in order to have access to the default deep copy implementation. This static class contains a static method called DeepCopy, which takes a generic type as a parameter, which is then passed as the generic parameter of the static method's parameter item of type IDeepCopyable. So, the item is of type IDeepCopyable, which takes a generic parameter provided by the deep copy method's parameter. Now that the item is IDeepCopyable, we can call the default DeepCopy implementation. This is the workaround from explicitly casting Address to an IDeepCopyable of Address. In addition to this functionality, we need to go a step further and create a second extension method with constraints because as it stands, we can call deep copy using the wrong type as a generic parameter so long as it implements IDeepCopyable, and this may not be desired.

### Sources:
[Design Patterns in C# and .NET - Prototypes: Inheritance Prototype](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)