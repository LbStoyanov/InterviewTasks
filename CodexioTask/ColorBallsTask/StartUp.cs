namespace Task1
{
    class Ball
    {
        public Ball(string color, int count)
        {
            this.Color = color;
            this.Count = count;
        }

        public string Color { get; set; }
        public int Count { get; set; }

    }
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] allowedColors = new string[]
            {
                "red",
                "green",
                "blue",
                "yellow",
                "purple",
                "black",
                "white",
                "orange",
                "silver",
                "pink",
            };

            List<Ball> box = new List<Ball>();
            int totalBallsCount = 0;

            while (true)
            {
                Console.WriteLine("Please enter a color or \"End\" to finish the move: ");
                string color = Console.ReadLine();

                if (color == "End")
                {
                    break;
                }

                if (!allowedColors.Contains(color))
                {
                    Console.WriteLine("The color is invalid! Please enter a valid color: ");
                    continue;
                }

                Console.WriteLine("Please enter a ball count: ");
                int ballCount;
                string ballCountInput = Console.ReadLine();
                bool success = int.TryParse(ballCountInput, out ballCount);

                if (!success)
                {
                    while (!success)
                    {
                        Console.WriteLine("Invalid number of balls! Please enter a valid number: ");
                        ballCountInput = Console.ReadLine();
                        success = int.TryParse(ballCountInput, out ballCount);
                    }
                }

                Ball ball = new Ball(color, ballCount);
                totalBallsCount += ballCount;
                box.Add(ball);
            }


            var orderedBalls = box.OrderByDescending(b => b.Count).ToList();
            var result = totalBallsCount - orderedBalls[0].Count;

            Console.WriteLine($"You have to take out {result} balls, in order to have only one color of balls in the box!");
        }
    }
}