namespace _03._Bike_Race
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double njunior = double.Parse(Console.ReadLine());
            double nseniors = double.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            //trail”, “cross-country”, “downhill” или “road

            double taxjunior = 0;
            double taxsenior = 0;

            if (trace == "trail")
            {
                taxjunior = 5.50;
                taxsenior = 7;

            }
            if (trace == "cross-country")
            {

                taxjunior = 8;
                taxsenior = 9.5;


            }
            else if (trace == "downhill")
            {
                taxjunior = 12.25;
                taxsenior = 13.75;
            }
            else if (trace == "road")
            {
                taxjunior = 20;
                taxsenior = 21.50;
            }

            double totaljunior = njunior * taxjunior;
            double totalsenior = nseniors * taxsenior;
            double total = totaljunior + totalsenior;
            if (njunior + nseniors >= 50 && trace == "cross-country")
            {
                total -= total * 0.25;
            }

            total = total - total * 0.05;
            Console.WriteLine($"{total:f2}");
        }
    }
}
