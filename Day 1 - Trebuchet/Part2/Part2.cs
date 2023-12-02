using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1___Trebuchet.Part2
{
    internal class Part2
    {
        private static string[] letterDigits = new string[]
        {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine"
        };

        private static string[] digits = new string[]
        {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"
        };

        private static int GetFirstDigit(string line)
        {
            int lowestIndex = line.Length;
            int lowestNumber = 0;

            for (int i = 0; i < letterDigits.Length; i++)
            {
                int index = line.IndexOf(letterDigits[i]);

                if(index != -1 && index < lowestIndex)
                {
                    lowestIndex = index;
                    lowestNumber = i + 1;
                }
            }

            for (int i = 0; i < digits.Length; i++)
            {
                int index = line.IndexOf(digits[i]);

                if (index != -1 && index < lowestIndex)
                {
                    lowestIndex = index;
                    lowestNumber = i + 1;
                }
            }

            return lowestNumber;
        }

        private static int GetLastDigit(string line)
        {
            int maxIndex = -1;
            int number = 0;

            for (int i = 0; i < letterDigits.Length; i++)
            {
                int index = line.LastIndexOf(letterDigits[i]);

                if (index > maxIndex)
                {
                    maxIndex = index;
                    number = i + 1;
                }
            }

            for (int i = 0; i < digits.Length; i++)
            {
                int index = line.LastIndexOf(digits[i]);

                if (index > maxIndex)
                {
                    maxIndex = index;
                    number = i + 1;
                }
            }

            return number;
        }

        internal static int Solve(string fileName)
        {
            IEnumerable<string> lines = File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "Part2\\" + fileName);

            int sum = 0;
            foreach (string line in lines)
            {
                sum += GetFirstDigit(line) * 10 + GetLastDigit(line);
            }

            return sum;
        }
    }
}
