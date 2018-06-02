namespace Task_02_Company
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double hours = double.Parse(Console.ReadLine());
            double availableDays = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double availableHours = availableDays - (0.1 * availableDays);
            availableHours = availableHours * 8;

            double extra = workers * (2 * availableDays);

            double total = Math.Floor(availableHours + extra);

            double diff = 0;
            if (total >= hours)
            {
                diff = total - hours;
                Console.WriteLine($"Yes!{diff} hours left.");
            }
            else
            {
                diff = (hours - total);
                Console.WriteLine($"Not enough time!{diff} hours needed.");
            }
        }
    }
}
