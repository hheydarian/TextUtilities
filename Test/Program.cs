using TextUtilities;

class Program
{
    static void Main()
    {
        // تست ReplaceRegex
        string result1 = new TextUtility("Hello123World456")
            .ReplaceRegex("[0-9]+", "X")
            .Build();
        Console.WriteLine($"Test 1: {result1}"); // خروجی: HelloXWorldX

        // تست Trim
        string result2 = new TextUtility("   Hello World!   ")
            .Trim()
            .ToBold()
            .Build();
        Console.WriteLine($"Test 2: {result2}"); // خروجی: <b>Hello World!</b>
    }
}