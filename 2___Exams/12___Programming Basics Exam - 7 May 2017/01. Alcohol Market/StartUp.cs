namespace _01._Alcohol_Market
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiaPrice = priceWhiskey / 2;
            double winePrice = rakiaPrice - (rakiaPrice * 0.4);
            double beerPrice = rakiaPrice - (rakiaPrice * 0.8);

            double sumRakia = rakiaPrice * rakiaQuantity;
            double sumWine = winePrice * wineQuantity;
            double sumBeer = beerPrice * beerQuantity;
            double sumWhiskey = priceWhiskey * whiskeyQuantity;
            double totalSum = sumRakia + sumWine + sumBeer + sumWhiskey;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
