namespace _03.Mobile_operator
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string timePeriod = Console.ReadLine().ToLower();
            string type = Console.ReadLine().ToLower();
            string internet = Console.ReadLine().ToLower();
            int month = int.Parse(Console.ReadLine());
            double price = 0;

            if (timePeriod == "one")
            {
                if (type == "small") price = 9.98;
                else if (type == "middle") price = 18.99;
                else if (type == "large") price = 25.98;
                else if (type == "extralarge") price = 35.99;
            }
            else if (timePeriod == "two")
            {
                if (type == "small") price = 8.58;
                else if (type == "middle") price = 17.09;
                else if (type == "large") price = 23.59;
                else if (type == "extralarge") price = 31.79;
            }
            if (internet == "yes")
            {
                if (price <= 10) price = price + 5.50;
                else if (price <= 30) price = price + 4.35;
                else if (price > 30) price = price + 3.85;
            }
            if (timePeriod == "two") price = price - (price * 0.0375);
            double total = month * price;
            Console.WriteLine($"{total:F2} lv.");
        }
    }
}
