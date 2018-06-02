namespace _01___Dog_House
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double bothSides = sideA * (sideA / 2) * 2;
            double square = (sideA / 2) * (sideA / 2);
            double triangle = (sideA / 2) * (sideB - (sideA / 2)) / 2;
            double backside = square + triangle;
            
            double enterDoor = (sideA / 5) * (sideA / 5);
            double front = backside - enterDoor;

            double total = backside + front + bothSides;
            
            double green = total / 3;
            double roof = sideA * (sideA / 2) * 2;
            double red = roof / 5;
            Console.WriteLine($"{green:f2}");
            Console.WriteLine($"{red:f2}");
        }
    }
}
