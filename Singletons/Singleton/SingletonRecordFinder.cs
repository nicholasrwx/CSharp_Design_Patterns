namespace Singleton
{
    internal class SingletonRecordFinder
    {
        // Sums up the total population for a list of cities that exist in the database
        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int result = 0;
            foreach (var name in names)
                result += SingletonDatabase.Instance.GetPopulation(name);
            return result;
        }
    }
}
