namespace _02___Styrofoam
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            double numberOfWindows = double.Parse(Console.ReadLine());
            double sqMeterPerPackage = double.Parse(Console.ReadLine());
            double packagePrice = double.Parse(Console.ReadLine());
            double totalHouseArea = (houseArea - (numberOfWindows * 2.4));
            totalHouseArea = (totalHouseArea * 0.1) + totalHouseArea;
            double packageNeeded = (Math.Ceiling(totalHouseArea / sqMeterPerPackage) * packagePrice);
            if (packageNeeded <= budget)
            {
                Console.WriteLine($"Spent: {packageNeeded:f2}");
                Console.WriteLine($"Left: {budget - packageNeeded:f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {packageNeeded - budget:f2}");
            }
        }
    }
}
