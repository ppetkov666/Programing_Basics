namespace _06._Number_Generator
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNum = int.Parse(Console.ReadLine());
            int constrolNumber = int.Parse(Console.ReadLine());

            for (int i = m; i >= 1; i--)
            {
                for (int a = n; a >= 1; a--)
                {
                    for (int b = l; b >= 1; b--)
                    {
                        int number = i * 100 + a * 10 + b;

                        if (number % 3 == 0)
                        {
                            specialNum += 5;
                        }
                        else if (number % 10 == 5)
                        {
                            specialNum -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            specialNum *= 2;
                        }

                        if (specialNum >= constrolNumber)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");
                            return;
                        }
                    }
                }
            }
            if (specialNum < constrolNumber)
            {
                Console.WriteLine($"No! {specialNum} is the last reached special number.");
            }
        }
    }
}
