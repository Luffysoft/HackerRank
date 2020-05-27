using NUnit.Framework;

namespace Day04_ClassVsInstance
{
    public class SolutionTest
    {
        [TestCase(-1)]
        [TestCase(10)]
        [TestCase(16)]
        [TestCase(18)]
        public void Test(int initialAge)
        {
            var person = new Person(initialAge);

            person.AmIOld();

            for (var j = 0; j < 3; j++)
            {
                person.YearPasses();
            }

            person.AmIOld();

            Assert.Pass();
        }
    }
}
