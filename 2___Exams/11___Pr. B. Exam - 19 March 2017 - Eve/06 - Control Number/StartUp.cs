namespace _06___Control_Number
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            int counter = 0;
            int totalSum = 0;
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = i * 2;
                for (int a = m; a >= 1; a--)
                {
                    counter++;
                    sum1 = a * 3;
                    totalSum = sum + sum1;
                    total += totalSum;

                    if (total >= controlNumber)
                    {
                        Console.WriteLine($"{counter} moves");
                        Console.WriteLine($"Score: {total} >= {controlNumber}");
                        return;
                    }
                }
            }
            if (total < controlNumber)
            {
                Console.WriteLine($"{counter} moves");
            }
        }
    }
}
