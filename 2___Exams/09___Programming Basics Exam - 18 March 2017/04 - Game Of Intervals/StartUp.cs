namespace _04___Game_Of_Intervals
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double steps = double.Parse(Console.ReadLine());
            double sum = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;
            double sum6 = 0;
            for (int i = 1; i <= steps; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number >= 0 && number <= 9)
                {
                    number = 0.2 * number;
                    sum += number;
                    sum1++;
                }
                else if (number >= 10 && number <= 19)
                {
                    number = 0.3 * number;
                    sum += number;
                    sum2++;
                }
                else if (number >= 20 && number <= 29)
                {
                    number = 0.4 * number;
                    sum += number;
                    sum3++;
                }
                else if (number >= 30 && number <= 39)
                {
                    sum += 50;
                    sum4++;
                }
                if (number >= 40 && number <= 50)
                {
                    sum += 100;
                    sum5++;
                }
                else if (number < 0 || number > 50)
                {
                    sum = sum / 2;
                    sum6++;
                }
            }

            Console.WriteLine($"{sum:f2}");
            Console.WriteLine($"From 0 to 9: {(sum1 / steps) * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {(sum2 / steps) * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {(sum3 / steps) * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {(sum4 / steps) * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {(sum5 / steps) * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {(sum6 / steps) * 100:f2}%");
        }
    }
}
