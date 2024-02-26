
namespace Application.Service
{

    public class TextAnalyzer
    {
        public Dictionary<string, int> CountWordFrequency(string[] substrings)
        {
            var result = new Dictionary<string, int>();


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