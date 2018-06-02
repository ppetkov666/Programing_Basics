namespace _13.Area_of_Figures
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double size = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.Pow(size, 2), 3));
            }
            if (figure == "rectangle")
            {
                double size = double.Parse(Console.ReadLine());
                double size1 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(size * size1, 3));
            }
            if (figure == "circle")
            {
                double size = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * size * size, 3));
            }
            if (figure == "triangle")
            {
                double size = double.Parse(Console.ReadLine());
                double size1 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(size * size1 / 2, 3));
            }
        }
    }
}
