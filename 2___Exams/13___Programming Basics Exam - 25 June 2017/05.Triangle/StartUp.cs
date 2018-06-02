namespace _05.Triangle
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char dot = '.';
            char hash = '#';
            char space = ' ';
            int formula = ((4 * n) - 2) / 2;
            int spaceCounter = 1;
            int dotCounter = 1;
            int hashCounter = ((4 * n + 1) - 3) / 2;

            Console.WriteLine(new string(hash, 4 * n + 1));

            for (int i = 1; i <= n; i++)
            {
                if (i == n / 2 + 1)
                {
                    Console.WriteLine(string.Format("{0}{1}{2}(@){2}{1}{0}",
                    new string(dot, dotCounter),
                    new string(hash, hashCounter),
                    new string(space, (spaceCounter - 3) / 2)));
                    dotCounter++;
                    hashCounter -= 2;
                    spaceCounter += 2;
                }
                else
                {
                    Console.WriteLine(string.Format("{0}{1}{2}{1}{0}",
                 new string(dot, dotCounter),
                 new string(hash, hashCounter),
                 new string(space, spaceCounter)));
                    dotCounter++;
                    hashCounter -= 2;
                    spaceCounter += 2;
                }
            }
            spaceCounter = spaceCounter - 2;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(string.Format("{0}{1}{0}",
                    new string(dot, dotCounter),
                    new string(hash, spaceCounter)));
                dotCounter++;
                spaceCounter -= 2;
            }
        }
    }
}
