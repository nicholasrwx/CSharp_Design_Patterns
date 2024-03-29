namespace SingletonDependencyInjection
{

    // This allows you to pass in a singleton database or a dummy database
    public class ConfigurableRecordFinder(IDatabase database)
    {
        private readonly IDatabase _database = database ?? throw new ArgumentNullException(paramName: nameof(database));

        // Sums up the total population for a list of cities that exist in the database
        public int GetTotalPopulation(IEnumerable<string> names)
        {
            return names.Sum(name => _database.GetPopulation(name));
        }
    }
}