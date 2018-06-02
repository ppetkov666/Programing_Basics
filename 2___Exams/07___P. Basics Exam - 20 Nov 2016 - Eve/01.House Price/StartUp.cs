namespace _01.House_Price
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double roomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double pricePerSqMeter = double.Parse(Console.ReadLine());

            var secondRoomArea = roomArea * 1.1;
            var thirdRoomArea = secondRoomArea * 1.1;
            var bathroom = roomArea / 2;
            var totalArea = (roomArea 
                            + kitchenArea 
                            + secondRoomArea 
                            + thirdRoomArea
                            + bathroom) 
                            * 1.05 
                            * pricePerSqMeter;
            Console.WriteLine($"{totalArea:f2}");


        }
    }
}
