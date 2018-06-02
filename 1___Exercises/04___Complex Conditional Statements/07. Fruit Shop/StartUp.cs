namespace _07._Fruit_Shop
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double Q = double.Parse(Console.ReadLine());
            double result = -1;
            if (day == "monday" || day == "tuesday" 
                || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana") result = Q * 2.5;
                if (fruit == "apple") result = Q * 1.2;
                if (fruit == "orange") result = Q * 0.85;
                if (fruit == "grapefruit") result = Q * 1.45;
                if (fruit == "kiwi") result = Q * 2.7;
                if (fruit == "pineapple") result = Q * 5.5;
                if (fruit == "grapes") result = Q * 3.85;
            }
            else if (day == "saturday" || day == "sunday")
            {

                if (fruit == "banana") result = Q * 2.7;
                if (fruit == "apple") result = Q * 1.25;
                if (fruit == "orange") result = Q * 0.90;
                if (fruit == "grapefruit") result = Q * 1.60;
                if (fruit == "kiwi") result = Q * 3.00;
                if (fruit == "pineapple") result = Q * 5.60;
                if (fruit == "grapes") result = Q * 4.20;
            }

            if (result < 0)
                Console.WriteLine("error");
            else
                Console.WriteLine($"{result:f2}");
        }
    }
}
