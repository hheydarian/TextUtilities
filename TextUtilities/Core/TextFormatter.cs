namespace TextUtilities.Core;
public class TextFormatter
{
    public static string ToTitleCase(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
    }
}
