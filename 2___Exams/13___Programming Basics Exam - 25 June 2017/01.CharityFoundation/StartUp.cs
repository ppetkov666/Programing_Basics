namespace _01.CharityFoundation
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int chefs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafer = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double sumcakes = cakes * 45;
            double sumWafer = wafer * 5.80;
            double sumPancakes = pancakes * 3.20;
            double sum_per_day = (sumcakes + sumWafer + sumPancakes) * chefs;
            double sum_money = sum_per_day * days;
            double expenses = sum_money / 8;
            double total = sum_money - expenses;
            Console.WriteLine($"{total:f2}");
        }
    }
}
