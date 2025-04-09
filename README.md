# TextUtilities

![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)
![NuGet](https://img.shields.io/nuget/v/TextUtilities)
![NuGet Downloads](https://img.shields.io/nuget/dt/TextUtilities.svg)
![.NET Version](https://img.shields.io/badge/.NET-9-purple.svg)

A simple yet useful .NET library for common text operations.  
Created as a learning project and published as a reusable utility package.

---

## ✨ Features

**TextUtilities** currently includes the following string-related methods:

- **`NormalizeSpaces(string input)`**  
  Removes extra spaces from a text and replaces them with single spaces.  
  _Example:_ `" This   is   a   test "` → `"This is a test"`

- **`ToTitleCase(string input)`**  
  Converts the first letter of each word to uppercase.  
  _Example:_ `"hello world"` → `"Hello World"`

- **`IsNumeric(string input)`**  
  Checks whether a string contains only numeric characters.  
  _Example:_ `"123"` → `true` | `"abc123"` → `false`

---
## 🔸Using .NET CLI:
```
dotnet add package TextUtilities
```
## ⚙️ Installation

You can install the package via **NuGet**:

### 🔸 Using Package Manager:
```
Install-Package TextUtilities
```
```powershell

using System;
using TextUtilities;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== NormalizeSpaces ===");
        string messy = " This   is   a   test ";
        Console.WriteLine(TextHelper.NormalizeSpaces(messy)); // Output: This is a test

        Console.WriteLine("\n=== ToTitleCase ===");
        string text = "salam hamed";
        Console.WriteLine(TextHelper.ToTitleCase(text)); // Output: Salam Hamed

        Console.WriteLine("\n=== IsNumeric ===");
        Console.WriteLine(TextHelper.IsNumeric("123"));     // Output: True
        Console.WriteLine(TextHelper.IsNumeric("hamed"));   // Output: False
    }
}
```

## 🛠 Target Framework
**.NET 9**

## 📦 NuGet Package
🔗 https://www.nuget.org/packages/TextUtilities/

## 📄 License
This project is licensed under the MIT License — free for personal and commercial use.
See the LICENSE file for more details.

## 👤 Author
Created with ❤️ by Hamed Heydarian
GitHub: https://github.com/hheydarian
