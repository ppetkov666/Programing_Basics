namespace _09.House
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counterStars = 0;
            if (n % 2 == 0) counterStars = 2;
            else counterStars = 1;
            string up = "{0}{1}{0}";
            for (int i = 1; i <= (n + 1) / 2; i++)
            {

                string upPart = string.Format(up, new string('-', (n - counterStars) / 2),
                                                  new string('*', counterStars),
                                                  new string('-', (n - counterStars) / 2));
                counterStars += 2;
                Console.WriteLine(upPart);

            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
