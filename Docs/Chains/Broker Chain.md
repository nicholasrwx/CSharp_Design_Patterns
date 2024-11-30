### Overview:

In the Method Chain example we permanently modified the Creatures Properties. This might not be desired in a game because maybe another creature affects the values of this creature in an attack of some sort. This means you would have to traverse the linked list of modifiers and recalculate the values applied to the creature and is kind of messy. To avoid this, we use what is called an Event Broker to implement a Chain of Responsibility Pattern. This Pattern uses Events to temporarily modify values of a creature, which can then be removed easily since the modifiers implement IDisposable. Therefore we can use the modifiers in a using block to modify creature values temporarily, and then dispose of them to remove the added values after we are finished with them.

### Types participating in this pattern include:

- **Game**
	* The Game provides a Query API for asking Attack or Defense Values for a particular Creature. it contains a property named queries of type Event which takes type Query.
	  It also contains a method called PerformQuery. This method takes two parameters... sender of type Object, and q of type Query. This method calles the invoke method on the queries event handle and passes it the sender as-well as the query param. **This Game class acts as an Event Broker which is what we are using to implement a Chain of Responsibility pattern.** It also resembles a kind of Mediator pattern as-well. 

- **Query**
	- The Query object specifies what you want and who you want it from. Additionally, it stores the result of the query inside the query object as-well. It contains the properties CreatureName of type string, Argument of type enum for Attack and Defense, WhatToQuery of type Argument, and a Value of type int. Additionally, it contains a constructor which takes creatureName, whatToQuery, and value arguments.
	
- **Creature**
	- This type is a Creature which can be modified by a variety of different modifiers. Unlike in the Method Chain example, it has four properties... name, attack, defense, and game.  The attack, defense, and game properties are private so that they cannot be changed. Additionally, there is also a public Attack and Defense property with a backing field. The backing field contains a getter which creates a new Query object using the creature properties. This Query is invoked using the PerformQuery method on the game object stored in the Game field. At the end of the query we get a value which we return. Finally, we have a ToString override which displays the property values of the creature.
	
- **CreatureModifier**
	- The CreatureModifier, unlike in the Method Chain example, is now an abstract class which extends **IDisposable**. It contains a constructor that takes two params, game and creature, and sets the instance variables. It also contains an abstract Handle method which takes a sender and query for params. Finally, it contains a Dispose method. This is to facilitate the adding and removal of different modifiers. In the constructor Game properties Queries will subscribe to the abstract handle method. The overrides will fill in the gap here, and then they will be disposed of in the Dispose method.
	
- **IncreaseDefenseModifier**
	- The IncreaseDefenseModifier extends CreatureModifier and contains a constructor that passes a Game object and Creature object to the base class. It also contains a single Handle override method which takes a sender and query param. This Handle override checks that the Query CreatureName and WhatToQuery ( Defense ) is correct, in which case it increases the query Value by 2. It does not directly modify the Creatures Properties.
    
- **DoubleAttackModifier**
    - The DoubleAttackModifier extends CreatureModifier and contains a constructor that passes a Game object and Creature object to the base class. It also contains a single Handle override method which takes a sender and query param. This Handle override checks that the Query CreatureName and WhatToQuery ( Attack ) is correct, in which case it increases the query Value by multiplying by 2. It does not directly modify the Creatures Properties.

### Sources:
[Design Patterns in C# and .NET - Chain of Responsibility: Broker Chain](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)