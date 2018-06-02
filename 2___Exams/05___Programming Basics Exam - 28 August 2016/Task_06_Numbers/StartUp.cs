namespace Task_06_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int thirdDigit = n % 10;
            int secondDigit = n / 10 % 10;
            int firstDigit = n / 100;
            int row = firstDigit + secondDigit;
            int column = firstDigit + thirdDigit;

            for (int i = 0; i < row; i++)
            {
                for (int a = 0; a < column; a++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - firstDigit;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - secondDigit;
                    }
                    else
                    {
                        n = n + thirdDigit;
                    }
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
