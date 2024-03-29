public class ConfigurableRecordFinder
{
    private IDatabase database;

    public ConfigurableRecordFinder(IDatabase database)
    {
        if (database == null)
        {
            throw new ArgumentNullException(paramName: nameof(database))
        }

        this.database = database;
    }
}