namespace _05._Draw_Fort
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int formula = (n * 2) - ((n / 2) * 2) - 4;
            int formula1 = n / 2 + 1;
            //first row
            Console.WriteLine(string.Format("/{0}\\{1}/{0}\\",
                new string('^', n / 2),
                new string('_', formula)));
            //middle row
            for (int i = 1; i <= n - 2; i++)
            {
                if (i == n - 2)
                {
                    Console.WriteLine(string.Format("|{0}{1}{0}|",
                        new string(' ', formula1),
                        new string('_', formula)));
                }
                else
                {
                    Console.WriteLine(string.Format("|{0}|",
                            new string(' ', n * 2 - 2)));
                }
            }
            //last row 
            Console.WriteLine(string.Format("\\{0}/{1}\\{0}/",
                new string('_', n / 2),
                new string(' ', formula)));
        }
    }
}
