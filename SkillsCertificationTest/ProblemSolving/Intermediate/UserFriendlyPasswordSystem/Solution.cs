using System.Collections.Generic;
using System.Linq;

namespace UserFriendlyPasswordSystem
{
    public static class Solution
    {
        private static readonly Dictionary<string, string> AuthorizationDictionary = new Dictionary<string, string>();

        public static List<int> AuthEvents(List<List<string>> events)
        {
            var result = new List<int>();

            string password = null;

            foreach (var evt in events)
            {
                switch (evt[0])
                {
                    case "setPassword":
                        password = evt[1];
                        AuthorizationDictionary.Clear();

                        break;

                    case "authorize":
                        var authorization = evt[1];
                        var isAuthorized = ComputeAuthorizations(password, authorization) ? 1 : 0;
                        result.Add(isAuthorized);

                        break;
                }
            }

            return result;
        }

        private static bool ComputeAuthorizations(string password, string authorization)
        {
            var result = ComputeAuthorization(password, authorization);
            if (result)
            {
                return true;
            }

            for (var c = 0; c < 128; c++)
            {
                var newPassword = password + (char)c;
                result = ComputeAuthorization(newPassword, authorization);
                if (result)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool ComputeAuthorization(string password, string authorization)
        {
            if (!AuthorizationDictionary.ContainsKey(password))
            {
                var hash = password
                    .Select((c, i) => c * Pow(131, password.Length - i - 1))
                    .Sum();
                hash %= 1_000_000_007;

                AuthorizationDictionary[password] = hash.ToString();
            }

            return AuthorizationDictionary[password] == authorization;
        }

        private static long Pow(long x, long y)
        {
            var result = 1L;

            for (long i = 0; i < y; i++)
            {
                result *= x;
            }

            return result;
        }
    }
}
