using MoreLinq;

public class SingletonDatabase : IDatabase
{
    private Dictionary<string, int> capitals;
    private static int instanceCount;
    public static int Count => instanceCount;

    private SingletonDatabase()
    {
        instanceCount++;
        Console.WriteLine("Initializing Database");
        const string fileLocation = @"C:\Code\GangOfFourPatterns\Singleton\Singleton\capitals.txt";
        capitals = File.ReadAllLines(fileLocation)
            .Batch(2)
            .ToDictionary(
                list => list.ElementAt(0).Trim(),
                list => int.Parse(list.ElementAt(1)));
    }

    public int GetPopulation(string name)
    {
        return capitals[name];
    }

    // Lazy loads the singleton ( Creates at time of access ) when it is needed
    private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(() => new SingletonDatabase());

    public static SingletonDatabase Instance => instance.Value;
}