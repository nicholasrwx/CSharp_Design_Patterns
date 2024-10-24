namespace DetectingDecoratorCycles;

// Policy that does not allow Cycles of the same type

public class ThrowOnCyclePolicy : ShapeDecoratorCyclePolicy
{
    private bool handler(Type type, IList<Type> allTypes)
    {
        if (allTypes.Contains(type))
        {
            throw new InvalidOperationException($"Cycle detected! Type is already a {type.FullName}");
        }

        return true;
    }

    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes)
    {
        return handler(type, allTypes);
    }

    public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
    {
        return handler(type, allTypes);
    }
}