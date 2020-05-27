using System;

namespace Day04_ClassVsInstance
{
    public class Person
    {
        public int _age;

        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");

                _age = 0;

                return;
            }

            _age = initialAge;
        }

        public void AmIOld()
        {
            if (_age < 13)
            {
                Console.WriteLine("You are young.");
                return;
            }

            if (_age < 18)
            {
                Console.WriteLine("You are a teenager.");
                return;
            }

            Console.WriteLine("You are old.");
        }

        public void YearPasses()
        {
            _age++;
        }
    }
}
