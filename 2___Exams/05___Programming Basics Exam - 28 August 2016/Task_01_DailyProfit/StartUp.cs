namespace Task_01_DailyProfit
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double workingDays = double.Parse(Console.ReadLine());
            double moneyperday = double.Parse(Console.ReadLine());
            double currencyExchangeRate = double.Parse(Console.ReadLine());
            double bonus = 2.5;
            double montlySalary = workingDays * moneyperday;

            double yearIncome = montlySalary * 12 + montlySalary * bonus;

            double taxes = yearIncome * 0.25;

            double total = (yearIncome - taxes) * currencyExchangeRate;

            double perDay = total / 365;
            Console.WriteLine($"{perDay:f2}");

        }
    }
}
