using Autofac;
using NUnit.Framework;

namespace SingletonDependencyInjection
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void ConfigurablePopulationTest()
        {
            var recordFinder = new ConfigurableRecordFinder(new DummyDatabase());
            var names = new[] { "alpha", "gamma" };
            var totalPopulation = recordFinder.GetTotalPopulation(names);
            Assert.That(totalPopulation, Is.EqualTo(4));

        }

        [Test]
        public void DiPopulationTest()
        {
            var containerBuilder = new ContainerBuilder();

            // Register a single instance of OrdinaryDatabase as IDatabase
            // This can easily be switched to a different type like DummyDatabase for testing purposes
            // Whenever something requests an IDatabase, they will get a Singleton of whatever the RegisterType is ( downcasted )
            containerBuilder.RegisterType<OrdinaryDatabase>().As<IDatabase>().SingleInstance();
            
            containerBuilder.RegisterType<ConfigurableRecordFinder>();

            using var container = containerBuilder.Build();

            // Retrieve an instance of configurable record finder
            // Autofac will automatically resolve the dependency injection in the constructor
            // using the registered type Ordinary Database ( can be swapped to DummyDatabase )
            var recordFinder = container.Resolve<ConfigurableRecordFinder>();
        }
    }
}