﻿namespace _12.Speed_Info
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double speed = double.Parse(Console.ReadLine());
            if (speed > 1000) Console.WriteLine("extremely fast");
            else if (speed > 150) Console.WriteLine("ultra fast");
            else if (speed > 50) Console.WriteLine("fast");
            else if (speed > 10) Console.WriteLine("average");
            else Console.WriteLine("slow");
        }
    }
}
