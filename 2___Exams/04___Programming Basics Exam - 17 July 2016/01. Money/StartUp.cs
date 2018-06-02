namespace _01._Money
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double chinaYoan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            int bitcoinf = bitcoin * 1168;
            double chinaYoanConverted = chinaYoan * 0.15 * 1.76;
            double resultEuro = (bitcoinf + chinaYoanConverted) / 1.95;
            double commisionFinal = resultEuro * (commision / 100);
            double finalresult = resultEuro - commisionFinal;

            Console.WriteLine($"{finalresult:f2}");
        }
    }
}
