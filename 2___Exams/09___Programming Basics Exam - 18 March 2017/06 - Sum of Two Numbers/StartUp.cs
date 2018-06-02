namespace _06___Sum_of_Two_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int beg = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicN = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = beg; i <= end; i++)
            {
                for (int b = beg; b <= end; b++)
                {
                    counter++;
                    if (i + b == magicN)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {b} = {magicN})");
                        return;
                    }
                }
            }
            if (counter > 0)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicN}");
            }
        }
    }
}
