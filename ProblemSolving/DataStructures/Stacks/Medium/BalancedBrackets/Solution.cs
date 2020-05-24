using System.Collections.Generic;
using System.Linq;

namespace BalancedBrackets
{
    public static class Solution
    {
        private static readonly IDictionary<char, char> OpeningBracketMapping =
            new Dictionary<char, char>
            {
                {'(', ')'},
                {'{', '}'},
                {'[', ']'}
            };

        private static readonly IDictionary<char, char> ClosingBracketMapping =
            new Dictionary<char, char>
            {
                {')', '('},
                {'}', '{'},
                {']', '['}
            };

        public static string IsBalanced(string s)
        {
            return IsBalancedWithResult(s) ? "YES" : "NO";
        }

        public static bool IsBalancedWithResult(string s)
        {
            var stack = new Stack<char>();

            foreach (var bracket in s)
            {
                if (OpeningBracketMapping.ContainsKey(bracket))
                {
                    stack.Push(bracket);
                    continue;
                }

                if (!ClosingBracketMapping.ContainsKey(bracket) || !stack.Any() || stack.Peek() != ClosingBracketMapping[bracket])
                {
                    return false;
                }

                stack.Pop();
            }

            return !stack.Any();
        }
    }
}
