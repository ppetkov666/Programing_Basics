namespace _05___SoftUni_Logo
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char dots = '.';
            char hash = '#';
            int dotformula = (12 * n - 6) / 2;
            int hashformula = 1;
            //wide 12 * n - 5;
            int middlefor = (4 * n - 2) - (n * 2) - n;
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine(string.Format("{0}{1}{0}",
                    new string(dots, dotformula),
                    new string(hash, hashformula)));
                dotformula -= 3;
                hashformula += 6;

            }
            for (int i = 0; i < middlefor; i++)
            {
                Console.WriteLine(string.Format("|{0}{1}{2}",
                                   new string(dots, dotformula + 5),
                                   new string(hash, hashformula - 12),
                                   new string(dots, dotformula + 6)));

                dotformula += 3;
                hashformula -= 6;
            }
            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine(string.Format("@{0}{1}{2}",
                                   new string(dots, dotformula + 5),
                                   new string(hash, hashformula - 12),
                                   new string(dots, dotformula + 6)));
                }
                else
                {
                    Console.WriteLine(string.Format("|{0}{1}{2}",
                                  new string(dots, dotformula + 5),
                                  new string(hash, hashformula - 12),
                                  new string(dots, dotformula + 6)));
                }
            }
        }
    }
}
