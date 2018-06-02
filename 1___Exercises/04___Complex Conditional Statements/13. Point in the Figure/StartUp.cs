namespace _13._Point_in_the_Figure
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double h = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool outside = x < h && y > h || x > 2 * h && y > h || y > 4 * h 
                || (x < 0 || x > 3 * h) || (y < 0 || y > 4 * h);
            bool inside = (x > 0 && x < 3 * h) && (y > 0 && y < h) || (x > h && x < 2 * h) 
                && (y > 0 && y < 4 * h) || (x > h && x < 2 * h) && y == h;
            if (outside) Console.WriteLine("outside");
            else if (inside) Console.WriteLine("inside");
            else
                Console.WriteLine("border");
        }
    }
}
