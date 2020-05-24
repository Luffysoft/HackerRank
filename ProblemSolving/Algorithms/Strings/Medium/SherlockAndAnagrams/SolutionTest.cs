using System;
using System.Diagnostics;
using NUnit.Framework;

namespace SherlockAndAnagrams
{
    public class SolutionTest
    {
        [TestCase("mom", 2)]
        [TestCase("abba", 4)]
        [TestCase("abcd", 0)]
        [TestCase("ifailuhkqq", 3)]
        [TestCase("kkkk", 10)]
        [TestCase("cdcd", 5)]
        [TestCase("ifailuhkqqhucpoltgtyovarjsnrbfpvmupwjjjfiwwhrlkpekxxnebfrwibylcvkfealgonjkzwlyfhhkefuvgndgdnbelgruel", 399)]
        [TestCase("gffryqktmwocejbxfidpjfgrrkpowoxwggxaknmltjcpazgtnakcfcogzatyskqjyorcftwxjrtgayvllutrjxpbzggjxbmxpnde", 471)]
        [TestCase("mqmtjwxaaaxklheghvqcyhaaegtlyntxmoluqlzvuzgkwhkkfpwarkckansgabfclzgnumdrojexnrdunivxqjzfbzsodycnsnmw", 370)]
        [TestCase("ofeqjnqnxwidhbuxxhfwargwkikjqwyghpsygjxyrarcoacwnhxyqlrviikfuiuotifznqmzpjrxycnqktkryutpqvbgbgthfges", 403)]
        [TestCase("zjekimenscyiamnwlpxytkndjsygifmqlqibxxqlauxamfviftquntvkwppxrzuncyenacfivtigvfsadtlytzymuwvpntngkyhw", 428)]
        public void Test(string s, int expected)
        {
            var sw = Stopwatch.StartNew();
            sw.Start();

            var actual = Solution.SherlockAndAnagramsV2(s);

            sw.Stop();

            Console.WriteLine($"{sw.Elapsed.TotalMilliseconds}");

            Assert.AreEqual(expected, actual);
        }
    }
}
