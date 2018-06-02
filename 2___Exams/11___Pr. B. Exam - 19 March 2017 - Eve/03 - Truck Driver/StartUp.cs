namespace _03___Truck_Driver
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string season = Console.ReadLine().ToLower();
            double kmPerMonth = double.Parse(Console.ReadLine());
            string asspring = "spring";
            string asautumn = "autumn";
            string aswinter = "winter";
            string assummer = "summer";
            double seasontime = 4;
            double sallary = 0;

            if (kmPerMonth <= 5000)
            {
                if (season == asspring || season == asautumn)
                {
                    sallary = ((kmPerMonth * 0.75) * seasontime) * 0.9;

                }
                else if (season == assummer)
                {
                    sallary = ((kmPerMonth * 0.90) * seasontime) * 0.9;

                }
                else if (season == aswinter)
                {
                    sallary = ((kmPerMonth * 1.05) * seasontime) * 0.9;

                }
            }
            else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
            {
                if (season == asspring || season == asautumn)
                {
                    sallary = ((kmPerMonth * 0.95) * seasontime) * 0.9;

                }
                else if (season == assummer)
                {
                    sallary = ((kmPerMonth * 1.10) * seasontime) * 0.9;

                }
                else if (season == aswinter)
                {
                    sallary = ((kmPerMonth * 1.25) * seasontime) * 0.9;
                }
            }
            else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                if (season == asspring || season == asautumn)
                {
                    sallary = ((kmPerMonth * 1.45) * seasontime) * 0.9;
                }
                else if (season == assummer)
                {
                    sallary = ((kmPerMonth * 1.45) * seasontime) * 0.9;
                }
                else if (season == aswinter)
                {
                    sallary = ((kmPerMonth * 1.45) * seasontime) * 0.9;
                }
            }
            Console.WriteLine($"{sallary:f2}");
        }
    }
}
