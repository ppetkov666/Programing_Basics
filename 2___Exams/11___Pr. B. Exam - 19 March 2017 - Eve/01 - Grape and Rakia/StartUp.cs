namespace _01___Grape_and_Rakia
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double squareVineyard = double.Parse(Console.ReadLine());
            double kgPerMeter = double.Parse(Console.ReadLine());
            double badPart = double.Parse(Console.ReadLine());
            double vine = (squareVineyard * kgPerMeter) - badPart;
            double forRakia = (vine * 0.45) / 7.5;
            double incomeFromRakia = forRakia * 9.8;
            double forsale = (vine * 0.55) * 1.5;
            Console.WriteLine($"{incomeFromRakia:f2}");
            Console.WriteLine($"{forsale:f2}");
        }
    }
}
