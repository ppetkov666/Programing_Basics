namespace _04._Energy_Loss
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double ndays = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double counterEnergy = 0;
            for (double i = 1; i <= ndays; i++)
            {
                double workouthours = double.Parse(Console.ReadLine());
                if (i % 2 != 0 && workouthours % 2 != 0)
                {
                    double next = dancers * 30;
                    counterEnergy += next;
                }
                else if (i % 2 != 0 && workouthours % 2 == 0)
                {
                    double next = dancers * 49;
                    counterEnergy += next;
                }
                else if (i % 2 == 0 && workouthours % 2 == 0)
                {
                    double next = dancers * 68;
                    counterEnergy += next;
                }
                else if (i % 2 == 0 && workouthours % 2 != 0)
                {
                    double next = dancers * 65;
                    counterEnergy += next;
                }

            }
            double totalEnergy = 100 * dancers * ndays;

            double difference = totalEnergy - counterEnergy;

            double unusedEnergy = difference / dancers / ndays;

            if (unusedEnergy >= 50)
            {
                Console.WriteLine($"They feel good! Energy left: {unusedEnergy:f2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {unusedEnergy:f2}");
            }
        }
    }
}
