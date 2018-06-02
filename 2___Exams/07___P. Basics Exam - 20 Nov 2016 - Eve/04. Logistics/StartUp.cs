namespace _04._Logistics
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double cargoNum = double.Parse(Console.ReadLine());
            double weightCargoSum = 0;
            double sum1money = 0;
            double sum2money = 0;
            double sum3money = 0;
            double sum1numbers = 0;
            double sum2numbers = 0;
            double sum3numbers = 0;

            for (double i = 1; i <= cargoNum; i++)
            {
                double weightCargo = double.Parse(Console.ReadLine());
                weightCargoSum += weightCargo;
                if (weightCargo <= 3)
                {

                    sum1money += weightCargo * 200;
                    sum1numbers += weightCargo;
                }
                else if (weightCargo > 3 && weightCargo <= 11)
                {

                    sum2money += weightCargo * 175;
                    sum2numbers += weightCargo;
                }
                else if (weightCargo > 11)
                {

                    sum3money += weightCargo * 120;
                    sum3numbers += weightCargo;
                }

            }

            double totalSum = (sum1money + sum2money + sum3money) / weightCargoSum;
            double percent1 = (sum1numbers / weightCargoSum) * 100;
            double percent2 = (sum2numbers / weightCargoSum) * 100;
            double percent3 = (sum3numbers / weightCargoSum) * 100;
            Console.WriteLine($"{totalSum:f2}");
            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
        }
    }
}
