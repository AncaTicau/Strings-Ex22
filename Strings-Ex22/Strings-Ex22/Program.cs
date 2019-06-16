using System;
using System.Text;

namespace Strings_Ex22
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "This is a string and it is awesome.";
            Console.WriteLine(CapitalizeFirstAndLastLetters(input));
        }

        //Write a method to capitalize first and last letters of each word of a given string.
        public static string CapitalizeFirstAndLastLetters(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (!char.IsLetter(input[i]))
                {
                    result.Append(input[i]);
                    continue;
                }

                char currentChar = input[i];

                if (i == 0 || !char.IsLetter(input[i - 1]))
                {
                    result.Append(char.ToUpper(currentChar));
                    continue;
                }

                if (i == input.Length - 1 || !char.IsLetter(input[i + 1]))
                {
                    result.Append(char.ToUpper(currentChar));
                    continue;
                }

                result.Append(input[i]);
            }

            return result.ToString();
        }
    }
}


