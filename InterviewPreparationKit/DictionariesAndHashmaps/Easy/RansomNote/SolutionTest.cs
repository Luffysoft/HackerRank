using NUnit.Framework;

namespace RansomNote
{
    public class SolutionTest
    {
        [TestCase(new[] { "Attack", "at", "dawn" }, new[] { "attack", "at", "dawn" }, false)]
        [TestCase(new[] { "give", "me", "one", "grand", "today", "night" }, new[] { "give", "one", "grand", "today" }, true)]
        [TestCase(new[] { "two", "times", "three", "is", "not", "four" }, new[] { "two", "times", "two", "is", "four" }, false)]
        [TestCase(new[] { "ive", "got", "a", "lonely", "bunch", "of", "coconuts" }, new[] { "ive", "got", "some", "coconuts" }, false)]
        public void Test(string[] magazine, string[] note, bool expected)
        {
            var actual = Solution.CheckMagazineWithResult(magazine, note);

            Assert.AreEqual(expected, actual);
        }
    }
}
