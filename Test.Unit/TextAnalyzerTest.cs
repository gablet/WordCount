using Application.Service;

namespace Test.Unit;

public class TextAnalyzerTest
{
    [Fact]
    public void TestCountCorrectResult()
    {
        string text = "Dog Cat Rat Dog Monkey Lion Rat";
        var substrings = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        TextAnalyzer analyzer = new TextAnalyzer();

        var result = analyzer.CountWordFrequency(substrings);

        Assert.Equal(5, result.Count);
        Assert.Equal(2, result["Dog"]);
    }

    [Fact]
    public void TestCountCorrectResultMoreThan10Words()
    {
        string text = "Dog Cat Rat Dog Monkey Lion Rat Mouse Mouse Mouse Fish Bird Sealion Whale Zebra Elephant";
        var substrings = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        TextAnalyzer analyzer = new TextAnalyzer();

        var result = analyzer.CountWordFrequency(substrings);

        Assert.Equal(10, result.Count);

    }
}