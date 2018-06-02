namespace _05._Rocket
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char dot = '.';
            char star = '*';
            char rightSlash = '/';
            char leftSlash = '\\';
            char space = ' ';
            int spaceCounter = 0;
            int dotCounter = (3 * n - 2) / 2;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(string.Format("{0}{1}{3}{2}{0}",
                    new string(dot, dotCounter),
                    new string(rightSlash, 1),
                    new string(leftSlash, 1),
                    new string(space, spaceCounter)));
                dotCounter--;
                spaceCounter += 2;
            }
            Console.WriteLine(string.Format("{0}{1}{0}",
                   new string(dot, dotCounter + 1),
                   new string(star, spaceCounter)));

            for (int i = 1; i <= n * 2; i++)
            {
                Console.WriteLine(string.Format("{0}|{1}|{0}",
                   new string(dot, dotCounter + 1),
                   new string(leftSlash, spaceCounter - 2)));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(string.Format("{0}/{1}\\{0}",
                   new string(dot, dotCounter + 1),
                   new string(star, spaceCounter - 2)));
                dotCounter--;
                spaceCounter += 2;
            }
        }
    }
}
