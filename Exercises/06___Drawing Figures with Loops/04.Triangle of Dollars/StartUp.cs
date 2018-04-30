namespace _04.Triangle_of_Dollars
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int a = 0; a <= i; a++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
