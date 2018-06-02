namespace _04_SmartLiLy
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int ages = int.Parse(Console.ReadLine());

            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyprice = double.Parse(Console.ReadLine());

            double toys = 0;
            double money = 0;
            double sum = 0;
            double brothertax = 0;
            for (int i = 1; i <= ages; i++)
            {
                if (i % 2 != 0) toys++;
                else if (i % 2 == 0)
                {
                    money += 10;
                    sum += money;
                    brothertax++;
                }
            }
            double toyssum = toys * toyprice;
            double total = toyssum + sum - brothertax;
            double difference = Math.Abs(total - washingMachinePrice);
            if (total >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {difference:f2}");
            }
            else if (total < washingMachinePrice)
            {
                Console.WriteLine($"No! {difference:f2}");
            }
        }
    }
}
