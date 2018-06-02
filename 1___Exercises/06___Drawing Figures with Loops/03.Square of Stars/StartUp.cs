namespace _03.Square_of_Stars
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int a = 0; a < n; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
