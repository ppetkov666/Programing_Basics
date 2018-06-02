namespace Task_03_HotelRoom
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string month = Console.ReadLine().ToLower();
            double numberOfNights = int.Parse(Console.ReadLine());

            double apartment = 0;
            double studio = 0;
            if (month == "may" || month == "october")
            {
                studio = 50;
                apartment = 65;
                if (numberOfNights > 14)
                {
                    studio = studio * 0.7;
                    apartment = apartment * 0.9;
                }
                else if (numberOfNights > 7)
                {
                    studio = studio * 0.95;
                }

            }
            if (month == "june" || month == "september")
            {

                studio = 75.20;
                apartment = 68.70;
                if (numberOfNights > 14)
                {
                    studio = studio * 0.8;
                    apartment = apartment * 0.9;
                }
            }
            if (month == "july" || month == "august")
            {
                studio = 76;
                apartment = 77;
                if (numberOfNights > 14) apartment = apartment * 0.9;
            }


            double result = apartment * numberOfNights;
            double resultstudio = studio * numberOfNights;
            Console.WriteLine($"Apartment: {result:f2} lv.");
            Console.WriteLine($"Studio: {resultstudio:f2} lv.");
        }
    }
}
