namespace _03___Vacation
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string country = " ";
            string location = " ";
            double price = 0;

            if (budget <= 1000)
            {
                location = "Camp";
                if (season == "Summer")
                {
                    country = "Alaska";
                    price += 0.65 * budget;
                }
                if (season == "Winter")
                {
                    country = "Morocco";
                    price += 0.45 * budget;
                }

            }
            else if (budget > 1000 && budget <= 3000)
            {
                location = "Hut";
                if (season == "Summer")
                {
                    country = "Alaska";
                    price += 0.8 * budget;
                }
                if (season == "Winter")
                {
                    country = "Morocco";
                    price += 0.6 * budget;
                }

            }
            else if (budget > 3000)
            {
                location = "Hotel";
                if (season == "Summer")
                {
                    country = "Alaska";
                    price += 0.9 * budget;
                }
                if (season == "Winter")
                {
                    country = "Morocco";
                    price += 0.9 * budget;
                }

            }
            Console.Write($"{country} -");
            Console.Write($" {location} -");
            Console.WriteLine($" {price:f2}");

        }
    }
}
