namespace _03._Final_Competition
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = Console.ReadLine();
            double sum = points * dancers;
            if (location == "Abroad")
            {
                sum = 1.5 * points * dancers;
            }
            if (season == "summer")
            {
                if (location == "Bulgaria")
                {
                    sum = sum - (0.05 * sum);
                }
                else if (location == "Abroad")
                {
                    sum = sum - (0.1 * sum);
                }
            }
            else if (season == "winter")
            {
                if (location == "Bulgaria")
                {
                    sum = sum - (0.08 * sum);
                }
                else if (location == "Abroad")
                {
                    sum = sum - (0.15 * sum);
                }
            }
            double charity = sum * 0.75;
            double restOfTheMoney = sum - charity;
            double moneyPerDancer = restOfTheMoney / dancers;
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");
        }
    }
}
