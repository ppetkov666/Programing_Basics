namespace _05._Cup
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char dot = '.';
            char hash = '#';

            int dotCounter = n;
            int hashCounter = (5 * n) - (2 * n);

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(string.Format("{0}{1}{0}",
                                new string(dot, dotCounter),
                                new string(hash, hashCounter)));
                dotCounter++;
                hashCounter -= 2;
            }
            hashCounter = hashCounter - 2;
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine(string.Format("{0}{1}{2}{1}{0}",
                                new string(dot, dotCounter),
                                new string(hash, 1),
                                new string(dot, hashCounter)));
                hashCounter -= 2;
                dotCounter++;
            }

            Console.WriteLine(string.Format("{0}{1}{0}",
                                new string(dot, dotCounter - 1),
                                new string(hash, hashCounter + 4)));
            for (int i = 0; i < n + 2; i++)
            {
                if (i == n / 2)
                {
                    Console.WriteLine(string.Format("{0}D^A^N^C^E^{0}",
                                                    new string(dot, ((5 * n) - 10) / 2)));

                }
                else
                {
                    Console.WriteLine(string.Format("{0}{1}{0}",
                                new string(dot, dotCounter - 3),
                                new string(hash, hashCounter + 8)));
                }

            }
        }
    }
}
