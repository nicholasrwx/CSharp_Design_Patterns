### Overview:

The Chat Room is a central component which acts as a Mediator. It allows participants to communicate with everyone in the entire room without participants having to directly reference one another or know they are present.


### Types participating in this pattern include:

- **ChatRoom**
	* The ChatRoom type is a component which allows a Person to communicate with everyone in the room. It contains a private list of type Person called people which represents the participants in the room. Additionally it contains 3 methods called Join, Broadcast, and Message. The Join method announces that a person joined the room using the Broadcast method, saves the room under the Person object, and adds the Person to the list of people in the ChatRoom object.  The Broadcast method sends the message to everyone in the room ( except the source ) by cycling through the list of people and calling the receive method so long as the Person is not the source. The Message method sends a message from one Person to a specific Person / Source by finding that person by name and invoking their receive method. These Person Objects still do not know about one another and are not connected other than by way of the ChatRoom Mediator when using the Message method.

- **Person**
	- The Person type is an object which represents a single participant in a ChatRoom. It has a constructor which takes a parameter called name. It also has 3 properties called Name, Room, and chatLog. As-well as 3 methods called Receive, Say, and Private Message. Name is the name of the participant, Room is the room the participant is in, and chatLog is a log of that users sent/received messages. The Receive method adds a string, composed of the senders name and message, to the chatLog. The Say method calls the ChatRooms Broadcast method, which takes the Persons own name and message as parameters, and sends a message to the entire room. Lastly, the PrivateMessage method, which takes a who and message parameter, calls the ChatRooms Message method and sends a direct message to a recipient using the recipients name to locate them in the list of people who are in the room.
### Sources:
[Design Patterns in C# and .NET - Mediator: Chat Room](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)