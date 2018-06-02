namespace _03___Car_To_Go
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string clas = string.Empty;
            string car = string.Empty;
            if (budget <= 100)
            {
                clas = "Economy class";
                if (season == "summer")
                {
                    car = "Cabrio";
                    budget *= 0.35;
                }
                else if (season == "winter")
                {
                    car = "Jeep";
                    budget *= 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                clas = "Compact class";
                if (season == "summer")
                {
                    car = "Cabrio";
                    budget *= 0.45;
                }
                else if (season == "winter")
                {
                    car = "Jeep";
                    budget *= 0.8;
                }
            }
            else if (budget > 500)
            {
                clas = "Luxury class";
                if (season == "summer")
                {
                    car = "Jeep";
                    budget *= 0.9;
                }
                else if (season == "winter")
                {
                    car = "Jeep";
                    budget *= 0.9;
                }
            }
            Console.WriteLine($"{clas}");
            Console.WriteLine($"{car} - {budget:f2}");

        }
    }
}
