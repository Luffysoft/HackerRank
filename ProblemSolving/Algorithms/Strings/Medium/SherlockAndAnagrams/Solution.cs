using System.Collections.Generic;
using System.Linq;

namespace SherlockAndAnagrams
{
    public static class Solution
    {
        public static int SherlockAndAnagrams(string s)
        {
            var map = new Dictionary<char, int>(100);
            var result = 0;

            for (var i = 0; i < s.Length - 1; i++)
            {
                for (var j = 1; j <= s.Length - i - 1; j++)
                {
                    for (var k = i + 1; k < s.Length - j + 1; k++)
                    {
                        var success = true;

                        map.Clear();

                        for (var l = 0; l < j; l++)
                        {
                            if (!map.ContainsKey(s[i + l]))
                            {
                                map[s[i + l]] = 0;
                            }

                            map[s[i + l]]++;
                        }

                        for (var m = 0; m < j; m++)
                        {
                            if (!map.ContainsKey(s[k + m]))
                            {
                                success = false;
                                break;
                            }

                            map[s[k + m]]--;

                            if (map[s[k + m]] == 0)
                            {
                                map.Remove(s[k + m]);
                            }
                        }

                        if (success && !map.Keys.Any())
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }

        public static int SherlockAndAnagramsV2(string s)
        {
            var result = 0;

            for (var i = 0; i < s.Length - 1; i++)
            {
                for (var j = 1; j <= s.Length - i - 1; j++)
                {
                    for (var k = i + 1; k < s.Length - j + 1; k++)
                    {
                        var mask = new int[100];
                        var success = true;
                        var total = 0;

                        for (var l = 0; l < j; l++)
                        {
                            mask[s[i + l] - 'a']++;
                            total++;
                        }

                        for (var m = 0; m < j; m++)
                        {
                            if (mask[s[k + m] - 'a'] == 0)
                            {
                                success = false;
                                break;
                            }

                            mask[s[k + m] - 'a']--;
                            total--;
                        }

                        if (success && total == 0)
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
