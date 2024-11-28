var numbers = new[] {1, 3, 5, 7};
int numberOfOps = numbers.Length - 1;

// Loop runs 11 times... from 0 -> 10
for (int result = 0; result <= 10; ++result)
{
  for (var key = 0UL; key < (1UL << 2*numberOfOps); ++key)
  {
    // Creates a twobit set with each binary key
    var tbs = new TwoBitSet(key);

    // Finds the operations to perform for each key
    // Casts those integers to it's operational value in the enum Op
    // THE tbs INDEXER is the PROXY.. it treats a 64 value string as a 32 value string
    // by way of bit shifting / bitwise operations
    // It has the same interface as any other indexer
    // but internally knows to treat each index position as 2 positions in the byte string, instead of just 1 
    var ops = Enumerable.Range(0, numberOfOps)
      .Select(i => tbs[i]).Cast<Op>().ToArray();
    
    // Creates a Problem with the numbers and operations to perform
    var problem = new Problem(numbers, ops);
    
    // Checks if the result of the problem matches the result of the loop
    if (problem.Eval() == result)
    {
      Console.WriteLine($"{new Problem(numbers, ops)} = {result}");
      break;
    }
  }
}

Console.ReadKey();
