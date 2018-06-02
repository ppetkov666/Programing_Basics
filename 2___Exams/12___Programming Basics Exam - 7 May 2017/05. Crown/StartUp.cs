namespace _05._Crown
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char star = '*';
            char dot = '.';
            char space = ' ';
            int spaceCounter = (2 * n - 9) / 2;
            int dotCounter = 1;
            int dotCounter1 = 1;
            Console.WriteLine(string.Format("@{0}@{0}@",
                new string(space, (2 * n - 4) / 2)));
            Console.WriteLine(string.Format("**{0}*{0}**",
                new string(space, (2 * n - 6) / 2)));

            for (int i = 1; i <= n / 2 - 2; i++)
            {
                Console.WriteLine(string.Format("*{0}*{1}*{2}*{1}*{0}*",
                    new string(dot, dotCounter),
                    new string(space, spaceCounter),
                    new string(dot, dotCounter1)));
                spaceCounter -= 2;
                dotCounter++;
                dotCounter1 += 2;
            }

            for (int i = 1; i <= 2; i++)
            {

                if (i == 2)
                {
                    Console.WriteLine(string.Format("*{0}*{2}{3}{2}*{0}*",
                   new string(dot, dotCounter),
                  new string(dot, dotCounter1),
                  new string(star, (dotCounter1 - 1) / 2),
                  new string(dot, 1)));
                    break;
                }
                else
                {
                    Console.WriteLine(string.Format("*{0}*{1}*{0}*",
                                      new string(dot, dotCounter),
                                      new string(dot, dotCounter1)));
                    dotCounter++;
                    dotCounter1 -= 2;
                }
            }

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine(new string(star, 2 * n - 1));
            }
        }
    }
}
