namespace Task_01.VeggieMarket
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double veggiePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int veggieKgs = int.Parse(Console.ReadLine());
            int fruitKgs = int.Parse(Console.ReadLine());

            double veggies = veggiePrice * veggieKgs;
            double fruits = fruitPrice * fruitKgs;
            double sum = veggies + fruits;
            double inEuro = (sum / 1.94);

            Console.WriteLine(inEuro);
        }
    }
}
