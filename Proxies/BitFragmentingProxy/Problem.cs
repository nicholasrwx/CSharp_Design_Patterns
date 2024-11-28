namespace BitFragmentingProxy;

public class Problem
{
    private readonly List<int> numbers;
    private readonly List<Op> ops;

    public Problem(IEnumerable<int> numbers, IEnumerable<Op> ops)
    {
        this.numbers = new List<int>(numbers);

        // list of ops ( [op.Mul, op.Div, op.Add, op.Sub] ) determined from a TwoBitSet operation
        this.ops = new List<Op>(ops);
    }


    // The Evaluation method makes sure we evaluate the math correctly.
    // It performs multiplication first and division, then it moves to addition and subtraction.
    // This is the purpose of the opGroups array of arrays
    public int Eval()
    {
        var opGroups = new[]
        {
            new[] {Op.Mul, Op.Div},
            new[] {Op.Add, Op.Sub}
        };
        startAgain:
        foreach (var group in opGroups)
        {
            for (var idx = 0; idx < ops.Count; ++idx)
            {
                // checks if first opGroup contains one of the operations on the op list to perfom div and mul
                // then checks if second opGroup contains one of the operations on the op list to perform add and sub
                if (group.Contains(ops[idx]))
                {
                    // evaluate value
                    var op = ops[idx];
                    var result = op.Call(numbers[idx], numbers[idx + 1]);

                    // assume all fractional results are wrong
                    if (result != (int) result)
                        return int.MinValue; // calculation won't work

                    // replace the first number in the calculation,
                    // in the numbers array, with the result of the operation performed
                    numbers[idx] = (int)result;
                    
                    // remove the second number in the array which was used in the calculation 
                    numbers.RemoveAt(idx + 1);
                    
                    // remove the operation performed from the ops array
                    ops.RemoveAt(idx);
                    
                    // when the numbers have all been calculated within the array,
                    // only the result is left, return this resulting value.
                    if (numbers.Count == 1) return numbers[0];

                    goto startAgain; // :) -> this is kind of an imitation of a loop
                }
            }
        }

        return numbers[0];
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        int i = 0;
      
        for (; i < ops.Count; ++i)
        {
            sb.Append(numbers[i]);
            sb.Append(ops[i].Name());
        }

        sb.Append(numbers[i]);
        return sb.ToString();
    }
}