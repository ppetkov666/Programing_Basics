namespace _10._Radians_to_Degrees
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double radians = double.Parse(Console.ReadLine());
            double degree = Math.Round((radians * 180) / Math.PI);
            Console.WriteLine(degree);
        }
    }
}
