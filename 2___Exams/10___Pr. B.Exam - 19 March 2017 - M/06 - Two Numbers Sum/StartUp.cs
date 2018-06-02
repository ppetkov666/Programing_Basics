namespace _06___Two_Numbers_Sum
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int beggining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = beggining; i >= end; i--)
            {
                for (int u = beggining; u >= end; u--)
                {
                    counter++;
                    if (i + u == magicNumber)
                    {

                        Console.Write($"Combination N:{counter}");
                        Console.WriteLine($" ({i} + {u} = {magicNumber})");
                        return;
                    }
                }
            }
            if (counter > 0)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
