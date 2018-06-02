namespace _02.Swimming_World_Record
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double goal = distance * time;
            double additionalSeconds = Math.Truncate(distance / 15);
            additionalSeconds = additionalSeconds * 12.5;
            double sumTime = goal + additionalSeconds;
            double difference = Math.Abs(sumTime - record);

            if (sumTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {sumTime:f2} seconds.");
            }
            else if (sumTime >= record)
            {
                Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
            }
        }
    }
}
