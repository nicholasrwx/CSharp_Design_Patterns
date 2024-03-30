var t1 = Task.Factory.StartNew(() =>
{
    Console.WriteLine($"t1: {PerThreadSingleton.Instance.Id}");
});

// Running task twice to show we get the same instance on the thread
var t2 = Task.Factory.StartNew(() =>
{
    Console.WriteLine($"t2: {PerThreadSingleton.Instance.Id}");
    Console.WriteLine($"t2: {PerThreadSingleton.Instance.Id}");
});

Task.WaitAll(t1, t2);