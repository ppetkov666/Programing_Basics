namespace _02._Pets
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double days = double.Parse(Console.ReadLine());
            double leftFood = double.Parse(Console.ReadLine());
            double dogFoodKg = double.Parse(Console.ReadLine());
            double catFoodKg = double.Parse(Console.ReadLine());
            double turtleFoodKg = double.Parse(Console.ReadLine());


            double dogNeeded = dogFoodKg * days;
            double catNeeded = catFoodKg * days;
            double turtleNeeded = (turtleFoodKg * days) / 1000;
            double sum = dogNeeded + catNeeded + turtleNeeded;

            if (sum <= leftFood)
            {
                int diff = (int)(leftFood - sum);
                Console.WriteLine($"{diff} kilos of food left.");
            }
            else
            {
                double difference = Math.Ceiling(sum - leftFood);
                Console.WriteLine($"{difference} more kilos of food are needed.");
            }
        }
    }
}
