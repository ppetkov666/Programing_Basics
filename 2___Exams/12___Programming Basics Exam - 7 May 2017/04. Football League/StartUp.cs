namespace _04._Football_League
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double capacity = double.Parse(Console.ReadLine());
            double nFans = double.Parse(Console.ReadLine());

            double percentAllFans = (nFans / capacity) * 100;
            double sumA = 0;
            double sumB = 0;
            double sumV = 0;
            double sumG = 0;

            for (int i = 1; i <= nFans; i++)
            {
                string sector = Console.ReadLine();
                if (sector == "A") sumA++;
                else if (sector == "B") sumB++;
                else if (sector == "V") sumV++;
                else if (sector == "G") sumG++;
            }

            double totalA = (sumA / nFans) * 100;
            double totalB = (sumB / nFans) * 100;
            double totalV = (sumV / nFans) * 100;
            double totalG = (sumG / nFans) * 100;
            Console.WriteLine($"{totalA:f2}%");
            Console.WriteLine($"{totalB:f2}%");
            Console.WriteLine($"{totalV:f2}%");
            Console.WriteLine($"{totalG:f2}%");
            Console.WriteLine($"{percentAllFans:f2}%");
        }
    }
}
