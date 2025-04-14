using TextUtilities.Core;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== test method NormalizeSpaces ===");
        string messyText = " This   is   a   test   text.";
        string cleanText = TextCleaner.NormalizeSpaces(messyText);
        Console.WriteLine(cleanText);

        Console.WriteLine("\n=== test method ToTitleCase ===");
        string lower = "salam hamed";
        string titled = TextFormatter.ToTitleCase(lower);
        Console.WriteLine(titled);

        Console.WriteLine("\n=== test method IsNumeric ===");
        Console.WriteLine(TextValidator.IsNumeric("123"));
        Console.WriteLine(TextValidator.IsNumeric("hello"));
    }
}
