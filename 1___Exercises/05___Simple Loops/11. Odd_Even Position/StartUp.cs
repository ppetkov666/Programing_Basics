namespace _11._Odd_Even_Position
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double sumeven = 0;
            double sumodd = 0;

            double maxnumbereven = double.MinValue;
            double minnumbereven = double.MaxValue;
            double maxnumberodd = double.MinValue;
            double minnumberodd = double.MaxValue;
            for (double i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    //even
                    double even = double.Parse(Console.ReadLine());

                    if (even > maxnumbereven) maxnumbereven = even;
                    if (even < minnumbereven) minnumbereven = even;
                    sumeven += even;
                }
                else
                {
                    //odd
                    double odd = double.Parse(Console.ReadLine());

                    if (odd > maxnumberodd) maxnumberodd = odd;
                    if (odd < minnumberodd) minnumberodd = odd;
                    sumodd += odd;

                }
            }
            Console.WriteLine($"OddSum={sumodd}");
            if (minnumberodd == double.MaxValue) Console.WriteLine("OddMin=No");
            else
                Console.WriteLine($"OddMin={minnumberodd}");
            if (maxnumberodd == double.MinValue) Console.WriteLine("OddMax=No");
            else
                Console.WriteLine($"OddMax={maxnumberodd}");

            Console.WriteLine($"EvenSum={sumeven}");
            if (minnumbereven == double.MaxValue) Console.WriteLine("EvenMin=No");
            else
                Console.WriteLine($"EvenMin={minnumbereven}");
            if (maxnumbereven == double.MinValue) Console.WriteLine("EvenMax=No");
            else
                Console.WriteLine($"EvenMax={maxnumbereven}");
        }
    }
}
