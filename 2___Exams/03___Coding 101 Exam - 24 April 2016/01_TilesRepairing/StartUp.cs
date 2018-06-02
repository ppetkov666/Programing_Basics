namespace _01_TilesRepairing
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int squareLength = int.Parse(Console.ReadLine());
            double widthTile = double.Parse(Console.ReadLine());
            double lenghtttile = double.Parse(Console.ReadLine());
            int widthSeat = int.Parse(Console.ReadLine());
            int lengthSeat = int.Parse(Console.ReadLine());

            int sumSquare = squareLength * squareLength;
            int seatArea = widthSeat * lengthSeat;
            int areaForCover = sumSquare - seatArea;
            double tileArea = widthTile * lenghtttile;
            double neededTiles = areaForCover / tileArea;
            double timeNeeded = neededTiles * 0.2;

            Console.WriteLine($"{neededTiles:f2}");
            Console.WriteLine($"{timeNeeded:f2}");
        }
    }
}
