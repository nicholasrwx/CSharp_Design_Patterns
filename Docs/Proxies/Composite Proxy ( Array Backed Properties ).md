### Overview:

The composite proxy which utilizes array backed properties is a pattern often used in situations with multi-state logic in a safer manner and avoid null assignments as-well as run better logic for when all values are not the same. This pattern is closely tied to interfaces and in this pattern the getters and setters refer to booleans contained within an array. Each indexed boolean in the array is dedicated to a specific property. When you access the properties value, you are actually accessing the arrays value, thus resulting in array-backed properties. 

### Types participating in this pattern include:

- **MasonrySettings**
	* This type contains 4 properties that are backed by an array. The fields get/set values contained within the array rather than their own. This is a safer approach to handling multi-state scenarios and where we have to manage null values. When we need to access all values at once we use the composite proxy property called All. This single property can handle all the other property states in the array at once, thus it is a composite proxy property.

### Sources:
[Design Patterns in C# and .NET - Proxy: Composite Proxy with Array-Backed Proxies](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)
