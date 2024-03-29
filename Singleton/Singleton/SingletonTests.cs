using NUnit.Framework;
using Singleton;

[TestFixture]
public class SingletonTests
{
    [Test]
    public void IsSingletonTest()
    {
        var db = SingletonDatabase.Instance;
        var db2 = SingletonDatabase.Instance;
        Assert.That(db, Is.SameAs(db2));
        Assert.That(SingletonDatabase.Count, Is.EqualTo(1));
    }

    [Test]
    public void SingletonTotalPopulationTest()
    {
        var recordFinder = new SingletonRecordFinder();
        var names = new[] { "Victoria", "Edmonton", "Ottawa" };
        int totalPopulation = recordFinder.GetTotalPopulation(names);
        Assert.That(totalPopulation, Is.EqualTo(289625 + 812129 + 712319));
    }
}