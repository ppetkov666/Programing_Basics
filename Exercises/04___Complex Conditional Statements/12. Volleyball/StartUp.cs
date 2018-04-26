namespace _12._Volleyball
{
    using System;
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double gamesInSofia = (48 - h) * 3 / 4;
            double gamesHollydays = p * 2 / 3;
            double total = gamesInSofia + gamesHollydays + h;
            double additional = 0.0;
            if (type == "leap")
            {
                additional = total * 0.15;
                double T = total + additional;
                Console.WriteLine(Math.Floor(T));
            }
            else
                Console.WriteLine(Math.Floor(total));

        }
    }
}
