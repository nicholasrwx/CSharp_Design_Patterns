### Overview:

This Adapter example represents how we might convert Vector Graphics to Raster Graphics by taking the lines of a Vector Shape and converting them into a series of points to represent the same shape in Raster Form. The output doesn't actually draw the shape, it just generates a series of points for each line to demonstrate the pattern and that a conversion of some sort took place. The raster pixels are simply represented as a period character to simplify the demonstration.
### Types participating in this pattern include:

- **Line**
	* The Line type represents a pair of Points. It contains a Start and End property of type Point. It is used to create the Line of a shape like a Rectange.

- **Point**
	- The Point type represents a pair of x and y coordinates. It contains an X and Y value. It is used to create a starting and ending point of a line.

- **VectorObject**
	- The VectorObject type represents a Collection of type Line. It extends the Collection type and provides functionality such as the method Add. It is used to store the lines of a particular shape like a Rectangle.

- **Rectangle**
	- The Rectangle type extends a VectorObject. It contains a constructor which takes x and y coordinates as-well as a width and height. The points used to create a line are cartesian coordinates. A line is added to the collection, for each line in a rectangle, based off the provided values.

- **LineToPointAdapter**
	- The LineToPointAdapter type represents a Collection of type Point. It takes a line and extracts the start and end points. It then generates all the points, between the starting and ending points of a line. This is an adapter which takes a line and turns it into a series of points. This way we can iterate over the lines of a shape, pass each line to the adapter, and convert the line so it can be drawn in point form.

### Sources:
[Design Patterns in C# and .NET - Adapter: Vector Raster Adapter](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)