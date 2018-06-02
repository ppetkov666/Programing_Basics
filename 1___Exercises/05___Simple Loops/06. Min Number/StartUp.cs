namespace _06._Min_Number
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double min = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (input < min) min = input;
            }
            Console.WriteLine(min);
        }
    }
}
