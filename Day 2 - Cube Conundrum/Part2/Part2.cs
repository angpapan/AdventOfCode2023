namespace Day_2___Cube_Conundrum.Part2
{
    internal class Part2
    {
        internal static int Solve(string fileName)
        {
            List<string> lines = File
                .ReadLines(AppDomain.CurrentDomain.BaseDirectory + "Part2\\" + fileName)
                .ToList();

            int sum = 0;
            for (int i = 0; i < lines.Count(); i++)
            {
                string line = lines[i];
                string gameInfo= line.Split(':')[1];

                string[] tries = gameInfo.Split(';');
                bool valid = true;
                foreach(string attempt in tries)
                {
                    string[] balls = attempt.Split(',');
                    bool validAttempt = true;

                    foreach(string ball in balls)
                    {
                        string trimmedBall = ball.Trim();
                        string[] info = trimmedBall.Split(' ');
                        int ballsNumber = int.Parse(info[0]); 
                        string ballsColor = info[1];


                        switch (ballsColor)
                        {
                            case "red":
                                validAttempt = ballsNumber <= MaxValues.RED;
                                break;
                            case "green":
                                validAttempt = ballsNumber <= MaxValues.GREEN;
                                break;
                            case "blue":
                                validAttempt = ballsNumber <= MaxValues.BLUE;
                                break;
                        }

                        if (!validAttempt) break;
                    }

                    if (!validAttempt)
                    {
                        valid = false;
                        break;
                    }

                }

                if (valid) sum += i + 1;
            }

            return sum;
        }
    }
}
