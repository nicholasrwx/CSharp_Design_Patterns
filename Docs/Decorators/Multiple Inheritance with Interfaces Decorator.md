
### Overview:

There is a lack of Multiple Inheritance ( you can only have one Parent Class ) in .NET which sometimes can be very useful. You run into problems when you try to emulate Multiple Inheritance ( which is essentially the Decorator Pattern ). To emulate Multiple Inheritance you have to extract the Interfaces of the would be Parent Classes and implement them in the Desired Class. You'll then have to satisfy the conditions of the Interfaces but if you do this normally then your would be Parent Classes will have duplicated members within the Desired Class which implements their Interfaces. The work around is to aggregate the would be Parent Classes within the Desired Class. Making the Desired Class essentially a Decorator. Then create Delegating Members of the aggregate types. Since the contained types share the same Interfaces as the containing Class the Delegating Members will satisfy the conditions of the Interfaces. Additionally, if the contained types have the same property you might run into an ambiguity issue. The only way around this is using a setter with a backing field, then passing the value to each individual one, otherwise you won't be able to do it. This scenario of Multiple Inheritance with Interfaces can be messy and is not convenient.

###### NOTE:
	In this example we use ReSharper to extract the Interfaces from some Classes. 
	It provides a useful tool to complete this task called 'Extract Interface'. 
	Additionally, we use ReSharper to create Delegating Members which automatically 
	satisfy the requirements of the Interfaces of the containing type.

### Types participating in this pattern include:

- **Dragon**
	* This is the Decorator in which we use to emulate Multiple Inheritance. It implements the IBird and ILizard Interfaces. It contains a Bird and Lizard type which we want to emulate Multiple Inheritance of. It also contains Delegating Members of the contained types. These Delegating Members automatically satisfy the Interface requirements of IBird and ILizard without having to duplicate the code and violate the Single Responsibility principle. However, the Weight property becomes an ambiguous issue and requires a setter with a backing field for it to work properly.

- **Lizard**
	- The Lizard Class implements the ILizard Interface and contains the Crawl Method and Weight Property. It is a Class we wish to inherit from in the Dragon Class.
	
- **Bird**
	- The Bird Class implements the IBird Interface and contains the Fly Method and Weight Property. It is a Class we wish to inherit from in the Dragon Class.
	
- **IBird**
	- The IBird Interface is an Interface created to emulate Multiple Inheritance of the Bird Class and contains the Fly and Weight Members.

- **ILizard**
	- The ILizard Interface is an Interface created to emulate Multiple Inheritance of the Lizard Class and contains the Crawl and Weight Members.
### Sources:
[Design Patterns in C# and .NET - Decorator: Multiple Inheritance with Interfaces](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)