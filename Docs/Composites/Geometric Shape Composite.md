### Overview:

The composite pattern is used to treat scalar ( individual ) objects and aggregate ( nested/collection ) objects in a uniform manner. In this example, objects can use other objects via inheritance/composition. The base class ( GraphicObject ) contains a list of objects of the same type. It can be cycled through recursively since each child item optionally has its own list of children. Each child can either be a scalar or aggregate object. This is essentially a tree of objects used to build a string which denotes the members name, color, and what level of the tree it resides in.  

### Types participating in this pattern include:

- **GraphicObject**
	* This is the base class which acts as a group for any member that is part of it. It contains an optional lazy list of children and print behavior which runs through all children recursively to build a string. If a child item has no list of children, then the list is not constructed due to its Lazy initialization.
	
- **Circle**
	- Circle is a derived class ( inheritance ) and potential group member ( composition ) of GraphicObject. It can be added to the list of children, or nested within a child item already contained in the list.
	
- **Square**
	- Square is a derived class ( inheritance ) and potential group member ( composition ) of GraphicObject. It can be added to the list of children, or nested within a child item already contained in the list.
### Sources:
[Design Patterns in C# and .NET - Composite: Geometric Shapes](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)