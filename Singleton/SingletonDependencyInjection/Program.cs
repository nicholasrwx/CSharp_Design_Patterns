using SingletonDependencyInjection;

var database = SingletonDatabase.Instance;

const string city = "Whitehorse";
Console.WriteLine($"{city} has a population of {database.GetPopulation(city)} people!");