using SingletonDependencyInjection;

var database = SingletonDatabase.Instance;

var city = "Whitehorse";
Console.WriteLine($"{city} has a population of {database.GetPopulation(city)} people!");