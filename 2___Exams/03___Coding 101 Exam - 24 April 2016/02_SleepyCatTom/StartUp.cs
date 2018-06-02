namespace _02_SleepyCatTom
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double days = double.Parse(Console.ReadLine());
            var workdays = 365 - days;
            double norm = 30000;
            double playtime = (workdays * 63) + (days * 127);
            double diff = Math.Abs(norm - playtime);
            var hours = Math.Truncate(diff / 60);
            var min = diff % 60;

            if (playtime >= norm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, min);
            }
            if (playtime < norm)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, min);
            }
        }
    }
}
