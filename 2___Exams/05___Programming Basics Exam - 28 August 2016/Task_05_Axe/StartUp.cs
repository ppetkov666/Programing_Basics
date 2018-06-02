namespace Task_05_Axe
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char stars = '*';
            char dash = '-';
            int width = 5 * n;
            int dashCounterRight = width - (3 * n) - 2;
            int lastMiddleDash = n - 1;
            int lastLeftDash = 3 * n;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Format("{0}*{1}*{2}",
                    new string(dash, 3 * n),
                    new string(dash, i),
                    new string(dash, dashCounterRight)));
                dashCounterRight--;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(string.Format("{0}*{1}*{2}",
                    new string(stars, 3 * n),
                    new string(dash, n - 1),
                    new string(dash, dashCounterRight + 1)));
            }
            for (int i = 1; i <= n / 2; i++)
            {
                if (i == n / 2)
                {
                    Console.WriteLine(string.Format("{0}*{1}*{2}",
                    new string(dash, lastLeftDash),
                    new string(stars, lastMiddleDash),
                    new string(dash, dashCounterRight + 1)));
                }
                else
                {
                    Console.WriteLine(string.Format("{0}*{1}*{2}",
                  new string(dash, lastLeftDash),
                  new string(dash, lastMiddleDash),
                  new string(dash, dashCounterRight + 1)));
                    lastLeftDash--;
                    lastMiddleDash += 2;
                    dashCounterRight--;
                }
            }
        }
    }
}
