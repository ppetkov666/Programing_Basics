namespace _03._Photo_Pictures
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double pics = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string orderType = Console.ReadLine();
            double price = 0;
            if (type == "9X13")
            {
                price += pics * 0.16;
                if (pics >= 50)
                {
                    price -= price * 0.05;
                }
                if (orderType == "online")
                {
                    price -= price * 0.02;
                }
            }
            else if (type == "10X15")
            {
                price += pics * 0.16;
                if (pics >= 80)
                {
                    price -= price * 0.03;
                }
                if (orderType == "online")
                {
                    price -= price * 0.02;
                }
            }
            else if (type == "13X18")
            {
                price += pics * 0.38;
                if (pics >= 50 && pics <= 100)
                {
                    price -= price * 0.03;
                }
                if (pics > 100)
                {
                    price -= price * 0.05;
                }
                if (orderType == "online")
                {
                    price -= price * 0.02;
                }
            }
            else if (type == "20X30")
            {
                price += pics * 2.90;
                if (pics > 10 && pics <= 50)
                {
                    price -= price * 0.07;
                }
                if (pics > 50)
                {
                    price -= price * 0.09;
                }
                if (orderType == "online")
                {
                    price -= price * 0.02;
                }
            }
            Console.WriteLine($"{price:f2}BGN");
        }
    }
}
