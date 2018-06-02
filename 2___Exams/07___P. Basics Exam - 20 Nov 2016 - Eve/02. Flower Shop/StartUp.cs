namespace _02._Flower_Shop
{
    using System;
    class StartUp
    {
        public const double MagnoliaPrice = 3.25;
        public const double HyacinthsPrice = 4;
        public const double RosesPrice = 3.50;
        public const double CactiPrice = 8;

        static void Main()
        {
            var numOfMagnolias = int.Parse(Console.ReadLine());
            var numOfHyacinths = int.Parse(Console.ReadLine());
            var numOfRoses = int.Parse(Console.ReadLine());
            var numOfCacti = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            var sum = numOfMagnolias * MagnoliaPrice
                + numOfHyacinths * HyacinthsPrice
                + numOfRoses * RosesPrice
                + numOfCacti * CactiPrice;
            var sumWithoutTaxes = sum * 0.95;

            if (giftPrice <= sumWithoutTaxes)
            {
                var moneyLeft = Math.Floor(sumWithoutTaxes - giftPrice);
                Console.WriteLine($"She is left with {moneyLeft} leva.");
            }
            else
            {
                
                var notEnoughMoney = Math.Ceiling(giftPrice - sumWithoutTaxes);
                Console.WriteLine($"She will have to borrow {notEnoughMoney} leva.");
            }
        }
    }
}
