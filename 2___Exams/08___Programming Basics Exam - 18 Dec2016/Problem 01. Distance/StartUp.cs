using System;

namespace Problem_01._Distance
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double initialSpeed = int.Parse(Console.ReadLine());
            double timeOne = int.Parse(Console.ReadLine());
            double timeTwo = int.Parse(Console.ReadLine());
            double timeThree = int.Parse(Console.ReadLine());

            double timeOneInMin = timeOne / 60;
            double timeTwoInMin = timeTwo / 60;
            double timeThreeInMin = timeThree / 60;

            double firstBeforeIncrease = initialSpeed * timeOneInMin;

            double afterIncrease = (initialSpeed * 1.1);
            double afterIncreaseDistance = afterIncrease * timeTwoInMin;

            double afterDecrease = afterIncrease * 0.95;
            double afterDecreaseDistance = afterDecrease * timeThreeInMin;

            double sum = firstBeforeIncrease + afterIncreaseDistance + afterDecreaseDistance;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
