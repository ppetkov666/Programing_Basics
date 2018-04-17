namespace _12._Currency_Converter
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double amount = double.Parse(Console.ReadLine());
            string firstcur = Console.ReadLine();
            string secondcur = Console.ReadLine();

            if (firstcur == "USD") amount *= 1.79549;
            if (firstcur == "EUR") amount *= 1.95583;
            if (firstcur == "GBP") amount *= 2.53405;

            if (secondcur == "USD") amount /= 1.79549;
            if (secondcur == "EUR") amount /= 1.95583;
            if (secondcur == "GBP") amount /= 2.53405;
            
            Console.WriteLine("{0:0.00} {1}", amount, secondcur);
        }
    }
}
