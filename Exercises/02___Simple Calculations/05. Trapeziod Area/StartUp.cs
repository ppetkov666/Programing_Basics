namespace _05._Trapeziod_Area
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double trapeziusArea = (b1 + b2) * h / 2;
            Console.WriteLine("Trapezoid area = {0}", trapeziusArea);
        }
    }
}
