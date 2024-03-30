public sealed class BuildingContext : IDisposable
{
    public int WallHeight;
    private static Stack<BuildingContext> stack = new();

    // Required: Provides a default building context
    // So if you pop all contexts from the stack
    // you will still have a default context with an initialized WallHeight set to zero
    static BuildingContext()
    {
        stack.Push(new BuildingContext(0));
    }

    public BuildingContext(int wallHeight)
    {
        WallHeight = wallHeight;
        stack.Push(this);
    }

    public static BuildingContext Current => stack.Peek();

    // Using statements utilize this method to pop the current building context from the stack on dispose
    public void Dispose()
    {
        if (stack.Count > 1)
            stack.Pop();
    }

}

