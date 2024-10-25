### Overview:

Some composed and singular objects need similar behaviors to work in a composite pattern. In the Neural Network example we demonstrate a complex scenario with 4 different types of behavior. Neuron-To-Neuron, Neuron-To-NeuronLayer, NeuronLayer-To-Neuron, and NeuronLayer-To-NeuronLayer. These scenarios require 4 different methods, and as the Neural Network increases in complexity, additional behavior is required. To avoid this growing complexity we apply the composite pattern by treating both Neuron ( Scalar ) and NeuronLayer ( Composite ) as enumerables. This way we can handle each connection with a single extension method.

### Types participating in this pattern include:

- **Neuron**
	- Implements IEnumerable of type Neuron and represents a single neuron. It uses 'yield return this' in the IEnumerator method to return a single scalar value as an IEnumerator which means a Neuron can be treated the same as a NeuronLayer. Additionally, It contains two lists. One is for incoming connections and the other is for outgoing connections.

- **NeuronLayer**
	- Implements Collection of type Neuron and represents multiple neurons. Collection implements IEnumerable by default. It is an aggregate value.
	
- **ExtensionMethods**
	- Contains the ConnectTo method which provides the behavior for working with IEnumerables. It connects all the neurons in one IEnumerable to all the neurons in the other IEnumerable provided they are not the same ( referential quality check ).
### Sources:
[Design Patterns in C# and .NET - Composite: Neural Networks](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)