namespace _06.Rhombus_of_Stars
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char spaces = ' ';
            string stars = "* ";

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(spaces, n - i));
                for (int a = 0; a < i; a++)
                {
                    Console.Write(stars);
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i > 0; i--)
            {
                Console.Write(new string(spaces, n - i));
                for (int a = 0; a < i; a++)
                {
                    Console.Write(stars);
                }
                Console.WriteLine();
            }
        }
    }
}
