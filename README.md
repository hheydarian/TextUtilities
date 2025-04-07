# TextUtilities

A lightweight .NET utility library for text processing and string manipulation.

## 🚀 Features

- Normalize Persian text
- Remove extra spaces
- Convert characters
- Ready-to-use extension methods

## 📦 Installation

You can install it via NuGet:

```bash
Install-Package TextUtilities
Or via .NET CLI:
dotnet add package TextUtilities

💻 Usage
using TextUtilities;

string text = "  سلام   دنیا ";
string result = text.NormalizeText();
Console.WriteLine(result);

🛠️ Requirements
.NET 6 or higher

📄 License
This project is licensed under the MIT License.
