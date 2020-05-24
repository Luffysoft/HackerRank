using System;

namespace Day01_DataTypes
{
    public static class Solution
    {
        public static void Print(string i0, string d0, string s0)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int i2;
            double d2;
            string s2;

            // Read and save an integer, double, and String to your variables.
            i2 = int.Parse(i0);
            d2 = double.Parse(d0);
            s2 = s0;

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + i2);

            // Print the sum of the double variables on a new line.
            Console.WriteLine($"{d + d2:F1}");

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + s2);
        }
    }
}
