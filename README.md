# 📝TextUtilities 


![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)
![NuGet](https://img.shields.io/nuget/v/TextUtilities)
![NuGet Downloads](https://img.shields.io/nuget/dt/TextUtilities.svg)
![.NET Version](https://img.shields.io/badge/.NET-9-purple.svg)





**TextUtilities** is a **fluent**, **lightweight**, and **powerful** .NET library designed for advanced text manipulation. Whether you're normalizing Persian text, creating URL-friendly slugs, formatting text with HTML or Markdown, or performing complex string operations, TextUtilities offers an intuitive Fluent API to make your code clean and efficient.

---

## ✨ Features

- **Fluent API**: Chain methods for readable and maintainable code.
- **Multilingual Support**: Normalize Persian/Arabic characters (e.g., converting `ي` to `ی` or `ك` to `ک`).
- **Text Formatting**: Add HTML/Markdown bold tags, prefixes, or perform regex-based replacements.
- **Advanced Text Operations**: Create URL slugs, reverse text or words, count words, and more.
- **Lightweight**: Minimal dependencies, optimized for performance.
- **Reliable**: Fully tested with xUnit to ensure quality and stability.
- **Cross-Platform**: Built for .NET 9.0, compatible with modern .NET applications.

---

## 📦 Installation

To use TextUtilities in your project, install it via NuGet:

```bash
dotnet add package TextUtilities --version 1.0.1
```
Or, if you prefer using the Package Manager Console:
```
Install-Package TextUtilities -Version 1.0.1
```

## 🚀Quick Start
Get started with TextUtilities in just a few lines of code:
```c#
using TextUtilities;

string result = new TextUtility("Hello World!")
    .RemoveSpaces()
    .ToBold()
    .AddPrefix("Output: ")
    .Build();

Console.WriteLine(result);
// Output: Output: <b>HelloWorld!</b>
```
## 🛠️Usage Examples
Below are some practical examples to demonstrate the power of TextUtilities:
1. Normalizing Persian Text
```c#
using TextUtilities;

string result = new TextUtility("hello world")
    .NormalizePersian()
    .ToUpperCase()
    .Build();

Console.WriteLine(result);
```
2. Creating a URL-Friendly Slug
```c#
using TextUtilities;

string result = new TextUtility("Hello World! @#$")
    .ToSlug()
    .Build();

Console.WriteLine(result);
// Output: hello-world
```
3. Chaining Multiple Operations
```c#
using TextUtilities;

string result = new TextUtility("This is a TEST string!")
    .ToLowerCase()
    .RemoveSpaces()
    .ToMarkdownBold()
    .ToSlug()
    .AddPrefix("Slug: ")
    .Build();

Console.WriteLine(result);
// Output: Slug: **thisisateststring**
```
4. Reversing Words and Counting
```c#
using TextUtilities;

string text = "Hello Beautiful World";
var utility = new TextUtility(text);

string reversed = utility.ReverseWords().Build();
int wordCount = utility.WordCount();

Console.WriteLine($"Reversed: {reversed}");
Console.WriteLine($"Word Count: {wordCount}");
// Output:
// Reversed: World Beautiful Hello
// Word Count: 3
```
5. Resetting Text
```c#
using TextUtilities;

var utility = new TextUtility("Hello World");
string modified = utility.ToSlug().Build(); // hello-world
string reset = utility.Reset().ToBold().Build(); // <b>Hello World</b>

Console.WriteLine($"Modified: {modified}");
Console.WriteLine($"Reset: {reset}");
// Output:
// Modified: hello-world
// Reset: <b>Hello World</b>
```
6. Regex Replacement
```c#
using TextUtilities;

string result = new TextUtility("Hello123World456")
    .ReplaceRegex("[0-9]+", "X")
    .Build();

Console.WriteLine(result);
// Output: HelloXWorldX
```
## 🧪Testing

TextUtilities is thoroughly tested using xUnit to ensure reliability. To run the tests locally:
+ Clone the repository:
```bash
git clone https://github.com/hheydarian/TextUtilities.git
```
+ Navigate to the project directory:
```bash
cd TextUtilities
```
+ Run the tests:
```bash
dotnet test
```
All 9+ unit tests should pass, covering key functionality.
---
## 🤝Contributing

We welcome contributions to make TextUtilities even better! To contribute:

+ Fork the repository.

+ Create a new branch:
```bash
git checkout -b feature/YourFeature
```
+ Make your changes and commit:
```bash
git commit -m 'Add some feature'
```
+ Push to your branch:
```bash
git push origin feature/YourFeature
```
+ Open a Pull Request on GitHub.

Please ensure your code follows the existing style, includes unit tests, and passes all checks.

## 📄License

This project is licensed under the MIT License (LICENSE). See the LICENSE file for details.

## 📭Contact & Support

+ Author: Hamed Heydarian

+ GitHub: [hheydarian](https://github.com/hheydarian "hheydarian")

+ NuGet: [TextUtilities](https://www.nuget.org/packages/TextUtilities/ "TextUtilities")

+ Issues: Report bugs or suggest features on GitHub Issues

For questions or feedback, feel free to open an issue or reach out!

---

## ⭐Enjoying TextUtilities? Give it a star on [GitHub](https://github.com/hheydarian/TextUtilities "GitHub")!⭐
Thank you for using TextUtilities!🚀








