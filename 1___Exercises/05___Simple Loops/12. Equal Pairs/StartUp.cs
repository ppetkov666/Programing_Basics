namespace _12._Equal_Pairs
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                sum2 = sum1;
                int firstN = int.Parse(Console.ReadLine());
                int secondN = int.Parse(Console.ReadLine());
                sum1 = firstN + secondN;
            }
            int difff = Math.Abs(sum1 - sum2);
            if (sum2 == sum1) Console.WriteLine($"Yes, value={sum1}");
            if (n == 1) Console.WriteLine($"Yes, value={sum1}");
            else
                Console.WriteLine($"No, maxdiff={difff}");
        }
    }
}
