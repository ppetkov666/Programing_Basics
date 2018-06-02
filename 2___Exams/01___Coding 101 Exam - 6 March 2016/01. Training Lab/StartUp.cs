namespace _01._Training_Lab
{
    using System;

    class StartUp
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            int rows = (int)(width / 1.2);
            int tables = (int)((height - 1) / 0.7);
            double total = (rows * tables) - 3;

            Console.WriteLine(total);
        }
    }
}
