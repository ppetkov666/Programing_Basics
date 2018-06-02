namespace Problem_03._Flowers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            double totalAmountOfFlowers = chrysanthemums + roses + tulips;
            double sumChrysanthemums = 0;
            double sumRoses = 0;
            double sumTulips = 0;
            if (season == "Spring" || season == "Summer")
            {
                sumChrysanthemums = chrysanthemums * 2.00;
                sumRoses = roses * 4.10;
                sumTulips = tulips * 2.50;
            }
            if (season == "Autumn" || season == "Winter")
            {
                sumChrysanthemums = chrysanthemums * 3.75;
                sumRoses = roses * 4.50;
                sumTulips = tulips * 4.15;
            }
            double sumAllFlowers = sumChrysanthemums + sumRoses + sumTulips;

            if (holiday == 'Y') sumAllFlowers *= 1.15;
            if (tulips > 7 && season == "Spring") sumAllFlowers = sumAllFlowers - (sumAllFlowers * 0.05);
            if (roses >= 10 && season == "Winter") sumAllFlowers = sumAllFlowers - (sumAllFlowers * 0.1);
            if (totalAmountOfFlowers > 20) sumAllFlowers = sumAllFlowers - (sumAllFlowers * 0.2);

            double finalSumWithArrange = sumAllFlowers + 2;
            Console.WriteLine($"{finalSumWithArrange:f2}");
        }
    }
}
