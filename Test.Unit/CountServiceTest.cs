using Application.Service;

namespace Test.Unit;

public class CountServiceTest
{
    [Fact]
    public async void TestCountCorrectResult()
    {
        //-------SETUP------
        string text = "Dog Cat Rat Dog Monkey Lion Rat";
        TextAnalyzer analyzer = new TextAnalyzer();

        // ---- EXECUTE -----
        var result = await analyzer.CountWordFrequency(text);

        //-----VALIDATE-------

        Assert.Equal(5, result.Count);
        Assert.Equal(2, result["Dog"]);
    }

    [Fact]
    public async void TestCountCorrectResultMoreThan10Words()
    {
        //-------SETUP------
        string text = "Dog Cat Rat Dog Monkey Lion Rat Mouse Mouse Mouse Fish Bird Sealion Whale Zebra Elephant";
        TextAnalyzer analyzer = new TextAnalyzer();

        // ---- EXECUTE -----
        var result = await analyzer.CountWordFrequency(text);

        //-----VALIDATE-------
        Assert.Equal(10, result.Count);

    }
}