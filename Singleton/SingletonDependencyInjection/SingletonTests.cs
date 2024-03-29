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
    }
}