namespace _14.Time___15_Minutes
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int addmin = min + 15;
            if (addmin <= 59)
            {
                Console.WriteLine($"{hour}:{addmin:d2}");
            }
            if (addmin > 59)
            {
                hour++;
                addmin -= 60;
                if (hour > 23)
                {
                    hour = 0;
                    Console.WriteLine($"{hour}:{addmin:d2}");
                }
                else
                    Console.WriteLine($"{hour}:{addmin:d2}");
            }
        }
    }
}
