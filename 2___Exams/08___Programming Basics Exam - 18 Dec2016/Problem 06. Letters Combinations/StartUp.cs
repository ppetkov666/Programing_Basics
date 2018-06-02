namespace Problem_06._Letters_Combinations
{
    using System;
    class StartUp
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char notAllowed = char.Parse(Console.ReadLine());
            int counter = 0;
            for (char x = first; x <= second; x++)
            {
                for (char y = first; y <= second; y++)
                {
                    for (char z = first; z <= second; z++)
                    {
                        if (x == notAllowed || y == notAllowed || z == notAllowed)
                        {
                        }
                        else
                        {
                            counter++;
                            Console.Write($"{x}{y}{z} ");
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
