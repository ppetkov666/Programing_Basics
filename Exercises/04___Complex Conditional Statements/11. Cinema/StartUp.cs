namespace _11._Cinema
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string type = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double column = double.Parse(Console.ReadLine());
            double result = 0.0;
            if (type == "Premiere")
            {
                result = rows * column * 12;
            }
            if (type == "Normal")
            {
                result = rows * column * 7.50;
            }
            if (type == "Discount")
            {
                result = rows * column * 5;
            }
            Console.WriteLine($"{result:f2} {"leva"}");

        }
    }
}
