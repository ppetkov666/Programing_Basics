namespace _05___Hourglass
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char star = '*';
            char dot = '.';
            char monkey = '@';
            char space = ' ';
            int spacecounter = 2 * n - 3;
            int dotcounter = 1;
            int monkeycounter = 2 * n - 5;
            int spacountdownpar = 0;
            //firstrow
            Console.WriteLine(new string(star, 2 * n + 1));
            //secondrow
            Console.WriteLine(string.Format("{0}{1}{2}{1}{0}",
                new string(dot, 1),
                new string(star, 1),
                new string(space, spacecounter)));
            //first cycle from 2 to n-1
            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine(string.Format("{0}{1}{2}{1}{0}",
                new string(dot, dotcounter + 1),
                new string(star, 1),
                new string(monkey, monkeycounter)));
                dotcounter++;
                monkeycounter -= 2;
            }
            //middlerow
            Console.WriteLine(string.Format("{0}{1}{0}",
                new string(dot, dotcounter + 1),
                new string(star, 1)));
            //second loop down part
            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine(string.Format("{0}{1}{2}{3}{2}{1}{0}",
                new string(dot, dotcounter),
                new string(star, 1),
                new string(space, spacountdownpar),
                new string(monkey, 1)));
                dotcounter--;
                spacountdownpar++;
            }
            //row after the loop
            Console.WriteLine(string.Format("{0}{1}{2}{1}{0}",
                new string(dot, dotcounter),
                new string(star, 1),
                new string(monkey, 2 * n - 3)));

            //lastrow
            Console.WriteLine(new string(star, 2 * n + 1));
        }
    }
}
