using NUnit.Framework;

namespace Day08_DictionariesAndMaps
{
    public class PhoneBookTest
    {
        private PhoneBook _phoneBook;

        [SetUp]
        public void SetUp()
        {
            _phoneBook = new PhoneBook
            {
                ["sam"] = "99912222",
                ["tom"] = "11122222",
                ["harry"] = "12299933"
            };
        }

        [TestCase("sam", "99912222")]
        [TestCase("edward", null)]
        [TestCase("harry", "12299933")]
        public void Test(string name, string expected)
        {
            var actual = _phoneBook[name];

            Assert.AreEqual(expected, actual);
        }
    }
}
