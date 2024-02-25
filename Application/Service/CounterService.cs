
namespace Application.Service
{
    public class CounterService
    {
        public Dictionary<string, int> Count(string text)
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

            result.OrderBy(x => x.Value);
            if (result.Count > 10)
            {
                return result.Take(10).ToDictionary();
            }

            return result;
            
        }
    }
}