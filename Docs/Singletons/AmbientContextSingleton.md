### Overview:

In some instances we use a variable in different areas of a program, and at different points it is updated to a different value for a different use case. This is an ambient context because the variable is essentially everywhere. Instead of updating this variable all over the place, we can create a singleton that has a single field. This field is the central location for the value, and instead of passing it as a parameter all over the place, we can simply set whatever value we need directly to the value of this field and then just update the field's value as needed. This pattern is a de facto singleton because no matter how you look at it, concurrent access doesn't make much sense here.

### Types participating in this pattern include:

- **BuildingContext**
	- Implements IDisposable and contains a WallHeight field, which is used as a central location in replacement of the height variable of a point. Also contains a stack of type BuildingContext for changing the wall height when context is switched. This type of arrangement uses a static constructor to push a new BuildingContext onto the stack of BuildingContexts and takes an integer as the wallheight parameter. The Current Field points to the latest context on the stack, and the Dispose method pops the latest context that was added to the stack to return back to the previous context.

- **Building**
	- Contains a Walls property that is a list of type Wall and a ToString implementation, which prints the values of each wall in the list.

- **Wall**
	- Contains the Start, End, and Height fields, which describe the dimensions of a wall within a building. The height is set to the BuildingContext. WallHeight, and the Start/End parameters are of type Point, which contains an X and Y coordinate for the starting and ending position of a wall.

- **Point**
	- Contains an X and a Y coordinate and is used to describe the starting and ending points of a wall's height.

### Sources:
[Design Patterns in C# and .NET - Singletons: Ambient Context Singleton](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)