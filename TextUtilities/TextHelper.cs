namespace TextUtilities;

public class TextHelper
{
    //Remove extra spaces from text
    public static string NormalizeSpaces(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        return string.Join(" ", input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
    }

    // Convert the first letter of each word to uppercase.
    public static string ToTitleCase(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
    }

    // Checking whether a string contains only numbers
    public static bool IsNumeric(string input)
    {
        return double.TryParse(input, out _);
    }
}
