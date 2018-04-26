namespace _03.Even_or_Odd
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
                Console.WriteLine("odd");
        }
    }
}
