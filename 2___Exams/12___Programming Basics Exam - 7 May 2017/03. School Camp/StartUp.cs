namespace _03._School_Camp
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string season = Console.ReadLine().ToLower();
            string groupType = Console.ReadLine().ToLower();
            double n = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());

            double nightsPrice = 0;
            string sport = string.Empty;
            if (groupType == "boys" || groupType == "girls")
            {
                if (season == "winter") nightsPrice = 9.60;
                else if (season == "spring") nightsPrice = 7.20;
                else if (season == "summer") nightsPrice = 15;
            }
            else if (groupType == "mixed")
            {
                if (season == "winter") nightsPrice = 10;
                else if (season == "spring") nightsPrice = 9.50;
                else if (season == "summer") nightsPrice = 20;
            }


            if (groupType == "girls")
            {
                if (season == "winter") sport = "Gymnastics";
                else if (season == "spring") sport = "Athletics";
                else if (season == "summer") sport = "Volleyball";
            }
            else if (groupType == "boys")
            {
                if (season == "winter") sport = "Judo";
                else if (season == "spring") sport = "Tennis";
                else if (season == "summer") sport = "Football";
            }
            else if (groupType == "mixed")
            {
                if (season == "winter") sport = "Ski";
                else if (season == "spring") sport = "Cycling";
                else if (season == "summer") sport = "Swimming";
            }
            double totalprice = n * nightsPrice * nights;
            if (n >= 50)
            {
                totalprice -= totalprice * 0.5;
            }
            else if (n >= 20 && n < 50)
            {
                totalprice -= totalprice * 0.15;
            }
            else if (n >= 10 && n < 20)
            {
                totalprice -= totalprice * 0.05;
            }

            Console.WriteLine($"{sport} {totalprice:f2} lv.");
        }
    }
}
