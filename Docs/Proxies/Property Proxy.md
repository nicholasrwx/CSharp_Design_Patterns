### Overview:

A Property Proxy is used to prevent duplicate assignments. It uses an Object as a Property instead of a literal Value. The Property Proxy is implicitly implemented, checks for duplicate Values upon assignment in the Setter, and simply returns without reassignment if the Values are the same. This avoids duplicate assignments.

**NOTE:**
	There is something with the Setter and Getter here that has a mutating effect which is required for the Setter code in a Property to actually execute. This helps achieve the scenario where you can pass a Value directly or a Property Object itself. This is to do with the way the Implicit Conversion is setup. You cannot overload the Assignment Operator so it has to be able to mutate in order to fulfill both scenarios where an int assignment would mutate the state of the 'new Property<>()' or take a 'new Property<>()' directly without causing an issue. 

### Types participating in this pattern include:

- **Property**
	* The Property Object is an Object that takes a parameter of type T where T is constrained to a new Object. This means the Property we pass to the Property Object has to be an Object itself which will be stored as a Value within the Property Object.

- **Creature**
	- The Creature Object is setup to store a Property of type T. It is just to demonstrate that our Property Proxy won't simply work with an Auto Property this way. This has to do with how we have setup the Implicit Conversion Operator within the Property Class itself.
	
- **PropperCreature**
	- The PropperCreature Object is setup to store a Property of type T in a private Field. It has a public Getter and Setter that access the Agility value within the private Property of type T. This works with the way our Implicit Conversion is setup and allows for our Property Proxy to function correctly. There is a bit of mutating magic happening here so we can use an int as an Assignment Value or a 'new Property<>()' as an Assignment Value based on how our Implicit Conversion Operator is setup within the Property Class.
### Sources:
[Design Patterns in C# and .NET - Proxy: Property Proxy](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)