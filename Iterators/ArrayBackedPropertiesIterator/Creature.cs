// Turns creature into an enumerable object where the values come from the stats array  
public class Creature : IEnumerable<int>
  {
    // This is how you can enumerate properties, by using array backed properties, then enumerating it
    private int [] stats = new int[3];

    private const int strength = 0;

    // Allows you to set the individual stats in the array by index
    public int Strength
    {
      get => stats[strength];
      set => stats[strength] = value;
    }

    public int Agility { get; set; }
    public int Intelligence { get; set; }

    public double AverageStat => 
      stats.Average();

    // Enumerates the stats array so it can be used in a foreach loop
    public IEnumerator<int> GetEnumerator()
    {
      return stats.AsEnumerable().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    //Allows you to access the individual stats by index
    public int this[int index]
    {
      get { return stats[index]; }
      set { stats[index] = value; }
    }
  }