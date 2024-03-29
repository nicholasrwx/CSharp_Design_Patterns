using MoreLinq;

namespace SingletonDependencyInjection
{
    public class SingletonDatabase : IDatabase
    {
        private readonly Dictionary<string, int> _capitals;
        public static int Count { get; private set; }

        private SingletonDatabase()
        {
            Count++;
            Console.WriteLine("Initializing Database");
            const string fileLocation = @"C:\Code\GangOfFourPatterns\Singleton\Singleton\capitals.txt";
            _capitals = File.ReadAllLines(fileLocation)
                .Batch(2)
                .ToDictionary(
                    list => list.ElementAt(0).Trim(),
                    list => int.Parse(list.ElementAt(1)));
        }

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }

        // Lazy loads the singleton ( Creates at time of access ) when it is needed
        private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(() => new SingletonDatabase());

        public static SingletonDatabase Instance => instance.Value;
    }
}