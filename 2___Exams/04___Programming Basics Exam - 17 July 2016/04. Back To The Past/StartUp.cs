namespace _04._Back_To_The_Past
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double inheritMoney = double.Parse(Console.ReadLine());
            double year = double.Parse(Console.ReadLine());
            double yearsIvancho = 18;
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    inheritMoney -= 12000;
                }
                else if (i % 2 != 0)
                {
                    inheritMoney -= 12000 + (yearsIvancho * 50);
                }
                yearsIvancho++;
            }
            if (inheritMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritMoney:f2} dollars left.");
            }
            else if (inheritMoney < 0)
            {
                inheritMoney = Math.Abs(inheritMoney);
                Console.WriteLine($"He will need {inheritMoney:f2} dollars to survive.");
            }
        }
    }
}
