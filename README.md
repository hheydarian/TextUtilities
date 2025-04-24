# TextUtilities

![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)
![NuGet](https://img.shields.io/nuget/v/TextUtilities)
![NuGet Downloads](https://img.shields.io/nuget/dt/TextUtilities.svg)
![.NET Version](https://img.shields.io/badge/.NET-9-purple.svg)

# TextUtilities 📝



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
```
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
```
using TextUtilities;

string result = new TextUtility("hello world")
    .NormalizePersian()
    .ToUpperCase()
    .Build();

Console.WriteLine(result);
```
2. Creating a URL-Friendly Slug
```
using TextUtilities;

string result = new TextUtility("Hello World! @#$")
    .ToSlug()
    .Build();

Console.WriteLine(result);
// Output: hello-world
```
3. Chaining Multiple Operations
```

```
