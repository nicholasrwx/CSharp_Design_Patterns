using System.Text;

public class Building
{
    public List<Wall> Walls = [];

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var wall in Walls)
        {
            sb.AppendLine(wall.ToString());
        }
        return sb.ToString();
    }
}
