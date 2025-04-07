using TextUtilities;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== تست متد NormalizeSpaces ===");
        string messyText = " This   is   a   test   text.";
        string cleanText = TextHelper.NormalizeSpaces(messyText);
        Console.WriteLine(cleanText);

        Console.WriteLine("\n=== test method ToTitleCase ===");
        string lower = "salam hamed";
        string titled = TextHelper.ToTitleCase(lower);
        Console.WriteLine(titled);

        Console.WriteLine("\n=== test method IsNumeric ===");
        Console.WriteLine(TextHelper.IsNumeric("123"));
        Console.WriteLine(TextHelper.IsNumeric("hamed"));
    }
}
