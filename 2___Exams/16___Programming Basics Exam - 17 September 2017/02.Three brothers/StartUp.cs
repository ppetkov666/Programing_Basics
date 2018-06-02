namespace _02.Three_brothers
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        { 
            double bigBrother = double.Parse(Console.ReadLine());
            double middleBrother = double.Parse(Console.ReadLine());
            double youngBrother = double.Parse(Console.ReadLine());
            double father = double.Parse(Console.ReadLine());

            double totalTime = 1 / (1 / bigBrother + 1 / middleBrother + 1 / youngBrother);
            double timeWithRest = totalTime * 1.15;
            Console.WriteLine($"Cleaning time: {timeWithRest:F2}");
            double restTimeFather = father - timeWithRest;
            if (restTimeFather > 0)

            {
                restTimeFather = Math.Truncate(restTimeFather);
                Console.WriteLine($"Yes, there is a surprise - time left -> {restTimeFather} hours.");
            }
            else if (restTimeFather <= 0)
            {
                double restTimeFather2 = Math.Ceiling(timeWithRest - father);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {restTimeFather2} hours.");
            }
        }
    }
}
