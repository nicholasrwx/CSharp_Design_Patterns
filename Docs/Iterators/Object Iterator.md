### Overview:

In this example we build two different ways to Iterate over a binary tree. The first way ( InOrderIterator ) is the more manual approach that you would see in a language such as C++ where traversal is imperatively programmed. It moves from one object to the next in order, by way of conditions which manually set state, then return the current results. The second way is more automatic ( BinaryTree ) as it runs through the nodes recursively, automatically setting the current node, and yield returning the results. Additionally we demonstrate how we can get away with using a foreach loop on a class that **doesn't** implement the IEnumerable Interface so long as it has a GetEnumerator method. If a GetEnumerator method is found, then it looks at the return type and checks if it has a Current property and a boolean returning method called MoveNext. This is enough for the foreach loop to execute on the Class and this is called **Duck Typing**.

**Iteration ( traversal )** is a core functionality of various data structures. An **iterator** is a class ( or, in .NET, a Method ) that facilitates the traversal of a data structure. It does 2 different things:

- It keeps a reference to the current element
- Knows how to move to a different element

Iterator is an implicit construct in which if you actually use IEnumerable of T, then .NET builds a **state machine** around yield return statements. In other words everything happens automatically ( unlike other languages such as C++ ).

### Types participating in this pattern include:

- **Node**
	* The Node type is an object used to construct a Binary Tree for iteration. It contains a few different properties which are Value, Left, Right, and Parent. The Left Parent and Right Parent is initialized in the constructor and set to the root Node as they will both point to the same parent object. 
	
- **InOrderIterator**
	- The InOrderIterator type is designed to iterate over a tree of nodes in the right order. It has a constructor which takes a Node of type T. It has a Current Property, Root Property, yieldStart Property, MoveNext method, and a Reset method. The Current property stores the current node. The Root property stores the root node. The yieldStart property indicates whether or not we have yielded the initial value since the current value gets automatically set which prevents us from moving to the next node in the tree prematurely. The MoveNext method is used to move to the next node and returns a boolean if there is an object to move to. Lastly,  the Reset method is used to reset the iterator. The way the InOrderIterator works is exactly how Iterators work in C# like IEnumerable under the hood. This is what you would normally have to build out in languages like C++. This is also a **state machine** where the Current property is the state which is yield returned by way of the MoveNext method.
	
- **BinaryTree**
	- The BinaryTree type is a collection of the different iteration methods. It contains a constructor which takes a Node of type T as a parameter. It has a root parameter which is a reference to the root node. It also has an InOrder method that contains a backing field and a getter with a nested Traverse method. The Traverse method is going to be the part of the state machine which handles and yield returns the state. The Traverse method is a recursive method in which it calls itself on the left node until it runs out, in which case it returns the current node, then it calls itself on the right node until it finds a left node again, and continues until it runs out etc. This is repeatedly done until all nodes have been gone over in-order recursively.

### Sources:
[Design Patterns in C# and .NET - Iterator: Object Iterator](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)