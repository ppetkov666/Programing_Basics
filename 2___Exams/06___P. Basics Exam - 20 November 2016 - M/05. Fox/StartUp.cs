namespace _05._Fox
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char stars = '*';
            char dash = '-';
            int formulaDash = 2 * n - 1;
            int formulaStars = 2 * n - 1;

            int formulaSecondStar = n / 2;
            int formMiddle = n;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(string.Format("{0}\\{1}/{0}",
                new string(stars, i),
                new string(dash, formulaDash)));
                formulaDash -= 2;
            }
            for (int i = 0; i < n / 3; i++)
            {

                Console.WriteLine(string.Format("|{0}\\{1}/{0}|",
                new string(stars, formulaSecondStar),
                new string(stars, formMiddle)));
                formulaSecondStar += 1;
                formMiddle -= 2;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(string.Format("{0}\\{1}/{0}",
                new string(dash, i),
                new string(stars, formulaStars)));
                formulaStars -= 2;
            }
        }
    }
}
