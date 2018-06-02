namespace _05___Parallelepiped
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // height – 4 * n + 4 реда
            // width – 3 * N + 1 колони
            int formulaWidth = 3 * n + 1;
            char plus = '+';
            char wave = '~';
            char dot = '.';
            char vert = '|';
            char left = '\\';
            int formulaRightDots = formulaWidth - (n - 2) - 2;
            int formulaRightDots1 = formulaWidth - (n - 2) - 3;
            int formulaRightDots2 = formulaWidth - (n - 2) - 3;

            Console.WriteLine(string.Format("{0}{1}{0}{2}",
                new string(plus, 1),
                new string(wave, n - 2),
                new string(dot, formulaRightDots)));

            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine(string.Format("{0}{1}{2}{3}{2}{4}",
                    new string(vert, 1),
                    new string(dot, i),
                    new string(left, 1),
                    new string(wave, n - 2),
                    new string(dot, formulaRightDots1)));
                formulaRightDots1--;
            }

            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine(string.Format("{0}{1}{2}{3}{4}{3}",
                    new string(dot, i),
                    new string(left, 1),
                    new string(dot, formulaRightDots2),
                    new string(vert, 1),
                    new string(wave, n - 2)));
                formulaRightDots2--;
            }

            Console.WriteLine(string.Format("{0}{1}{2}{1}",
                new string(dot, formulaWidth - (n - 2) - 2),
                new string(plus, 1),
                new string(wave, n - 2)));
        }
    }
}
