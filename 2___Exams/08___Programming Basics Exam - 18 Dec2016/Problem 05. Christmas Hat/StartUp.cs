namespace Problem_05._Christmas_Hat
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char dot = '.';
            char star = '*';
            char dash = '-';
            int width = 4 * n + 1;
            int latitude = 2 * n + 5;
            int dashcounter = 0;
            int dotcounter = (width - dashcounter - 3) / 2;
            //firstrow
            Console.WriteLine("{0}/|\\{0}", new string(dot, (width - 3) / 2));
            //secondrow
            Console.WriteLine("{0}\\|/{0}", new string(dot, (width - 3) / 2));
            for (int i = 1; i <= 2 * n - 1; i++)
            {
                Console.WriteLine(string.Format("{0}{1}{2}{1}{2}{1}{0}",
                    new string(dot, dotcounter),
                    new string(star, 1),
                    new string(dash, dashcounter)));
                dotcounter--;
                dashcounter++;
            }
            //lastrowafterloop
            Console.WriteLine(string.Format("{0}{1}{2}{1}{2}{1}{0}",
                    new string(dot, dotcounter),
                    new string(star, 1),
                    new string(dash, dashcounter)));

            //last thirdrow
            Console.WriteLine(new string('*', width));
            //lastmiddlerow
            Console.Write('*');
            for (int i = 1; i <= (width - 1) / 2; i++)
            {

                Console.Write('.');
                Console.Write('*');
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', width));
        }
    }
}
