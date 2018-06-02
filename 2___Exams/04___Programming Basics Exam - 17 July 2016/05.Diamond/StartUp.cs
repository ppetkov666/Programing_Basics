namespace _05.Diamond
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char stars = '*';
            char dot = '.';
            int width = 5 * n;
            int dotCounter = n;
            int dotcounter1 = width - (2 * n - 2) - 2;
            int middleDot = 5 * n - 4;
            //width – 5 * n colums and height – 3 * n + 2 

            Console.WriteLine("{0}{1}{0}",
                    new string(dot, dotCounter),
                    new string(stars, (width - (2 * n))));
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string(dot, dotCounter - 1),
                    new string(dot, dotcounter1));
                dotCounter--;
                dotcounter1 += 2;

            }
            Console.WriteLine(new string(stars, 5 * n));
            for (int i = 1; i <= 2 * n + 1; i++)
            {
                if (i == 2 * n + 1)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                                        new string(dot, i),
                                        new string(stars, middleDot));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}",
                                        new string(dot, i),
                                        new string(dot, middleDot));
                    dotCounter = i;
                    dotCounter++;
                    middleDot -= 2;
                }
            }
        }
    }
}
