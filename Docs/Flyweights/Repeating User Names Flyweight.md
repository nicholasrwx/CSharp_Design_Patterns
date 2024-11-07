### Overview:

The goal of the flyweight is to avoid redundancy when storing data.
The flyweight is essentially a space optimization technique that lets us 
use less memory by **storing externally the data associated with similar objects**.
dotnet performs string interning, so an identical string is stored only once.

In this example we have two different Test Methods that utilize two different types of User Objects.
In the first Test Method we store a List of Type User. This is inefficient because it allows for duplicate User Names. In the second Test Method we try to optimize this scenario by splitting the First and Last Names of a User and store them in a List. A check is performed before storage to look for duplicate Names. If a duplicate is detected the Name is not stored. We additionally store the indices of a Users First and Last Name on the UserTwo Object. This is so we can identify and retrieve the correct Names later on for the User.

### Types participating in this pattern include:

- **User**
	* The User Object is used to store the Full Name of a particular User in a List.
- **UserTwo**
	- The UserTwo Object is used to store a static List of Names. It additionally creates a UserTwo Instance which contains the Indices of the Names associated with the User. This is done by using a Method in the Constructor which gets / stores the Indices and checks for duplicate names in the list.
### Sources:
[Design Patterns in C# and .NET - Flyweight: Repeating User Names](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)