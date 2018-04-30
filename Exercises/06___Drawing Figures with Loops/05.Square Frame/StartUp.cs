namespace _05.Square_Frame
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("| ");
                for (int a = 0; a < n - 2; a++)
                {
                    Console.Write("- ");
                }
                Console.Write("|");
                Console.WriteLine();
            }

            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}
