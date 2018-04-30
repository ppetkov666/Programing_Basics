namespace _08.Sunglasses
{
    using System;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char stars = '*';
            char spaces = ' ';
            char side = '/';
            char straight = '|';
            string format = "*{0}*{1}*{0}*";
            string firstAndLastRow = string.Format(format,
                new string(stars, (2 * n) - 2),
                new string(spaces, n));
            string middle = string.Format(format,
                new string(side, (2 * n) - 2),
                new string(spaces, n));
            string middleVert = string.Format(format,
                new string(side, (2 * n) - 2),
                new string(straight, n));
            Console.WriteLine(firstAndLastRow);
            for (int i = 0; i < n - 2; i++)
            {
                if (i == ((n - 1) / 2) - 1)
                    Console.WriteLine(middleVert);
                else
                    Console.WriteLine(middle);
            }
            Console.WriteLine(firstAndLastRow);
        }
    }
}
