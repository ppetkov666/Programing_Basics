namespace _08.Metric_Converter
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double dist = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "mm") dist /= 1000;
            if (input == "cm") dist /= 100;
            if (input == "mi") dist /= 0.000621371192;
            if (input == "in") dist /= 39.3700787;
            if (input == "km") dist /= 0.001;
            if (input == "ft") dist /= 3.2808399;
            if (input == "yd") dist /= 1.0936133;

            if (output == "mm") dist *= 1000;
            if (output == "cm") dist *= 100;
            if (output == "mi") dist *= 0.000621371192;
            if (output == "in") dist *= 39.3700787;
            if (output == "km") dist *= 0.001;
            if (output == "ft") dist *= 3.2808399;
            if (output == "yd") dist *= 1.0936133;

            Console.WriteLine(Math.Round(dist, 8));
        }
    }
}
