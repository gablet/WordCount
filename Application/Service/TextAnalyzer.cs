
namespace Application.Service
{

    public class TextAnalyzer
    {
        public async Task<Dictionary<string, int>> CountWordFrequency(string text)
        {
            var result = new Dictionary<string, int>();
            var substrings = text.Split(' ');

            foreach (var substring in substrings)
            {
                if (result.ContainsKey(substring))
                {
                    result[substring]++;
                }
                else
                {
                    result.Add(substring, 1);
                }
            }
            return result.OrderByDescending(x => x.Value).Take(10).ToDictionary();
        }
    }
}