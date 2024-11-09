### Overview:

A Dynamic Proxy is a proxy that is constructed at run time. In this example we are using a nuget package called ImpromptuInterface which provides a class called DynamicObject. We use the functionality provided by this object to proxy method calls over to the subjective object contained within the logger and after performing some logging magic, it invokes the subjects method calls and returns the interface you want from the Dynamic Object.
### Types participating in this pattern include:

- **IBankAccount**
	* The IBankAccount interface ensures that an implementation contains a Deposit, Withdraw, and ToString method.

- **BankAccount**
	- The BankAccount object implements the IBankAccount interface, contains member implementation, and handles the typical deposite and withdraw transactions.
	
- **Log**
	- The Log object is designed to log information about how many times certain transactions have run. It extends DynamicObject and Proxies / Invokes method calls over to the subject which is an instance of BankAccount. It then returns an IBankAccount. The Log object contains a dictionary called methodCallCount which tracks the method and number of calls for that particular method. Additionally, it contains a factory method which makes DynamicObject appear as if it implements IBankAccount.
### Sources:
[Design Patterns in C# and .NET - Proxy: Dynamic Proxy for Logging](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)