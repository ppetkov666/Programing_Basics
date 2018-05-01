namespace _12._Fibonacci
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int fibonachiN = int.Parse(Console.ReadLine());
            int x = 1;
            int y = 1;
            for (int i = 1; i <= fibonachiN; i++)
            {
                int sum = x + y;
                x = y;
                y = sum;
            }
            Console.WriteLine(x);
        }
    }
}
