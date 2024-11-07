namespace TextFormatting;

public class BetterFormattedText
{
    private string plainText;
    private List<TextRange> formatting = new List<TextRange>();

    public BetterFormattedText(string plainText)
    {
        this.plainText = plainText;
    }

    public TextRange GetRange(int start, int end)
    {
        var range = new TextRange { Start = start, End = end };
        formatting.Add(range);
        return range;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        for (var i = 0; i < plainText.Length; i++)
        {
            var c = plainText[i];
            
            // Check if a TextRange ( start to end ) covers a characters index and uppercase it
            foreach (var range in formatting)
            {
                if (range.Covers(i) && range.Capitalize)
                    c = char.ToUpper(c);
            }

            sb.Append(c);
        }
        return sb.ToString();
    }
}