namespace Problem_02._Change_Tiles
{
    using System;

    class StartUp
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double tileSideTrianle = double.Parse(Console.ReadLine());
            double tileHightTriangle = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double masterPrice = double.Parse(Console.ReadLine());

            double floorSize = floorWidth * floorLength;
            double tileSum = tileSideTrianle * tileHightTriangle / 2;
            double neededTiles = Math.Ceiling(floorSize / tileSum);
            double neededTilesAndRest = neededTiles + 5;
            double totalSum = neededTilesAndRest * tilePrice + masterPrice;

            if (totalSum <= budget)
            {
                double rest = budget - totalSum;
                Console.WriteLine($"{rest:f2} lv left.");
            }
            else
            {
                double rest = totalSum - budget;
                Console.WriteLine($"You'll need {rest:f2} lv more.");
            }
        }
    }
}
