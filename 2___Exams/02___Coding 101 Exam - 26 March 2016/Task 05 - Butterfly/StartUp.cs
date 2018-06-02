namespace Task_05_Butterfly
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char stars = '*';
            char dash = '-';
            char spaces = ' ';
            string format = "{0}\\ /{0}";
            string format2 = "{0}/ \\{0}";
            string dot = "{0}@{0}";
            int formuladot1 = n - 1;

            int formula = ((2 * n) - 3) / 2;

            string formatfirst = string.Format(format,
                new string(stars, formula));
            string formatsecond = string.Format(format,
                new string(dash, formula));
            string formatfirst2 = string.Format(format2,
                new string(stars, formula));
            string formatsecond2 = string.Format(format2,
                new string(dash, formula));
            string dotfinal = string.Format(dot,
                new string(spaces, formuladot1));
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(formatfirst);
                if (i < n / 2)
                {
                    Console.WriteLine(formatsecond);
                }
            }
            Console.WriteLine(dotfinal);

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(formatfirst2);
                if (i < n / 2)
                {
                    Console.WriteLine(formatsecond2);
                }
            }
        }
    }
}
