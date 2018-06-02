namespace _02._Transport_Price
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string daynight = Console.ReadLine();

            double taxid = 0;
            double taxin = 0;
            double bus = 0;
            double train = 0;


            if (n < 20 && daynight == "day") taxid = 0.70 + (n * 0.79);
            else if (n < 20 && daynight == "night") taxin = 0.70 + (n * 0.90);

            if (n >= 20) bus = n * 0.09;
            if (n >= 100) train = n * 0.06;

            if (n < 20 && daynight == "day") Console.WriteLine(taxid);
            else if (n < 20 && daynight == "night") Console.WriteLine(taxin);
            else if (n >= 20 && n < 100) Console.WriteLine(bus);
            else Console.WriteLine(train);

        }
    }
}
