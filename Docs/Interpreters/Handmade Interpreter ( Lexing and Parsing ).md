
### Overview:

Textual input needs to be processed, for example source code is textual input and needs to be processed by turning it into OOP Structures. In this example we build a Lexer and a Parser to interpret a mathematical expression, represented in string form, into it's resulting value.

**Lexer:**

	The Lexer operates on individual Tokens. It is used to convert text into a desired list of tokens.
 	Once the text is organized into the desired tokens then it can be further used
  	to put them into something object oriented and nicely structured.

**Parser:**

	Used to turn interpret sequences of tokens into some sort of object oriented representation
 	of the input and evaluate it's result.

**Interpreter:**
	
	A component that processes structured text data. Does so by turning it into 
	separate lexical tokens ( lexing ) and then interpreting sequences of said 
	tokens ( parsing ).

### Types participating in this pattern include:

- **IElement**
	* The IElement Interface defines operations that is common to all the expressions used in the input text. It contains a property called Value with a getter. It ensures implementing classes contain a Value property with a getter.
 
- **Integer**
	- The Integer type implements the IElement Interface. It contains the Value property with a getter. This is further used for storing values in the interpretation / evaluation process of the parsing operation.
	
- **Token**
	- The Token type represents a custom section of a parsed string. It contains an enum called Type that holds all the different types that a token can be. In this case it can be an Integer, Plus, Minus, Left Parent, or Right Paren. It also has two properties Text and MyType, which are set in the constructor. Lastly, it contains an override ToString Implementation which displays the value stored in the Text property. This is used to turn an individual or group of text characters into a token which will be later used for interpretation in the parsing method.
	
- **BinaryOperation**
	- The BinaryOperation type implements the IElement Interface. It contains the properties Value, MyType, Left, and Right. It also contains an enum called Type.  The Value properties getter contains a switch case where MyType is the switch value and the cases are different enum types which represent some sort of mathematical operation. This is used to perform addition and subtraction when used in the parsing method where the expression is interpreted.

### Static Methods Required In Example:

- **Lex**
	- The Lex method is designed to split a string into specific text segments that will be converted to a token. It contains an empty List of type Token that is populated as we look over the characters of a string looking for specific characters. Each Character is checked in a switch case statement for a match. When a match is found a new token is created and added to the list of tokens. The default case is for if a digit is found, in which case the digits ( for multi digit numbers ) are combined using a string builder and added to the list of tokens as-well. Then the List of type Token is returned.
	
- **Parse**
	- The Parse method takes an IReadOnlyList of Tokens, cycles through every single one, and performs an operation depending on what type of token it is. It contains a BinaryOperation object, haveLHS ( Have Left Hand Side ) boolean, and a for loop which cycles through each of the tokens. Within the loop, there is a switch case statement where the token type is the switch value and the cases are different token types. When a case match happens, the corresponding parsing operation is performed for the token of the specific type ( numbers get converted and other characters get interpreted ). Additionally, it performs the mathematical operation on the current tokens, generates a subexpression, and then recursively calls the Parse method on the subexpression until it has been solved. This is how an expression is parsed and interpreted from tokens.

### Sources:
[Design Patterns in C# and .NET - Interpreter: Handmade Interpreter ( Lexing and Parsing )](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)
