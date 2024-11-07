namespace TextFormatting;

public class FormattedText
{
    
    private readonly string plainText;
    private bool[] capitalize;

    public FormattedText(string plainText)
    {
        this.plainText = plainText;
        capitalize = new bool[plainText.Length];
    }

    public void Capitalize(int start, int end)
    {
        for (int i = start; i <= end; i++)
            capitalize[i] = true;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        for (var index = 0; index < plainText.Length; index++)
        {
            var c = plainText[index];
            sb.Append(capitalize[index] ? char.ToUpper(c) : c);
        }
        return sb.ToString();
    }
}