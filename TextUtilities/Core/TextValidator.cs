namespace TextUtilities.Core;
public class TextValidator
{
    public static bool IsNumeric(string input)
    {
        return double.TryParse(input, out _);
    }
}
