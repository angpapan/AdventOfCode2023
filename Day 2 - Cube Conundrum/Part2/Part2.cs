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
                int maxRed = 0;
                int maxGreen = 0;
                int maxBlue = 0;

                foreach(string attempt in tries)
                {
                    string[] balls = attempt.Split(',');

                    foreach (string ball in balls)
                    {
                        string trimmedBall = ball.Trim();
                        string[] info = trimmedBall.Split(' ');
                        int ballsNumber = int.Parse(info[0]); 
                        string ballsColor = info[1];


                        switch (ballsColor)
                        {
                            case "red":
                                if(ballsNumber > maxRed) maxRed = ballsNumber;
                                break;
                            case "green":
                                if (ballsNumber > maxGreen) maxGreen = ballsNumber;
                                break;
                            case "blue":
                                if (ballsNumber > maxBlue) maxBlue = ballsNumber;
                                break;
                        }
                    }
                }
                sum += maxRed * maxGreen * maxBlue;
            }

            return sum;
        }
    }
}
