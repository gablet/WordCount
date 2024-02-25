
namespace Application.Service
{

    public class CounterService
    {
        public async Task<Dictionary<string, int>> Count(string text)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

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
            return result.OrderBy(x => x.Value).Take(10).ToDictionary();
        }
    }
}