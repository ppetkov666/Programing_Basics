namespace _04.Money_Award
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double parts = double.Parse(Console.ReadLine());
            double moneyPrice = double.Parse(Console.ReadLine());

            double counterBonus = 0;
            double sumpoints = 0;
            for (int i = 1; i <= parts; i++)
            {
                double points = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    counterBonus = points * 2;
                    sumpoints += counterBonus;
                }
                else
                {
                    counterBonus = points;
                    sumpoints += counterBonus;
                }
            }

            double totalSum = moneyPrice * sumpoints;
            Console.WriteLine($"The project prize was {totalSum:f2} lv.");
        }
    }
}
