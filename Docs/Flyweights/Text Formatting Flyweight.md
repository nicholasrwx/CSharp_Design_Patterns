### Overview:

The goal of the flyweight is to avoid redundancy when storing data.
The flyweight is essentially a space optimization technique that lets us 
use less memory by **storing externally the data associated with similar objects**.
dotnet performs string interning, so an identical string is stored only once.

In this example we develop a way to capitalize different characters in a sentence. The Capitalize method in FormattedText utilizes a List of Booleans, one Boolean per string character, to determine which characters to capitalize. This List is unnecessary and expensive when it comes to memory. If additional functionality is required ( Bold, Highlight, Italics, etc. ) you need more and more Lists to manage the process. Instead of this, we use the flyweight pattern to optimize and have a List of TextRange Objects instead. The TextRange object contain specific information grouped in a slightly different way. We then check to see if a range covers a particular index rather than storing that information.

### Types participating in this pattern include:

- **FormattedText**
	* The FormattedText Type contains a string to format and a List of Booleans, one for each character in the string, to indicate if a character needs to be uppercase or lowercase. It contains a Capitalize method which is used to store a series of Booleans in the capitalize array for the index range provided. It also contains an overridden ToString method which Utilizes the Booleans in the Capitalize Array, so it outputs the PlainText string with the appropriate capitalization.

- **BetterFormattedText**
	- The BetterFormattedText Type contains a string to format and a List of TextRange. It contains a GetRange method which is used to add a TextRange to the List of ranges.
	  It also contains an overridden ToString method which Utilizes the TextRange objects to see if a specific character in a string is covered by the range and if it needs to be a Capital, Bold, or Italic. This eliminates the requirement of having multiple lists for each different scenario and is a memory optimization.
	
- **TextRange**
	- The TextRange Type contains Start/End, Bold, Italic, and Capitalize properties. It also contains the Covers method which will return a Boolean if the provided index value of a character is covered by the Start and End index values.
### Sources:
[Design Patterns in C# and .NET - Flyweight: Text Formatting](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)