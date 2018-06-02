namespace _04._Sum_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine(sum);
        }
    }
}
