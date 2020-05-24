using System.Linq;

namespace RepeatedString
{
    public static class Solution
    {
        private const char RepeatedCharacter = 'a';

        public static long RepeatedString(string message, long n)
        {
            var frequency = n / message.Length;
            var remaining = (int)(n % message.Length);
            return frequency * GetRepetitionCount(message) +
                   GetRepetitionCount(message.Substring(0, remaining));
        }

        private static int GetRepetitionCount(string message)
        {
            return message.Count(c => c == RepeatedCharacter);
        }
    }
}
