namespace _06._Circle_Area_and_Perimeter
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * (Math.Pow(radius, 2));
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
