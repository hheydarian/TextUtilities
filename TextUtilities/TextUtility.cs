using System.Text.RegularExpressions;
namespace TextUtilities;

///<summary>
/// A utility class for manipulating text in a fluent and chainable way.
///</summary>
public class TextUtility
{
    private string _text;
    private readonly string _originalText;

    /// <summary>
    /// Initializes a new instance of the <see cref="TextUtility"/> class.
    /// </summary>
    /// <param name="text">The input text to manipulate.</param>
    /// <exception cref="ArgumentNullException">Thrown when text is null.</exception>
    public TextUtility(string text)
    {
        _text = text ?? throw new ArgumentNullException(nameof(text));
        _originalText = text; // Keep original for reset
    }

    #region Basic Text Processing

    /// <summary>
    /// Removes all spaces from the text.
    /// </summary>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility RemoveSpaces()
    {
        _text = _text.Replace(" ", "");
        return this;
    }
    /// <summary>
    /// Converts the text to title case (first letter of each word capitalized).
    /// </summary>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility ToTitleCase()
    {
        _text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_text.ToLower());
        return this;
    }
    /// <summary>
    /// Checks if the text represents a numeric value.
    /// </summary>
    /// <returns>True if the text is numeric, otherwise false.</returns>
    public bool IsNumeric()
    {
        return double.TryParse(_text, out _);
    }
    /// <summary>
    /// Removes specified characters from the text.
    /// </summary>
    /// <param name="characters">Characters to remove.</param>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility RemoveCharacters(params char[] characters)
    {
        foreach (var c in characters)
        {
            _text = _text.Replace(c.ToString(), "");
        }
        return this;
    }

    /// <summary>
    /// Converts the text to uppercase.
    /// </summary>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility ToUpperCase()
    {
        _text = _text.ToUpper();
        return this;
    }

    /// <summary>
    /// Converts the text to lowercase.
    /// </summary>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility ToLowerCase()
    {
        _text = _text.ToLower();
        return this;
    }

    /// <summary>
    /// Trims whitespace from the start and end of the text.
    /// </summary>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility Trim()
    {
        _text = _text.Trim();
        return this;
    }

    #endregion

    #region Formatting

    /// <summary>
    /// Wraps the text in HTML bold tags.
    /// </summary>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility ToBold()
    {
        _text = $"<b>{_text}</b>";
        return this;
    }

    /// <summary>
    /// Wraps the text in Markdown bold syntax.
    /// </summary>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility ToMarkdownBold()
    {
        _text = $"**{_text}**";
        return this;
    }

    /// <summary>
    /// Adds a prefix to the text.
    /// </summary>
    /// <param name="prefix">The prefix to add.</param>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility AddPrefix(string prefix)
    {
        _text = $"{prefix}{_text}";
        return this;
    }

    /// <summary>
    /// Replaces text using a regular expression.
    /// </summary>
    /// <param name="pattern">The regex pattern to match.</param>
    /// <param name="replacement">The replacement string.</param>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility ReplaceRegex(string pattern, string replacement)
    {
        _text = Regex.Replace(_text, pattern, replacement);
        return this;
    }

    #endregion

    #region Unicode and Multilingual Support

    /// <summary>
    /// Normalizes Persian/Arabic characters (e.g., converts ي to ی).
    /// </summary>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility NormalizePersian()
    {
        _text = _text.Replace("ي", "ی").Replace("ك", "ک");
        return this;
    }

    #endregion

    #region Advanced Operations

    /// <summary>
    /// Reverses the entire text.
    /// </summary>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility Reverse()
    {
        _text = new string(_text.Reverse().ToArray());
        return this;
    }

    /// <summary>
    /// Reverses the order of words in the text.
    /// </summary>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility ReverseWords()
    {
        var words = _text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        _text = string.Join(" ", words.Reverse());
        return this;
    }

    /// <summary>
    /// Converts the text to a URL-friendly slug.
    /// </summary>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility ToSlug()
    {
        _text = Regex.Replace(_text.ToLower(), "[^a-z0-9]+", "-")
                     .Trim('-');
        return this;
    }

    /// <summary>
    /// Counts the number of words in the text.
    /// </summary>
    /// <returns>The number of words.</returns>
    public int WordCount()
    {
        return _text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }

    #endregion

    #region Utility

    /// <summary>
    /// Resets the text to its original state.
    /// </summary>
    /// <returns>The current instance for method chaining.</returns>
    public TextUtility Reset()
    {
        _text = _originalText;
        return this;
    }

    /// <summary>
    /// Returns the final manipulated text.
    /// </summary>
    /// <returns>The manipulated text.</returns>
    public string Build()
    {
        return _text;
    }

    #endregion
}
