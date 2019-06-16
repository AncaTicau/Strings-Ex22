using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "ala bala portocala";
            string occurence = "ala";
            Console.WriteLine(CountOccurrencesOfASubstring(givenString, occurence));
        }
        public static int CountOccurrencesOfASubstring(string input, string findOccurence)
        {
            int index = 0;
            int count = 0;
            int length = input[index];
            while ((index = input.IndexOf(findOccurence, index)) >= 0)
            {
                index += length; count++;
            }
            return count;
        }
    }
}
