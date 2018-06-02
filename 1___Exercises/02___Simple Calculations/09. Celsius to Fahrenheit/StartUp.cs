namespace _09._Celsius_to_Fahrenheit
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double celzius = double.Parse(Console.ReadLine());
            Console.WriteLine((celzius * 1.8) + 32);
        }
    }
}
