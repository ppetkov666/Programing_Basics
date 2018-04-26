namespace _06._Point_on_Rectangle_Border
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool borderup = x >= x1 && x <= x2 && y == y1;
            bool borderdown = x >= x1 && x <= x2 && y == y2;
            bool borderleft = y >= y1 && y <= y2 && x == x1;
            bool borderright = y >= y1 && y <= y2 && x == x2;

            if (borderup || borderdown || borderleft || borderright)
                Console.WriteLine("Border");
            else
                Console.WriteLine("Inside / Outside");
        }
    }
}
