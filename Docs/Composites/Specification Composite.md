### Overview:

The specification example is a way to expose the interface of a single specification while at the same time has the ability to keep a list of many specifications. This pattern can be used with the 'and' operator, or the 'or' operator.

NOTE: The example is difficult to follow for re-creation. So for now I only have some general notes on this type of composite pattern use case. Also, I would like to note for future reference that the specification pattern is stated to be an 'enterprise pattern' in this lesson.

### Types participating in this pattern include:

- **ISpecification**
	- An abstract class which contains an abstract IsSatisfied method. It provides '& 'operator behavior in use with the ISpecification type and returns a new AndSpecification.
	
- **CompositeSpecification**
	- An abstract class which extends the ISpecification. It stores a list of ISpecifications. It exposes the interface of a single object ( Scalar ) while at the same time is not really a single object ( Composition ) because it keeps a list of specifications.
	
- **AndSpecification**
	* Extends CompositeSpecification and takes a generic parameter of type T. The AndSpecification constructor passes params to the base class ( CompositeSpecification ) to store them in a list. In addition, it contains an IsSatisfied override method which checks all the items in the list of the base class against a parameter of the same type.  The AndSpecification is typically called a 'combinator' which combines things together for the 'and' operator. This can be modified to use the 'or' operator.

### Sources:
[Design Patterns in C# and .NET - Composite: Specification](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)