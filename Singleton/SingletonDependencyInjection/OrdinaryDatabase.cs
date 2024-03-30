using MoreLinq;

namespace SingletonDependencyInjection
{
    public class OrdinaryDatabase : IDatabase
    {
        private readonly Dictionary<string, int> _capitals;

        public OrdinaryDatabase()
        {
            Console.WriteLine("Initializing Database");
            const string fileLocation = @"C:\Code\GangOfFourPatterns\Singleton\SingletonDependencyInjection\capitals.txt";
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
    }
}