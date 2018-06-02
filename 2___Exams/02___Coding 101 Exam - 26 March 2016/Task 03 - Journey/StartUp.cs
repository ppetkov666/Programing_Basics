namespace Task_03_Journey
{
    using System;

    class StartUp
    {
        static void Main()
        {
            double budjet = Double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (budjet > 1000)
            {
                budjet *= 0.9;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel " + "- " + "{0:0.00}", budjet);
            }
            if (budjet <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    budjet *= 0.3;
                    Console.WriteLine("Camp " + "- " + "{0:0.00}", budjet);
                }
                if (season == "winter")
                {
                    budjet *= 0.7;
                    Console.WriteLine("Hotel " + "- " + "{0:0.00}", budjet);
                }
            }

            else if (budjet <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    budjet *= 0.4;
                    Console.WriteLine("Camp " + "- " + "{0:0.00}", budjet);
                }
                if (season == "winter")
                {
                    budjet *= 0.8;
                    Console.WriteLine("Hotel " + "- " + "{0:0.00}", budjet);
                }
            }
        }
    }
}
