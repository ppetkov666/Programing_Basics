namespace _04.Grandpa_Stavri
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double Liters = 0;
            double degrees = 0;
            
            for (int i = 0; i < days; i++)
            {
                double rakiaQuantity = double.Parse(Console.ReadLine());
                double rakiaDegr = double.Parse(Console.ReadLine());
                Liters += rakiaQuantity;
                degrees += rakiaQuantity * rakiaDegr;
            }
            double averageDegree = degrees / Liters;
            Console.WriteLine($"Liter: {Liters:f2}");
            Console.WriteLine($"Degrees: {averageDegree:f2}");
            if (averageDegree < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (averageDegree >= 38 && averageDegree < 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
