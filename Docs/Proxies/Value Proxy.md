### Overview:

A value proxy is a proxy type that is typically constructed over a primitive type. It is essentially a wrapper around a primitive type that provides a bunch of conversion operators to and from that value. This provides an interface that seemingly acts the way a normal primitive would act, making it a value proxy. There are many reasons for this but the most common one is you want stronger typing. Sometimes you want to wrap a single primitive type but you also sometimes want to perform additional operations. This enforces the use of the right type and allows you to also conduct operations in an easier manner.

### Types participating in this pattern include:

- **Percentage**
	* The Percentage Object is a class which stores a float value. It also contains additional Operator Methods for addition and multiplication which handle scenarios where we are adding and/or multiplying a Percentage.

- **PercentageExtensions**
	- The PercentageExtensions Object is a Class that contains two additional Percent Overload Methods. These Methods are tasked with taking a float or an int value, dividing it by a float with a value of 100.0f, and passing the result as a param to a Percentage which stores the float value.

### Sources:
[Design Patterns in C# and .NET - Proxy: Value Proxy](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)
