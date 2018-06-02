namespace _02._Toy_Shop
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzel = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int sumToys = puzzel + dolls + bear + minions + trucks;
            var toysmoney = (puzzel * 2.60) + (dolls * 3.00) + (bear * 4.10) +
                (minions * 8.20) + (trucks * 2.00);
            if (sumToys >= 50)
            {
                toysmoney = toysmoney - (toysmoney * 0.25);
            }
            var rent = toysmoney * 0.1;
            var cleanSum = toysmoney - rent;
            var difference = Math.Abs(cleanSum - tripPrice);
            if (cleanSum >= tripPrice)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else if (cleanSum < tripPrice)
            {
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }
        }
    }
}
