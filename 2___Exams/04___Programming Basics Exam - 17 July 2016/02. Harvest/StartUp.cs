namespace _02._Harvest
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double vineyardArea = double.Parse(Console.ReadLine());
            double grapePerSquare = double.Parse(Console.ReadLine());
            double neededLiters = double.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double total = (vineyardArea * grapePerSquare) * 0.4;
            double litersneeds = (total / 2.5);

            if (litersneeds >= neededLiters)
            {
                var rest = Math.Ceiling(litersneeds - neededLiters);
                var perperson = Math.Ceiling(rest / workers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(litersneeds));
                Console.WriteLine("{0} liters left -> {1} liters per person.", rest, perperson);
            }
            else
            {
                var restn = Math.Floor(neededLiters - litersneeds);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", restn);
            }
        }
    }
}
