namespace _11._USD_to_BGN
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double usd = double.Parse(Console.ReadLine());
            double lev = Math.Round((usd * 1.79549), 2);
            Console.WriteLine($"{lev} BGN");
        }
    }
}
