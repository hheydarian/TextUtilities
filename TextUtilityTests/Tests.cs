using TextUtilities;

namespace TextUtilityTests
{
    public class Tests
    {
        [Fact]
        public void ToTitleCase_ShouldCapitalizeWords()
        {
            var result = new TextUtility("hello world").ToTitleCase().Build();
            Assert.Equal("Hello World", result);
        }
        [Fact]
        public void IsNumeric_ShouldReturnTrueForNumbers()
        {
            var result = new TextUtility("123.45").IsNumeric();
            Assert.True(result);
        }

        [Fact]
        public void IsNumeric_ShouldReturnFalseForNonNumbers()
        {
            var result = new TextUtility("Hello").IsNumeric();
            Assert.False(result);
        }
        [Fact]
        public void RemoveSpaces_ShouldRemoveAllSpaces()
        {
            var result = new TextUtility("Hello World").RemoveSpaces().Build();
            Assert.Equal("HelloWorld", result);
        }

        [Fact]
        public void ToUpperCase_ShouldConvertToUpper()
        {
            var result = new TextUtility("Hello").ToUpperCase().Build();
            Assert.Equal("HELLO", result);
        }

        [Fact]
        public void NormalizePersian_ShouldReplaceArabicCharacters()
        {
            var result = new TextUtility("سلام كيفيت").NormalizePersian().Build();
            Assert.Equal("سلام کیفیت", result);
        }

        [Fact]
        public void ToSlug_ShouldCreateUrlFriendlyText()
        {
            var result = new TextUtility("Hello World!").ToSlug().Build();
            Assert.Equal("hello-world", result);
        }
        [Fact]
        public void ToSlug_ShouldHandleSpecialCharacters()
        {
            var result = new TextUtility("Hello!!World@123").ToSlug().Build();
            Assert.Equal("hello-world-123", result);
        }

        [Fact]
        public void ToSlug_ShouldHandleMultipleSpaces()
        {
            var result = new TextUtility("Hello   World").ToSlug().Build();
            Assert.Equal("hello-world", result);
        }

        [Fact]
        public void ReverseWords_ShouldReverseWordOrder()
        {
            var result = new TextUtility("Hello World").ReverseWords().Build();
            Assert.Equal("World Hello", result);
        }

        [Fact]
        public void WordCount_ShouldReturnCorrectCount()
        {
            var result = new TextUtility("Hello World").WordCount();
            Assert.Equal(2, result);
        }

        [Fact]
        public void Reset_ShouldRevertToOriginalText()
        {
            var result = new TextUtility("Hello")
                .RemoveSpaces()
                .ToBold()
                .Reset()
                .Build();
            Assert.Equal("Hello", result);
        }
    }
}
