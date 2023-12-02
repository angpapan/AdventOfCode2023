namespace Day_1___Trebuchet.Part1
{
    internal class Part1
    {
        private static int GetFirstDigit(string line)
        {
            foreach (char c in line)
            {
                int num;
                if (int.TryParse(c.ToString(), out num))
                {
                    return num;
                }
            }

            return 0;
        }

        private static int GetLastDigit(string line)
        {
            for (int i = line.Length - 1; i >= 0; i--)
            {
                int num;
                if (int.TryParse(line[i].ToString(), out num))
                {
                    return num;
                }
            }

            return 0;
        }

        internal static int Solve(string fileName)
        {
            IEnumerable<string> lines = File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "Part1\\" + fileName);

            int sum = 0;
            foreach (string line in lines)
            {
                sum += GetFirstDigit(line) * 10 + GetLastDigit(line);
            }

            return sum;
        }
    }
}
