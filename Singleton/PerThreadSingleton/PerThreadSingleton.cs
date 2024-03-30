// Ideal for when you need one instance per thread ( Avoids worrying about thread safety )
// Additionally, this type of lifetime is available through IoC ( Inversion of Control ) containers

public sealed class PerThreadSingleton
{
    private static ThreadLocal<PerThreadSingleton> threadInstance =
        new ThreadLocal<PerThreadSingleton>(() => new PerThreadSingleton());

    public int Id;
    private PerThreadSingleton()
    {
        Id = Thread.CurrentThread.ManagedThreadId;
    }

    public static PerThreadSingleton Instance => threadInstance.Value;
}