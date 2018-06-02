namespace _01._Tailoring_Workshop
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double tables = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double square = length / 2;
            double coverSize = tables * (length + 2 * 0.3) * (width + 2 * 0.3);
            double squareSize = tables * square * square;
            double priceUsd = coverSize * 7 + squareSize * 9;
            double priceLev = priceUsd * 1.85;
            Console.WriteLine($"{priceUsd:f2} USD");
            Console.WriteLine($"{priceLev:f2} BGN");
        }
    }
}
