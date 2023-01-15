using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = WordParser("Creativity is thinking-up new things. Innovation is doing new things!");
            Console.WriteLine(output);
            // expected: C6y is t4g-up n1w t4s. I6n is d3g n1w t4s!
        }

        public static string WordParser(string input)
        {
            string[] words = input.Split(new char[] {' ', '-', '.', '!' });

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int distinctChars = word.Distinct().Count() - 2;
                if (distinctChars == 0|| word == string.Empty)
                {
                    continue;
                }
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];

                words[i] = firstLetter + distinctChars.ToString() + lastLetter;
            }

            string result = string.Join(" ", words);
            Console.WriteLine(result);
            return result;
        }
    }
}
