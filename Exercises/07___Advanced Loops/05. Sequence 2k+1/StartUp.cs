namespace _05._Sequence_2k_1
{
    using System;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                if (num <= n)
                {
                    Console.WriteLine(num);
                    num = 2 * num + 1;
                }
            }
        }
    }
}
