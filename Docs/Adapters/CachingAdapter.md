### Overview:

This Adapter is the same example as the Vector Raster Adapter except utilizes a caching mechanism. One of the side effects of the adapter is that you generate a-lot of temporary information. In this example, we are generating points to draw images in Raster Graphics based off of the points of the lines from a shape in Vector Graphics. For the first 8 invocations of the draw method we are generating points for lines that make up two rectangles. When we call the draw method again, we end up recalculating all those points. This isn't very efficient and for this reason we might want to cache the information we have generated to avoid this inefficiency. To create a cache, we use a dictionary to store the points of a line. We generate a hash code based off of the points of that line to use as the key, and the respective points are the value. Once this is in place we use conditionals to check if we have already drawn a line. If the hash code for two points exists in the dictionary, then we do not need to recalculate the points for a line.
### Types participating in this pattern include:

- **Line**
	* The Line type represents a pair of Points used to draw a line. It contains a Start and End property of type Point, equality methods for equality operations, and a GetHashCode function provided by resharper for generating a hash code of the line used to check if a line already exists based off of the Points it was given.

- **Point**
	- The Point type represents a pair of x and y coordinates. It contains an X and Y value, equality methods for equality operations, and a GetHashCode function provided by resharper for generating a hash code used as the key for the point values in a dictionary. It is used to create a starting and ending point of a line.

- **VectorObject**
	- The VectorObject type represents a Collection of type Line. It extends the Collection type and provides functionality such as the method Add.

- **Rectangle**
	- The Rectangle type extends a VectorObject. It contains a constructor which takes x and y coordinates as-well as a width and height. The points used to create a line are cartesian coordinates. A line is added to the collection, for each line in a rectangle, based off the provided values.

- **LineToPointer**
	- The LineToPointAdapter type represents a Collection of type Point. It takes a Line and extracts the Start and End points. It then generates all the points, between the starting and ending points of a line, and adds all the points to a Collection of type Point. This is an Adapter which takes a Line Object and turns it into a series of points. This way we can iterate over the lines of a rectangle, pass each line to the adapter, and convert the line so it can be drawn in point form.

### Sources:
[Design Patterns in C# and .NET - Adapter: Caching Adapter](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)