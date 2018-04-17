namespace _02._Inches_to_Centimeters
{
    using System;
    using System.Globalization;
    class StartUp
    {
        static void Main()
        {
            Console.Write("Inches = ");
            double inches = Double.Parse(Console.ReadLine());
            double cm = inches * 2.54;
            Console.WriteLine("Centimeters = {0} ", cm);
        }
    }
}
