namespace _06._Profit
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double coins1lev = double.Parse(Console.ReadLine());
            double coins2lev = double.Parse(Console.ReadLine());
            double lev5 = double.Parse(Console.ReadLine());
            double sum = double.Parse(Console.ReadLine());

            for (int i = 0; i <= coins1lev; i++)
            {
                for (int a = 0; a <= coins2lev; a++)
                {
                    for (int b = 0; b <= lev5; b++)
                    {
                        if (i * 1 + a * 2 + b * 5 == sum)
                        {
                            Console.WriteLine($" {i} * 1 lv. + {a} * 2 lv. + {b} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
