namespace _06._Stupid_Password_Generator
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    for (char c = 'a'; c < 'a' + l; c++)
                    {
                        for (char d = 'a'; d < 'a' + l; d++)
                        {
                            for (int e = Math.Max(a, b) + 1; e <= n; e++)
                            {
                                Console.Write($"{a}{b}{c}{d}{e} ");
                            }

                        }
                    }
                }
            }
        }
    }
}
