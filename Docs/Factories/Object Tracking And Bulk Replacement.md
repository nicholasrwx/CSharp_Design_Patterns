
### **Overview:**

Object tracking can be done by using a factory to construct the object, create a weak reference to the object, and store the weak reference in a list within the factory. This is good if we want to have a way to track objects in memory or in a cache without interfering with garbage collection.

Additionally we can bulk replace objects we are tracking by providing a reference to a wrapper class which contains the object, instead of just a reference to the object itself. This second layer of indirection allows us to find the wrapper object in memory, and replace the contained object without affecting the reference. 

### **Types participating in this pattern include:**

- **ITheme**
	- Interface used for both DarkTheme and LightTheme, giving us the ability to store references to both themes within a single list.
	
- **DarkTheme**
	- Class containing the Dark Theme Properties

- **LightTheme**
	- Class containing the Light Theme Properties

- **Ref**
	- A wrapper class used for reference, which will contain a theme.
	
- **ReplaceableThemeFactory**
	- This factory is used to construct a theme object, place it within a wrapper class, create a reference to the wrapper class, and store the reference in a list. Additionally, it provides functionality used to find the wrapper by reference, and replace the theme object contained within it.

- **TrackingThemeFactory**
	- This factory is used to construct a theme object, create a reference directly to the theme object, and store the reference in a list. It provides additional functionality which outputs information to the console about what type of theme each object is, that is being tracked.

### **Sources:**
[Design Patterns in C# and .NET - Factory: Object Tracking and Bulk Replacement](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)