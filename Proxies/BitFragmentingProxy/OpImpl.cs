namespace BitFragmentingProxy;

public static class OpImpl
{
    static OpImpl()
    {
        var type = typeof(Op);
        foreach (Op op in Enum.GetValues(type))
        {
            MemberInfo[] memInfo = type.GetMember(op.ToString());
            if (memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes(
                    typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                {
                    opNames[op] = ((DescriptionAttribute) attrs[0]).Description[0];
                }
            }
        }
    }

    private static readonly Dictionary<Op, char> opNames
        = new Dictionary<Op, char>();
    
    // notice the data types!
    // Func<double, double, double> is a delegate type in C# that represents a method or function
    // that takes two parameters of type double and returns a value of type double.
    private static readonly Dictionary<Op, Func<double, double, double>> opImpl =
        new Dictionary<Op, Func<double, double, double>>() {
            [Op.Mul] = ((x, y) => x * y),
            [Op.Div] = ((x, y) => x / y),
            [Op.Add] = ((x, y) => x + y),
            [Op.Sub] = ((x, y) => x - y),
        };

    public static double Call(this Op op, int x, int y)
    {
        return opImpl[op](x, y);
    }

    public static char Name(this Op op)
    {
        return opNames[op];
    }
}