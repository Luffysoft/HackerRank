using System.Linq;
using System.Text;
using Common;

namespace Day06_LetSReview
{
    public static class Solution
    {
        public static string Solve(string s)
        {
            var sb = new StringBuilder(s.Length);

            var characters = s
                .Select((c, i) => new { Index = i, Item = c })
                .ToList();
            var evenCharacters = characters
                .Where(x => x.Index % 2 == 0)
                .Select(x => x.Item);
            var oddCharacters = characters
                .Where(x => x.Index % 2 == 1)
                .Select(x => x.Item);

            evenCharacters.ForEach(c => sb.Append(c));
            sb.Append(" ");
            oddCharacters.ForEach(c => sb.Append(c));

            return sb.ToString();
        }
    }
}
