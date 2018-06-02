namespace _05._Snowflake
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    Console.WriteLine(string.Format("{0}*{1}*{1}*{0}",
               new string('.', i),
               new string('*', n - i)));
                }
                else
                {
                    Console.WriteLine(string.Format("{0}*{1}*{1}*{0}",
               new string('.', i),
               new string('.', n - i)));
                }
            }
            Console.WriteLine(new string('*', 2 * n + 3));

            for (int i = n - 1; i >= 0; i--)
            {
                if (i == n - 1)
                {
                    Console.WriteLine(string.Format("{0}*{1}*{1}*{0}",
               new string('.', i),
               new string('*', n - i)));
                }
                else
                {
                    Console.WriteLine(string.Format("{0}*{1}*{1}*{0}",
               new string('.', i),
               new string('.', n - i)));
                }
            }
        }
    }
}
