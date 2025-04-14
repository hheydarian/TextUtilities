namespace TextUtilities.Core;
public static class TextCleaner
{
    // Remove extra spaces between words
    public static string NormalizeSpaces(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        return string.Join(" ", input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
    }

    // Remove numbers from text
    public static string RemoveNumbers(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        return new string(input.Where(c => !char.IsDigit(c)).ToArray());
    }

    // Remove special characters
    public static string RemoveSpecialCharacters(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        return new string(input.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray());
    }

    //Remove the space at the beginning and end of each line in multi-line text
    public static string TrimAllLines(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        var lines = input.Split(Environment.NewLine);
        var trimmedLines = lines.Select(line => line.Trim());
        return string.Join(Environment.NewLine, trimmedLines);
    }
}
