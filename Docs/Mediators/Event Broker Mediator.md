
### Overview:

The Event Broker is a type of Mediator where different entities subscribe to events that are distributed by the broker. The broker is the mediator used by different entities to cross communicate with one another without having to directly reference, know, or communicate with each other. The Broker is setup using the Reactive Extensions Library.

**Reactive Extensions (Rx.NET):**

	The reactive extensions library is used for dealing with asynchronous data 
	streams. It represents an object that can be observed for changes. In this case 
	the type being observed is 'PlayerEvent'.

- `Subject<T>` is a class from the Reactive Extensions (Rx) library that allows for multicasting, meaning multiple observers can subscribe to it and receive notifications.

- `IObserver<T>` allows the subject to receive notifications using the `OnNext`, `OnCompleted`, or `OnError` methods.

- `IObservable<T>` allows the subject to emit values that other objects can subscribe to.

### Types participating in this pattern include:

- **Actor**
	- The Actor type has a constructor which takes a single parameter of type EventBroker. This is used to initialize the protected broker property within the actor class upon instantiation via dependency injection. The Actor allows various different types of Derived Classes ( Actors ) to access the same broker singleton which is registered in and resolved by an autofac container.
	
- **FootballPlayer**
	- The FootballPlayer type extends the Actor class. It contains the properties sub, Name, and GoalsScored. It also contains 2 methods Score and AssaultReferee. The constructor takes a broker and name parameter. In the constructor there are 2 subscriptions setup. Both subscriptions are designed to run when another player scores or sends off a different event when the players name who created the event is not their own name.
	
- **FootballCoach**
	* The FootballCoach type extends the Actor class. The constructor takes a broker as a parameter, and sets up 2 broker subscriptions. One subscription is designed to run when a player scores and the players GoalsScored value is less than 3. The other subscription runs when a sent off event occurs and the players Reason property is set to violence. 	
	
- **PlayerEvent**
	- The PlayerEvent type is used as a base class for specific event types and is distributed to other types via the EventBroker. It contains a name property which is the name of the player whom has scored or sent off an event.
	
- **PlayerScoredEvent**
	- The PlayerScoredEvent is a derived class of the PlayerEvent type. It contains a GoalsScored property. This event is instantiated and published using the brokers publish method.
	
- **PlayerSentOffEvent**
	- The PlayerSentOffEvent is a derived class of the PlayerEvent type. It contains a Reason property. This event is instantiated and published using the brokers publish method.
	
- **EventBroker**
	- The EventBroker type extends IObservable of type PlayerEvent. It contains a property called subscriptions which is a Subject of type PlayerEvent. `Subject<T>` is a class from the Reactive Extensions (Rx) library that allows for multicasting, meaning multiple observers can subscribe to it and receive notifications. It also contains a Subscribe method and Publish method. The Subscribe method takes an IObserver of type PlayerEvent and delegates this object to the subscriptions subscribe method. The Publish method takes a PlayerEvent and delegates it to the subscriptions onNext method. This class is used to publish and subscribe to PlayerEvents via delegation.
	
- **Ref**
	- The Ref type extends the Actor class. It contains a constructor which takes an EventBroker as a parameter. A subscription is setup using the broker to observe events of type PlayerEvent. When a PlayerEvent is published the ref class checks if the PlayerEvent is of type PlayerScoredEvent or PlayerSentOffEvent, to which it responds with a corresponding Console Message.
	
### Sources:
[Design Patterns in C# and .NET - Mediator: Event Broker](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)