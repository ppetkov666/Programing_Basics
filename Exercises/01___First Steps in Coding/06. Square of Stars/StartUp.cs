namespace _06._Square_of_Stars
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', a));
            for (int i = 1; i <= a - 2; i++)
            {
                Console.WriteLine("*{0}*", new string(' ', a - 2));
            }      
            Console.WriteLine(new string('*', a));
        }
    }
}
