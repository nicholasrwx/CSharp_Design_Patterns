### Overview:

In C# you cannot pass literal values into a class as a generic parameter. With this pattern you adapt a literal value to a type. In other languages this type of adapter is unnecessary, except in C#.

**Problem Code:**
- In C# you cannot put literals in place of a generic type
``` 
public class Vector<T, D>
{
	protected T[] data;
	public Vector()
	{
		data = new T[?];
	}
}

// You can't pass the literal ( 2 ) as a generic parameter, or any other literal
class Vector 2f: Vector<float, 2> {}
```

**Literal Definition:**
- A **literal** is a fixed value that is **directly written** in the source code, representing a constant value of a specific data type. **These are not variables.**
	1) Integer Literal - int / long / short
	2) Floating Point Literal - float / double
	3) Character Literal - enclosed in single quotes
	4) String Literal - enclosed in double quotes
	5) Boolean Literal - true / false
	6) Null Literal - null
	7) Hexadecimal Literal - prefixed with 0x or 0X 
	8) Binary Literal - prefixed with 0b or 0B

**Vector Definition:**
- In the mathematical sense, a vector is a fundamental concept that represents a quantity with both magnitude and direction.

**Performing Operations on The Vector Values:**
* You cannot perform operations ( + - * / ) on generic types. To get around this, you have to expand the inheritance hierarchy and perform **Partial Specialization** ( like in C++ ). You do this by making an in-between class ( VectorOfInt ) in the inheritance hierarchy. In this class you can then add the **operator +** logic that will take the left hand side and right hand side, extract the values, add them, and return the result. This allows you to handle a known type which is required for the operator to work.
### Types participating in this pattern include:

- **IInteger**
	- The IInteger is an interface which is used to pass a literal value as a generic type. It ensures that the class it extends has a value property containing the literal we wish to pass.
	
- **Dimensions**
	* The Dimensions class is a static class which contains two subclasses ( Class Two and Class Three ). Each subclass implements the IInteger interface and contains a value property of type int. Each subclasses value contains it's respective literal representation ( 2 and 3 ). These subclasses are used to pass the literal value as a generic param by way of IInterface.

- **Vector**
	- The Vector class stores an array of vector values. It provides an indexer to access the individual values, and dynamically sets the array size based off the provided params array. It also provides direct access to the initial value in the array as-well as a factory method for creating Vectors. It utilizes recursive generics to honor the inheritance hierarchy. The factory method is to avoid common issues with constructor propagation and typing issues.
	
- **VectorOfFloat**
	- VectorOfFloat is an in-between class and passes float values to the Vector parent class. In-between classes can be used for operator logic since the most derived class can't perform them on generics directly.
	
- **VectorOfInt**
	- VectorOfInt is an in-between class and passes int values to the Vector parent class. It contains a default constructor, and a constructor that passes an int array to the Vector parent class. In-between classes can be used for operator logic since the most derived class can't perform them on generics directly.

- **Vector2i**
	- Vector2i is a two dimensional vector made up of integers. It contains a default constructor and a constructor which takes a params array of type int and passes it up to the base class using constructor propagation.

- **Vector3f**
	- Vector3f is a three dimensional vector made up of floating point numbers. It is created using the factor method stored in the base Vector class called **Create** which takes a params array of floating point values and returns a new Vector3f.

### Sources:
[Design Patterns in C# and .NET - Adapter: Generic Value Adapter](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)
