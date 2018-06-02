namespace _14._Number_Table
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());          
            for (int i = 1; i <= n; i++)
            {
                for (int a = i; a <= n; a++)
                {
                    Console.Write($"{a} ");
                }
                for (int b = 1; b < i; b++)
                {
                    Console.Write($"{n - b} ");
                }
                Console.WriteLine();
            }
        }
    }
}
