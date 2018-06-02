namespace _13._Number_Pyramid
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int currentDigit = 1;
            for (int i = 1; i <= number; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    Console.Write($"{currentDigit} ");
                    currentDigit++;
                    if (currentDigit > number)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
