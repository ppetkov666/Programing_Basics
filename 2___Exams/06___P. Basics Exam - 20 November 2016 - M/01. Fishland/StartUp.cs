namespace _01._Fishland
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double scadPrice = double.Parse(Console.ReadLine());

            double palmKds = double.Parse(Console.ReadLine());
            double scadKgs = double.Parse(Console.ReadLine());
            double musselsKgs = double.Parse(Console.ReadLine());

            double palmPrice = mackerelPrice + (mackerelPrice * 0.60);
            double palmSum = palmPrice * palmKds;

            double scadprice = scadPrice + (scadPrice * 0.80);
            double scadSum = scadprice * scadKgs;

            double mussels = 7.50;
            double musselsSum = mussels * musselsKgs;

            double check = palmSum + scadSum + musselsSum;
            Console.WriteLine($"{check:0.00}");
        }
    }
}
