namespace _06._Number_in_Range__1_till_100_
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Console.Write("Enter a number in the range [1...100]:");
            int n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid number!");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the number is: {0}", n);
        }
    }
}
