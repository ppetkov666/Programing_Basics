namespace _08._Factorial
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            int counter = 1;
            while (counter <= n)
            {
                sum *= counter;
                counter++;
            }
            Console.WriteLine(sum);
        }
    }
}
