﻿namespace _06._Stop_Number
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == s)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}
