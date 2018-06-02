namespace _01.Birthday
{
    using System;
    class StartUp
    {

        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * height;

            double liters = volume * 0.001;
            double realPercent = percent * 0.01;

            double realliters = liters * (1 - realPercent);
            Console.WriteLine($"{realliters:F3}");
        }
    }
}
